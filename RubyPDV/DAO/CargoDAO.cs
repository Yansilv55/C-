using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class CargoDAO
    {
        private string sql;
        Conexao con = new Conexao();
        MySqlCommand conn;
        string id_cargo;

        public List<ServicoMODAL> ListarServicos()
        {
            List<ServicoMODAL> servicos = new List<ServicoMODAL>();

            con.AbrirConexao();
            sql = "SELECT * FROM servico ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ServicoMODAL servico = new ServicoMODAL();
                    servico.servico_id = reader.GetInt32("servico_id");
                    servico.nome = reader.GetString("nome");
                    servico.valor = reader.GetDecimal("valor");

                    servicos.Add(servico);
                }
            }

            con.FecharConexao();
            return servicos;
        }
        public bool buscar_Registro_Cargo(string nome)
        {
            con.AbrirConexao();
            sql = "SELECT COUNT(*) FROM cargos WHERE cargo = @cargo";
            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand(sql, con.con);
            connVerificar.Parameters.AddWithValue("@cargo", nome);

            int count = Convert.ToInt32(connVerificar.ExecuteScalar());

            if (count > 0)
            {
                con.FecharConexao();
                return true;
            }
            else
            {
                return false;
            }
        }
        public MySqlDataAdapter Listar_Grid()
        {
            try
            {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            con.FecharConexao();
            return da;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante o select no cargo", ex);
            }
        }

        public void Excluir_Cargo()
        {
            try
            {
            con.AbrirConexao();
            sql = "DELETE FROM cargos WHERE id_cargo = @id_cargo";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_cargo", id_cargo);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante a exclusão do cargo", ex);
            }
        }

        public void Editar_Cargo(string nome)
        {
            try
            {
            con.AbrirConexao();
            sql = "UPDATE cargos SET cargo = @cargo WHERE id_cargo = @id_cargo";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_cargo", id_cargo);
            conn.Parameters.AddWithValue("@cargo", nome);
            conn.ExecuteNonQuery();
            con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante edição do cargo", ex);
            }
        }

        public void Inserir_Nome_Cargo(string nome)
        {
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO cargos (cargo, data) VALUES (@cargo, curDate())";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@cargo", nome);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante a inserção do cargo", ex);
            }
        }

        
    }
}
