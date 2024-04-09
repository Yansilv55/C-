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

        
        public List<UsuarioMODEL> ListarUsuario()
        {
            List<UsuarioMODEL> usuarios = new List<UsuarioMODEL>();

            con.AbrirConexao();
            sql = "SELECT * FROM usuarios ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    UsuarioMODEL usuario = new UsuarioMODEL();
                    usuario.cargo_id = reader.GetInt32("cargo_id");
                    usuario.Funcionario = reader.GetString("nome");
                    usuario.Usuario = reader.GetString("usuario");
                    usuario.cargo = reader.GetString("senha");
                    usuario.senha = reader.GetString("cargo");
                    usuario.data = reader.GetString("data");
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public List<UsuarioMODEL> BuscarNome(String txtUsuario)
        {
            List<UsuarioMODEL> usuarios = new List<UsuarioMODEL>();

            con.AbrirConexao();
            sql = "SELECT * FROM usuarios WHERE nome LIKE @nome ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", $"{txtUsuario}%");
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    UsuarioMODEL usuario = new UsuarioMODEL();
                    usuario.cargo = reader.GetString("cargo");
                    usuario.nome = reader.GetString("nome");

                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public List<FuncionarioMODEL> CarregarFuncionario()
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
                    funcionario.nome = reader.GetString("nome");
                    
                    funcionario.cargo = Convert.ToString(reader["cargo"]);
                    
                    funcionarios.Add(funcionario);
                }
            }
            return funcionarios;
        }
        /*
         
         * 
         * MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form, neste caso quero saber se o quarto tem ocupacao
            con.AbrirConexao();
            cmdVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE nome = @nome", con.con);
            cmdVerificar.Parameters.AddWithValue("@nome", cbFuncionario.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //extraíndo dados da tab hospede
                while (reader.Read())
                {
                    Cargo = Convert.ToString(reader["cargo"]);//                    
                }
                txtCargo.Text = Cargo;
            }
            con.FecharConexao();
*/

        /*public void Salvar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "INSERT INTO usuarios(nome, usuario, senha, cargo, data) VALUES(@nome, @usuario, @senha, @cargo, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.Nome);
            //conn.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario);
            conn.Parameters.AddWithValue("@senha", usuarioMODEL.senha);
            conn.Parameters.AddWithValue("@cargo", usuarioMODEL.cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }*/
        public void Salvar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "INSERT INTO usuarios(nome, usuario, senha, cargo, data) VALUES(@nome, @usuario, @senha, @cargo, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.nome);
            conn.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario); // Adiciona o parâmetro @usuario
            conn.Parameters.AddWithValue("@senha", usuarioMODEL.senha);
            conn.Parameters.AddWithValue("@cargo", usuarioMODEL.cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }

        public bool VerificarUsuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            sql = "SELECT * FROM usuarios WHERE usuario = @usuario";
            cmdVerificar = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = cmdVerificar.ExecuteReader())
            {
                while (reader.Read())
                {
                    return true;
                }
            }
            return false;
        }

        public void Editar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = "UPDATE usuarios SET nome = @nome, usuario = @usuario, senha = @senha, cargo = @cargo  where id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cargo_id", usuarioMODEL.cargo_id);
            conn.Parameters.AddWithValue("@nome", usuarioMODEL.nome);
            conn.Parameters.AddWithValue("@usuario", usuarioMODEL.Usuario);
            conn.Parameters.AddWithValue("@senha", usuarioMODEL.senha);
            conn.Parameters.AddWithValue("@cargo", usuarioMODEL.cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void ExcluirUsuario(UsuarioMODEL usuarioMODEL)
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
                    usuarioMODEL.cargo = Convert.ToString(reader["cargo"]);
                }
                //usuarioMODEL.Cargo = cargo;
            }
            con.FecharConexao();
        }
    }
}
