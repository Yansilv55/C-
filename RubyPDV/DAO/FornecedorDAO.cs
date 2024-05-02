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
                    fornecedor.fornecedor_id = reader.GetInt32("fornecedor_id");
                    fornecedor.nome = reader.GetString("nome");
                    fornecedor.cnpj = reader.GetString("cnpj");
                    fornecedor.endereco = reader.GetString("endereco");
                    fornecedor.celular = reader.GetString("celular");
                    fornecedor.vendedor = reader.GetString("vendedor");
                    //fornecedor.data = reader.GetString("data");

                    fornecedores.Add(fornecedor);
                }
            }

            con.FecharConexao();
            return fornecedores;
        }
        public void Salvar_fornecedor(FornecedorMODEL fornecedor)
        {
            try
            {
            con.AbrirConexao();
            sql = @"INSERT INTO fornecedor(
                                        nome,
                                        cnpj,
                                        endereco,
                                        celular,
                                        vendedor) 
                                VALUES(
                                        @nome,
                                        @cnpj,
                                        @endereco,
                                        @celular,
                                        @vendedor)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", fornecedor.nome);
            conn.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            conn.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            conn.Parameters.AddWithValue("@celular", fornecedor.celular);
            conn.Parameters.AddWithValue("@vendedor", fornecedor.vendedor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Verificar_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand("SELECT * FROM fornecedor WHERE cnpj = @cnpj", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.FecharConexao();
        }
        public void Editar_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "UPDATE fornecedor SET nome = @nome, cnpj = @cnpj, endereco = @endereco, celular = @celular, vendedor = @vendedor where fornecedor_id = @fornecedor_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@fornecedor_id", fornecedor.fornecedor_id);
            conn.Parameters.AddWithValue("@nome", fornecedor.nome);
            conn.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            conn.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            conn.Parameters.AddWithValue("@celular", fornecedor.celular);
            conn.Parameters.AddWithValue("@vendedor", fornecedor.vendedor);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Ecluir_fornecedor(FornecedorMODEL fornecedor)
        {
            con.AbrirConexao();
            sql = "DELETE FROM fornecedor WHERE fornecedor_id = @fornecedor_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@fornecedor_id", fornecedor.fornecedor_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
