using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
namespace DAO
{

    public class VendasDAO
    {
        private string sql;
        Conexao con = new Conexao();
        MySqlCommand conn;
        string id_Vendas;

        public object Program { get; private set; }

        public void detalhes_lancarvendas()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM detalhes_lancarvendas WHERE id_venda=@id_venda";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_venda", "0");
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario); 
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.SelectCommand = conn;
            con.FecharConexao();
        }

        public void Buscar_produto_vendas(TextBox txt_Buscar)
        {
            try
            { 
                con.AbrirConexao();
                MySqlCommand connVerificar;
                MySqlDataReader reader; 
                connVerificar = new MySqlCommand("SELECT * FROM produtos WHERE nome LIKE @nome", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.Add(new MySqlParameter("@nome", "%" + txt_Buscar + "%"));
                connVerificar.ExecuteNonQuery();
                reader = connVerificar.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                //extraíndo dados da consulta
                while (reader.Read())
                {
                    col.Add(reader.GetString(2));
                }
                 txt_Buscar.AutoCompleteCustomSource = col;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Erro durante o select no cargo", ex);
            }
        }

        public void Buscar_clientes()
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
                cmdVerificar.Parameters.Add(new MySqlParameter("@nome", "%" + txtClientes.Text + "%"));
                cmdVerificar.ExecuteNonQuery();
                reader = cmdVerificar.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString("nome"));
                }
                con.FecharConexao();
                txtClientes.AutoCompleteCustomSource = coll;
                con.FecharConexao();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ConcluirVendas(string nome)
        {
            con.AbrirConexao();
            sql = "INSERT INTO lancar_vendas(cliente, valor, desconto, taxa, valor_total, entrada, pago, apagar, pix, dinheiro, cartao, nota, funcionario, data, status) VALUES(@cliente, @valor, @desconto, @taxa, @valor_total, @entrada, @pago, @apagar, @pix, @dinheiro, @cartao, @nota, @funcionario, curDate(), @status)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", nome);
            conn.Parameters.AddWithValue("@valor", nome);
            conn.Parameters.AddWithValue("@desconto", Convert.ToDouble(nome));
            conn.Parameters.AddWithValue("@taxa", Convert.ToDouble(nome));
            conn.Parameters.AddWithValue("@valor_total", nome + nome);
            conn.Parameters.AddWithValue("@entrada", nome);
            conn.Parameters.AddWithValue("@pago", nome);
            conn.Parameters.AddWithValue("@apagar", (nome - nome) + nome);
            conn.Parameters.AddWithValue("@pix", Convert.ToDouble(nome));
            conn.Parameters.AddWithValue("@dinheiro", Convert.ToDouble(nome));
            conn.Parameters.AddWithValue("@cartao", Convert.ToDouble(nome));
            conn.Parameters.AddWithValue("@nota", Convert.ToInt32(nome));
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@status", "Aberto");
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void lanca_movimentações()
        {
            con.AbrirConexao();
            sql = "INSERT INTO lancar_movimentacoes(cliente, tipo, movimento, descricao, valor, desconto, taxa, valor_total, cartao, pix, dinheiro, nota, valor_pago, funcionario, id_movimento, data) VALUES(@cliente, @tipo, @movimento, @descricao, @valor, @desconto, @taxa, @valor_total, @cartao, @pix, @dinheiro, @nota, @valor_pago, @funcionario, @id_movimento, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", txtClientes.Text);
            conn.Parameters.AddWithValue("@tipo", "Entrada");
            conn.Parameters.AddWithValue("@movimento", "Venda com entrada");
            conn.Parameters.AddWithValue("@descricao", "Produto");
            conn.Parameters.AddWithValue("@valor", valor_totaly);
            conn.Parameters.AddWithValue("@desconto", Convert.ToDouble(txtDesconto.Text));
            conn.Parameters.AddWithValue("@taxa", Convert.ToDouble(txtTaxa.Text));
            conn.Parameters.AddWithValue("@valor_total", valor_total + valor_totalz);
            conn.Parameters.AddWithValue("@cartao", Convert.ToDouble(txtCartao.Text));
            conn.Parameters.AddWithValue("@pix", Convert.ToDouble(txtPix.Text));
            conn.Parameters.AddWithValue("@dinheiro", Convert.ToDouble(txtDinheiro.Text));
            conn.Parameters.AddWithValue("@nota", lblNota.Text);
            conn.Parameters.AddWithValue("@valor_pago", cartaoDinheiroPix);
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@id_movimento", ultimoIdVenda);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Verificar_vendas()
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
                    ultimoIdVenda = Convert.ToString(reader["id"]);
                }
            }
            con.FecharConexao();
        }
        public void Relacionar_vendas()
        {
            con.AbrirConexao();
            sql = "UPDATE detalhes_lancarvendas SET id_venda = @id_venda WHERE id_venda = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id", "0");
            conn.Parameters.AddWithValue("@id_venda", ultimoIdVenda);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void BuscarPorEstoque()
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            connVerificar = new MySqlCommand("SELECT * FROM produtos WHERE id = @id", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@id", idProduto); 
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    atualizarEstoque = Convert.ToString(reader["estoque"]);
                    lblEstoque.Text = Convert.ToString(reader["estoque"]); 
                }
            }
            con.FecharConexao();
        }
    }
}
