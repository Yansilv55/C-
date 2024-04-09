using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ServicoDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        public List<ServicoMODAL> ListarServicos()
        {
            List<ServicoMODAL> servicos = new List<ServicoMODAL>();

            con.AbrirConexao();
            sql = "SELECT * FROM servico ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ServicoMODAL servico = new ServicoMODAL();
                    servico.servico_id = reader.GetInt32("servico_id");
                    servico.nome = reader.GetString("nome");
                    servico.valor = reader.GetDecimal("valor");

                    servicos.Add(servico);
                }
            }

            con.FecharConexao();
            return servicos;
        }
        public void Salvar_servico(ServicoMODAL servico)
        {
            con.AbrirConexao();
            sql = "INSERT INTO servico(nome, valor) VALUES(@nome, @valor)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", servico.nome);
            conn.Parameters.AddWithValue("@valor", servico.valor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Editar_servico(ServicoMODAL servico)
        {
            con.AbrirConexao();
            sql = "UPDATE servico SET nome = @nome, valor = @valor WHERE servico_id = @servico_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@servico_id", servico.servico_id);
            conn.Parameters.AddWithValue("@nome", servico.nome);
            conn.Parameters.AddWithValue("@valor", servico.valor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Excluir_servico(ServicoMODAL servico)
        {
            con.AbrirConexao();
            sql = "DELETE FROM servico WHERE servico_id = @servico_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@servico_id", servico.servico_id) ;
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
