using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MODEL;

namespace DAO
{

    public class VendasDAO
    {
        private string sql;
        Conexao con = new Conexao();
        MySqlCommand conn;
        string id_Vendas;

        public void detalhes_lancarvendas()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM detalhes_lancarvendas WHERE id_venda=@id_venda";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_venda", "0");
       //     conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario); 
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.SelectCommand = conn;
            con.FecharConexao();
        }

        public void Buscar_produto_vendas(string nome)
        {
            try
            { 
                con.AbrirConexao();
                MySqlCommand connVerificar;
                MySqlDataReader reader; 
                connVerificar = new MySqlCommand("SELECT * FROM produtos WHERE nome LIKE @nome", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.Add(new MySqlParameter());
                connVerificar.ExecuteNonQuery();
                reader = connVerificar.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                //extraíndo dados da consulta
                while (reader.Read())
                {
                    col.Add(reader.GetString(2));
                }
                 //txt_Buscar.AutoCompleteCustomSource = col;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Erro durante o select no cargo", ex);
            }
        }

        public void Buscar_clientes(PessoaModel pessoa)
        {
            try
            {
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                con.AbrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form, neste caso o estoque
                cmdVerificar = new MySqlCommand("SELECT * FROM clientes WHERE nome LIKE @nome", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.Add(new MySqlParameter("@nome", "%" + pessoa.nome_pessoa + "%"));
                cmdVerificar.ExecuteNonQuery();
                reader = cmdVerificar.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString("nome"));
                }
                con.FecharConexao();
              //  txtcliente.text.AutoCompleteCustomSource = coll;
                con.FecharConexao();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ConcluirVenda(VendaModel venda, PessoaModel pessoa)
        {
            con.AbrirConexao();
            sql = "INSERT INTO venda(cliente, valor, desconto, taxa, valor_total, entrada, pago, apagar, pix, dinheiro, cartao, nota, funcionario, data, status) VALUES(@cliente, @valor, @desconto, @taxa, @valor_total, @entrada, @pago, @apagar, @pix, @dinheiro, @cartao, @nota, @funcionario, curDate(), @status)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", pessoa.nome_pessoa);
            conn.Parameters.AddWithValue("@valor", venda.valor_total);
            conn.Parameters.AddWithValue("@desconto", Convert.ToDouble(venda.valorDescontado));
            conn.Parameters.AddWithValue("@taxa", Convert.ToDouble(venda.taxa));
            conn.Parameters.AddWithValue("@valor_total", venda.valor_total + venda.valor_totalz);
            conn.Parameters.AddWithValue("@entrada", venda.entrada);
            conn.Parameters.AddWithValue("@pago", venda.valor_pago);
            conn.Parameters.AddWithValue("@apagar", (venda.valor_total - venda.cartaoDinheiroPix) + venda.valor_totalz);
            conn.Parameters.AddWithValue("@pix", Convert.ToDouble(venda.pix));
            conn.Parameters.AddWithValue("@dinheiro", Convert.ToDouble(venda.dinheiro));
            conn.Parameters.AddWithValue("@cartao", Convert.ToDouble(venda.cartao));
            conn.Parameters.AddWithValue("@nota", Convert.ToInt32(venda.nota));
           // conn.Parameters.AddWithValue("@funcionario", funcionario.NomeUsuario);
            conn.Parameters.AddWithValue("@status", venda.status);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void lanca_vendaItem(VendaItensModel venda, PessoaModel pessoa)
        {
            try
            {
            con.AbrirConexao();
            sql = "INSERT INTO venda_item(cliente, tipo, movimento, descricao, valor, desconto, taxa, valor_total, cartao, pix, dinheiro, nota, valor_pago, funcionario, id_movimento, data) VALUES(@cliente, @tipo, @movimento, @descricao, @valor, @desconto, @taxa, @valor_total, @cartao, @pix, @dinheiro, @nota, @valor_pago, @funcionario, @id_movimento, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", pessoa.nome_pessoa);
            conn.Parameters.AddWithValue("@tipo", venda.tipo);
            conn.Parameters.AddWithValue("@movimento", venda.movimentacao);
            conn.Parameters.AddWithValue("@descricao", "Produto");
            conn.Parameters.AddWithValue("@valor", venda.valor_totaly);
            conn.Parameters.AddWithValue("@desconto", Convert.ToDouble(venda.valorDescontado));
            conn.Parameters.AddWithValue("@taxa", Convert.ToDouble(venda.taxa));
            conn.Parameters.AddWithValue("@valor_total", venda.valor_total + venda.valor_totalz);
            conn.Parameters.AddWithValue("@cartao", Convert.ToDouble(venda.cartao));
            conn.Parameters.AddWithValue("@pix", Convert.ToDouble(venda.pix));
            conn.Parameters.AddWithValue("@dinheiro", Convert.ToDouble(venda.dinheiro));
            conn.Parameters.AddWithValue("@nota", venda.nota);
            conn.Parameters.AddWithValue("@valor_pago", venda.cartaoDinheiroPix);
          //  conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@id_movimento", venda.ultimoIdVenda);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Verificar_vendas(VendaModel venda)
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            connVerificar = new MySqlCommand("SELECT id FROM lancar_vendas ORDER BY id DESC LIMIT 1", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo dados do id
                while (reader.Read())
                {
                    venda.ultimoIdVenda = Convert.ToString(reader["id"]);
                }
            }
            con.FecharConexao();
        }
        public void Relacionar_vendas(VendaModel venda)
        {
            con.AbrirConexao();
            sql = "UPDATE detalhes_lancarvendas SET id_venda = @id_venda WHERE id_venda = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id", "0");
            conn.Parameters.AddWithValue("@id_venda", venda.ultimoIdVenda);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void BuscarPorEstoque(VendaItensModel venda)
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            connVerificar = new MySqlCommand("SELECT * FROM produtos WHERE id = @id", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@id", venda.idProduto); 
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    venda.atualizarEstoque = Convert.ToString(reader["estoque"]);
                    //venda.estoqueProduto = int.TryParse(reader["estoque"]);
                    object valorDoBanco = reader["estoque"];
                    if (valorDoBanco != null && valorDoBanco != DBNull.Value)
                    {
                        string valorString = valorDoBanco.ToString();
                        int estoque;
                        if (int.TryParse(valorString, out estoque))
                        {
                            venda.estoqueProduto = estoque;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        // Valor do banco de dados está ausente ou nulo
                    }
                }
            }
            con.FecharConexao();
        }
    }

    public class Program
    {
    }
}
