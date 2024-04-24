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
           /* List<FuncionarioMODEL> funcionarios = new List<FuncionarioMODEL>();

          con.AbrirConexao();
            sql = @"SELECT f.nome, c.descricao AS cargo 
                  FROM funcionario f 
                  inner JOIN cargo c ON f.id_cargo = c.id_cargo 
                  ORDER BY f.nome ASC";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    FuncionarioMODEL funcionario = new FuncionarioMODEL();
                    funcionario.nome = reader.GetString("nome");
                    funcionario.cargo = reader.GetString("cargo");
                    funcionarios.Add(funcionario);
                }
            }
            return funcionarios;
        }*/
        public void Salvar_usuario(UsuarioMODEL usuarioMODEL)
        {
            con.AbrirConexao();
            sql = @"INSERT INTO 
                          usuarios(
                                nome, 
                                usuario, 
                                senha, 
                                cargo, 
                                data) 
                           VALUES(
                                @nome, 
                                @usuario, 
                                @senha, 
                                @cargo, 
                                curDate())";
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
            sql = @"UPDATE 
                       usuarios
                             SET
                                nome = @nome, 
                                usuario = @usuario, 
                                senha = @senha,
                                cargo = @cargo  
                             where 
                                cargo_id = @cargo_id";
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
    }
}
