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
    public class CaixaDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        public List<CaixaMODEL> ListarCaixa()
        {
            List<CaixaMODEL> caixas = new List<CaixaMODEL>();

            con.AbrirConexao();
            sql = "SELECT * FROM caixa ORDER BY nome ASC"; 
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    CaixaMODEL caixa = new CaixaMODEL(); 
                    caixa.caixa_id = reader.GetInt32("caixa_id");
                    caixa.Nome = reader.GetString("nome");

                    caixas.Add(caixa); 
                }
            }
            con.FecharConexao();
            return caixas; 
        }
        public void Buscar_data(CaixaMODEL caixaMODEL)
        {
            con.AbrirConexao();
            sql = "SELECT * FROM caixa WHERE data>=@dataInicial AND data<=@dataFinal AND tipo=@tipo ORDER BY data DESC ";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(caixaMODEL.Data_inicial));
            conn.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(caixaMODEL.Data_final));
            conn.Parameters.AddWithValue("@tipo", caixaMODEL.Tipo);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }
    }
}
