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
        //string funcionario_id;

        public void Salvar_funcionario(FuncionarioMODEL funcionario)
        {
            try
            {
            con.AbrirConexao();
            sql =@"INSERT INTO
                      funcionario (
                                nome,
                                cpf, 
                                telefone, 
                                cargo, 
                                endereco, 
                                data) 
                        VALUES(
                                @nome,
                                @cpf, 
                                @telefone,
                                @cargo, 
                                @endereco, 
                                curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", funcionario.nome);
            conn.Parameters.AddWithValue("@cpf", funcionario.cpf);
            conn.Parameters.AddWithValue("@telefone", funcionario.celular);
            conn.Parameters.AddWithValue("@cargo", funcionario.cargo);
            conn.Parameters.AddWithValue("@endereco", funcionario.endereco);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a Salvar arquivo", ex);          
            }
        }
        public bool VerificarDuplicidadeFuncionario(int funcionario_id, string nomeCampo, string valorCampo)
        {
            try
            {
                con.AbrirConexao();
                string sql = $@"SELECT 
                                    COUNT(*) 
                                FROM 
                                    funcionario 
                                WHERE 
                                    {nomeCampo} = @campo
                                AND 
                                    funcionario_id != @funcionario_id";

                MySqlCommand connVerificar = new MySqlCommand(sql, con.con);
                connVerificar.Parameters.AddWithValue("@campo", valorCampo);
                connVerificar.Parameters.AddWithValue("@funcionario_id", funcionario_id);

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
                command.Parameters.AddWithValue("@telefone", funcionario.celular);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar", ex);
            }
        }
        //---------------------------------------------------------------------------------------
        public List<FuncionarioMODEL> ListaBuscarFuncionario(string nome)
        {
            List<FuncionarioMODEL> funcionarios = new List<FuncionarioMODEL>();

            con.AbrirConexao();
            sql = "SELECT * FROM funcionario WHERE nome LIKE @nome ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", "%" + nome + "%");
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    FuncionarioMODEL funcionario = new FuncionarioMODEL();
                    funcionario.nome = reader.GetString("nome");

                    funcionarios.Add(funcionario);
                }
            }
            return funcionarios;
        }
        //------------------------------------------------------------------------------------------
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
                    funcionario.nome = reader.GetString("nome");
                    funcionario.cpf = reader.GetString("cpf");
                    funcionario.celular = reader.GetString("telefone");
                    funcionario.cargo = reader.GetString("cargo");
                    funcionario.endereco = reader.GetString("endereco");
                    funcionario.data = reader.GetString("data");

                    funcionarios.Add(funcionario); 
                }
            }
            con.FecharConexao();
            return funcionarios;
        }
        public List<FuncionarioMODEL> Carregar_campo()
        {
            List<FuncionarioMODEL> funcionarios = new List<FuncionarioMODEL>();
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    FuncionarioMODEL funcionario = new FuncionarioMODEL();
                    funcionario.cargo = reader.GetString("cargo");

                    funcionarios.Add(funcionario);
                }
            }
            con.FecharConexao();
            return funcionarios;
        }
        public void Editar_funcionario(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                sql = "UPDATE funcionario SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco WHERE funcionario_id = @funcionario_id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@funcionario_id", funcionario.funcionario_id);
                conn.Parameters.AddWithValue("@nome", funcionario.nome);
                conn.Parameters.AddWithValue("@cpf", funcionario.cpf);
                conn.Parameters.AddWithValue("@telefone", funcionario.celular);
                conn.Parameters.AddWithValue("@cargo", funcionario.cargo);
                conn.Parameters.AddWithValue("@endereco", funcionario.endereco);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar", ex);
            }
        }
        public void Excluir_Registro(FuncionarioMODEL funcionario)
        {
            try
            {
                con.AbrirConexao();
                sql = "DELETE FROM funcionario WHERE funcionario_id = @funcionario_id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@funcionario_id", funcionario.funcionario_id);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
