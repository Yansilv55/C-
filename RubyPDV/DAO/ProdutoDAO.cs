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
            sql = "SELECT * FROM produto WHERE codigo_barra = @codigo_barra";
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
            try
            {
                con.AbrirConexao();
                sql = @"INSERT INTO 
                                produtos(
                                    produto_id,
                                    codigo_barra,
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
                                    @codigo_barra, 
                                    @nome, 
                                    @descricao, 
                                    @estoque, 
                                    @fornecedor, 
                                    @entrada, 
                                    @total_compra, 
                                    @valor_unitario, 
                                    @valor_venda, 
                                    CURDATE(),
                                    @minimo, 
                                    @nota, 
                                    @lucro)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@produto_id", produto.produto_id);
                conn.Parameters.AddWithValue("@codigo_barra", produto.codigo_barra);
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
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar produto", ex);
            }
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
                    produto.codigo_barra = reader.GetString("codigo_barra");
                    produto.Nome = reader.GetString("nome");
                    produto.Descricao = reader.GetString("descricao");
                    produto.Entrada_estoque = reader.GetString("estoque");
                    produto.Fornecedor = reader.GetString("fornecedor");
                    produto.Entrada = reader.GetString("entrada");
                    produto.total_compra = reader.GetInt32("total_compra");
                    produto.Unitario = reader.GetInt32("valor_unitario");
                    produto.valor_venda = reader.GetInt32("valor_venda");
                    produto.data = reader.GetString("data");
                    produto.Minimo = reader.GetInt32("minimo");
                    produto.Nota = reader.GetInt32("nota");
                    produto.lucro = reader.GetInt32("lucro");

                    produtos.Add(produto);
                }
            }

            con.FecharConexao();
            return produtos;
        }
        public List<ProdutosModel> Carregar_campo()
        {
            List<ProdutosModel> forncedores = new List<ProdutosModel>();
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedor ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProdutosModel fornecedor = new ProdutosModel();
                    fornecedor.Fornecedor = reader.GetString("nome");

                    forncedores.Add(fornecedor);
                }
            }
            con.FecharConexao();
            return forncedores;
        }
    }
}
