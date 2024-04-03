using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class FuncionarioDAO
    {
        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand conn;
        string funcionario_id;

        public void Salvar_funcionario(FuncionarioMODEL funcionario)
        {
            try
            {
            con.AbrirConexao();
            sql = "SELECT * FROM `funcionario`";
            conn = new MySqlCommand(sql, con.con);

            sql =@"INSERT INTO
                      funcionario (
                                nome,
                                cpf, 
                                telefone, 
                                cargo, 
                                endereco, 
                                data, 
                                foto) 
                        VALUES(
                                @nome,
                                @cpf, 
                                @telefone,
                                @cargo, 
                                @endereco, 
                                curDate(),
                                @foto)";

            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", funcionario.Nome);
            conn.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            conn.Parameters.AddWithValue("@telefone", funcionario.Celular);
            conn.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            conn.Parameters.AddWithValue("@endereco", funcionario.Endereco);
            conn.Parameters.AddWithValue("@foto", funcionario.img);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro a Salvar arquivo", ex);            }
        }
       /* public void Verificar_cpf(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                sql = @"SELECT * FROM funcionario WHERE cpf = @cpf";
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                DataTable dt = new DataTable();
                da.Fill(dt);

                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar", ex);
            }
        }*/
        public bool VerificarDuplicidadeCPF(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                string sql = @"SELECT COUNT(*) FROM funcionario WHERE cpf = @cpf";
                MySqlCommand connVerificar = new MySqlCommand(sql, con.con);
                connVerificar.Parameters.AddWithValue("@cpf", funcionario.Cpf);

                int count = Convert.ToInt32(connVerificar.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao verificar", ex);
            }
        }
        public bool VerificarDuplicidadeCelular(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                string sql = @"SELECT COUNT(*) FROM funcionario WHERE telefone = @telefone";
                MySqlCommand command = new MySqlCommand(sql, con.con);
                command.Parameters.AddWithValue("@telefone", funcionario.Celular);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar", ex);
            }
        }
        //----------------------------------------------------------------------------------------
        public void Buscar_nome(FuncionarioMODEL funcionario, DataGridView grid)
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM funcionario WHERE nome LIKE @nome ORDER BY nome asc";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", funcionario.BuscarNome  + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = conn;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Buscar", ex);
            }
        }
        //------------------------------------------------------------------------------------------
        public void Buscar_cpf(FuncionarioMODEL funcionario, DataGridView grid)
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM funcionario WHERE cpf = @cpf ORDER BY nome asc";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@cpf", funcionario.BuscarCpf);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = conn;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Buscar", ex);
            }
        }
        public List<FuncionarioMODEL> ListarFuncionario()
        {
            List<FuncionarioMODEL> funcionarios = new List<FuncionarioMODEL>(); 
            con.AbrirConexao();
            sql = "SELECT * FROM funcionario ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    FuncionarioMODEL funcionario = new FuncionarioMODEL();
                    funcionario.funcionario_id = reader.GetInt32("funcionario_id");
                    funcionario.Nome = reader.GetString("nome");

                    funcionarios.Add(funcionario); 
                }
            }
            con.FecharConexao();
            return funcionarios;
        }
        public void Carregar_campo(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cargos ORDER BY cargo asc";
                conn = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = conn;
                DataTable dt = new DataTable();
                da.Fill(dt);
                //------------------------------------------------------------------------
                //txt_Cargo.DataSource = dt;
                //txt_Cargo.DisplayMember = "cargo";
                con.FecharConexao();
            }
            catch (Exception ex )
            {
                throw new Exception("Erro ao editar", ex);
            }
        }
        public void Editar_funcionario(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                sql = "UPDATE funcionario SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", funcionario.Nome);
                conn.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                conn.Parameters.AddWithValue("@telefone", funcionario.Celular);
                conn.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                conn.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                conn.Parameters.AddWithValue("@funcionario_id", funcionario.funcionario_id);
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar", ex);
            }
        }
        public void Excluir_Registro(FuncionarioMODEL funcionario)
        {
            con.AbrirConexao();
            sql = "DELETE FROM funcionario WHERE funcionario_id = @funcionario_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@funcionario_id", funcionario.funcionario_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void AtualizarLinhas()
        {
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string linha = "";

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            linha += reader[i].ToString() + "       \t";
                        }
                        if (!string.IsNullOrEmpty(linha))
                        {
                            linha = linha.Substring(0, linha.Length - 1);
                        }
                        Console.WriteLine(linha);
                    }
                }
            }
        }
    }
}
