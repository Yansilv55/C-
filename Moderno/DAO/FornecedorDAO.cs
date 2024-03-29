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
    public class FornecedorDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        public List<FornecedorMODEL> ListarFornecedores()
        {
            List<FornecedorMODEL> fornecedores = new List<FornecedorMODEL>();

            con.AbrirConexao();
            sql = "SELECT * FROM fornecedor ORDER BY nome ASC";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    FornecedorMODEL fornecedor = new FornecedorMODEL();
                    fornecedor.Fornecedor_id = reader.GetInt32("fornecedor_id");
                    fornecedor.Nome = reader.GetString("nome");

                    fornecedores.Add(fornecedor);
                }
            }

            con.FecharConexao();
            return fornecedores;
        }
        public void Buscar_nome(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedore WHERE nome LIKE @nome ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", fornecedor.BuscarNome + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }
        public void Buscar_cnpj(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedore WHERE cnpj = @cnpj ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cnpj", fornecedor.BuscarCnpj);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }
        public void Salvar_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "INSERT INTO fornecedore(nome, cnpj, endereco, celular, vendedor) VALUES(@nome, @cnpj, @endereco, @celular, @vendedor)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", fornecedor.Nome);
            conn.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            conn.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            conn.Parameters.AddWithValue("@celular", fornecedor.Celular);
            conn.Parameters.AddWithValue("@vendedor", fornecedor.Vendedor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Verificar_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand("SELECT * FROM fornecedore WHERE cnpj = @cnpj", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.FecharConexao();
        }
        public void Editar_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "UPDATE fornecedore SET nome = @nome, cnpj = @cnpj, endereco = @endereco, celular = @celular, vendedor = @vendedor where id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@fornecedor_id", fornecedor.Fornecedor_id);
            conn.Parameters.AddWithValue("@nome", fornecedor.Nome);
            conn.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            conn.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            conn.Parameters.AddWithValue("@celular", fornecedor.Celular);
            conn.Parameters.AddWithValue("@vendedor", fornecedor.Vendedor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Ecluir_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "DELETE FROM fornecedore WHERE fornecedor_id = @fornecedor_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@fornecedor_id", fornecedor.Fornecedor_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
