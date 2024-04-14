using MODEL;
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
        public ProdutosModel BuscarProduto(String produto)
        {
            ProdutosModel produtoModel = new ProdutosModel();
            con.AbrirConexao();
            sql = "SELECT * FROM produto WHERE codigo_barras = @codBarras";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.FecharConexao();
            return produtoModel;
        }
        public void SalvarProduto(ProdutosModel produto)
        {
            //  try
            //  {
            con.AbrirConexao();
            sql = @"INSERT INTO 
                        produtos(
                            produto_id,
                            nome,
                            descricao,
                            estoque,
                            fornecedor,
                            entrada,
                            total_compra,
                            valor_unitario,
                            valor_venda,
                            data,
                            minimo,
                            nota,
                            lucro) 
                         VALUES(
                            @produto_id, 
                            @nome, 
                            @descricao, 
                            @estoque, 
                            @fornecedor, 
                            @entrada, 
                            @total_compra, 
                            @valor_unitario, 
                            @valor_venda, 
                            curdate(), -- Corrigido para curdate()
                            @minimo, 
                            @nota, 
                            @lucro)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@produto_id", produto.produto_id); 
            conn.Parameters.AddWithValue("@nome", produto.Nome);
            conn.Parameters.AddWithValue("@descricao", produto.Descricao);
            conn.Parameters.AddWithValue("@estoque", produto.Entrada_estoque);
            conn.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);
            conn.Parameters.AddWithValue("@entrada", produto.Entrada);
            conn.Parameters.AddWithValue("@total_compra", Convert.ToDouble(produto.total_compra));
            conn.Parameters.AddWithValue("@valor_unitario", Convert.ToDouble(produto.Unitario));
            conn.Parameters.AddWithValue("@valor_venda", Convert.ToDouble(produto.valor_venda));
            conn.Parameters.AddWithValue("@minimo", Convert.ToInt32(produto.Minimo));
            conn.Parameters.AddWithValue("@nota", Convert.ToInt32(produto.Nota));
            conn.Parameters.AddWithValue("@lucro", Convert.ToDouble(produto.valor_venda) - Convert.ToDouble(produto.Unitario));
            conn.ExecuteNonQuery();
            con.FecharConexao();

            // }
            //catch (Exception ex)
            // {
            //    throw new Exception("Erro ao Salvar ao banco", ex);
            // }
        }
        public void EditaProduto(ProdutosModel produto)
        {
            con.AbrirConexao();
            sql = @"UPDATE 
                       produtos SET (
                                cod = @cod,
                                nome = @nome,
                                descricao = @descricao,
                                estoque = @estoque,
                                fornecedor = @fornecedor,
                                entrada = @entrada,
                                total_compra = @total_compra,
                                valor_venda = @valor_venda,
                                valor_compra = @valor_compra,data = @data,
                                minimo = @minimo,
                                nota = @nota,
                                lucro = @lucro
                        WHERE
                                produto_id = @produto_id)";
                
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@produtos", produto.produto_id);
            conn.Parameters.AddWithValue("@nome", produto.Nome);
            conn.Parameters.AddWithValue("@descricao", produto.Descricao);
            conn.Parameters.AddWithValue("@estoque", produto.Entrada_estoque);
            conn.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);
            conn.Parameters.AddWithValue("@entrada", produto.Entrada);
            conn.Parameters.AddWithValue("@total_compra", Convert.ToDouble(produto.valor_venda));
            conn.Parameters.AddWithValue("@valor_compra", Convert.ToDouble(produto.valor_compra));
            conn.Parameters.AddWithValue("@valor_venda", Convert.ToDouble(produto.valor_venda));
            conn.Parameters.AddWithValue("@minimo", Convert.ToInt32(produto.Minimo));
            conn.Parameters.AddWithValue("@nota", Convert.ToInt32(produto.Nota));
            conn.Parameters.AddWithValue("@lucro", Convert.ToDouble(produto.valor_venda) - Convert.ToDouble(produto.Unitario));
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void ExcluirProduto()
        {
            con.AbrirConexao();
            sql = "DELET FROM produto WHERE produto_id = @produto_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("produto_id", produto_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public List<ProdutosModel> ListarProdutos()
        {
            List<ProdutosModel> produtos = new List<ProdutosModel>();

            con.AbrirConexao();
            sql = "SELECT * FROM produtos ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProdutosModel produto = new ProdutosModel();
                    produto.produto_id = reader.GetInt32("produto_id");
                    produto.Nome = reader.GetString("nome");

                    produtos.Add(produto);
                }
            }

            con.FecharConexao();
            return produtos;
        }
    }
}
