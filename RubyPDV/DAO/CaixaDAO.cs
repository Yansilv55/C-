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
                    caixa.nome = reader.GetString("nome");

                    caixas.Add(caixa); 
                }
            }
            con.FecharConexao();
            return caixas; 
        }
        public List<CaixaMODEL> Buscar_data()
        {
            List<CaixaMODEL> caixas = new List<CaixaMODEL>();

            con.AbrirConexao();
            sql = @"SELECT * FROM caixa WHERE data>=@dataInicial AND data<=@dataFinal AND tipo=@tipo ORDER BY data DESC ";
            conn = new MySqlCommand(sql, con.con);

            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    CaixaMODEL caixa = new CaixaMODEL();
                    caixa.data_inicial = reader.GetInt32("dataInicial");
                    caixa.data_final = reader.GetInt32("dataFinal");
                    caixa.tipo = reader.GetString("tipo");

                    caixas.Add(caixa);
                }
            }
            return caixas;
        }
    }
}
