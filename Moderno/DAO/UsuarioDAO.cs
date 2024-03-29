using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class UsuarioDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        public List<UsuarioMODEL>lisServicos()
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
    }
}
