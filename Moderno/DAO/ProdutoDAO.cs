using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoDAO
    {
        private string sql;
        Conexao con = new Conexao();
        MySqlCommand conn;
        string produto_id;
        public void BuscarProduto()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedor WHERE fornecedor_id = @fornecedor";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.FecharConexao();
        }
    }
}
