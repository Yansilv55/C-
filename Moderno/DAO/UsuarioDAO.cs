using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DAO
{
    public class UsuarioDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        public List<ServicoMODAL> ListarServicos()
        {
            List<ServicoMODAL> servicos = new List<ServicoMODAL>();

            con.AbrirConexao();
            sql = "SELECT * FROM Servico ORDER BY nome ASC";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ServicoMODAL servico = new ServicoMODAL();
                    servico.servico_id = reader.GetInt32("servico_id");
                    servico.Nome = reader.GetString("nome");

                    servicos.Add(servico);
                }
            }

            con.FecharConexao();
            return servicos;
        }
        public void Buscar_nome(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "SELECT * FROM usuarios WHERE nome LIKE @nome ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.BuscarNome + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }
        public void Carregar_funcionario()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Funcionario.DataSource = dt;
            cb_Funcionario.DisplayMember = "nome";
            con.FecharConexao();
        }
        public void Salvar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "INSERT INTO usuarios(nome, usuario, senha, cargo, data) VALUES(@nome, @usuario, @senha, @cargo, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.Nome);
            conn.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario);
            conn.Parameters.AddWithValue("@senha", usuarioMODEL.Senha);
            conn.Parameters.AddWithValue("@cargo", usuarioMODEL.Cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }

        public void Verificar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            cmdVerificar.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.FecharConexao();
        }
        public void Editar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "UPDATE usuarios SET nome = @nome, usuario = @usuario, senha = @senha, cargo = @cargo  where id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cargo_id", usuarioMODEL.cargo_id);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.Nome);
            conn.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario);
            conn.Parameters.AddWithValue("@senha", usuarioMODEL.Senha);
            conn.Parameters.AddWithValue("@cargo", usuarioMODEL.Cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Excluir_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "DELETE FROM usuarios WHERE cargo_id = @cargo_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cargo_id", usuarioMODEL.cargo_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Buscar_cargo(UsuarioMODEL usuarioMODEL)
        {
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            con.AbrirConexao();
            connVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE nome = @nome", con.con);
            connVerificar.Parameters.AddWithValue("@nome", usuarioMODEL.Funcionario);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuarioMODEL.Cargo = Convert.ToString(reader["cargo"]);
                }
                usuarioMODEL.Cargo = cargo;
            }
            con.FecharConexao();
        }
    }
}
