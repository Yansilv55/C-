using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAO
{
    public class ClienteDAO
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        public List<ClienteMODEL> ListarCliente()
        {
            List<ClienteMODEL> clientes = new List<ClienteMODEL>();
            con.AbrirConexao();
            sql = "SELECT * FROM cliente ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                while (reader.Read())
                {
                    ClienteMODEL cliente = new ClienteMODEL();
                    cliente.cliente_id = reader.GetInt32("cliente_id");
                    cliente.nome = reader.GetString("nome");
                    cliente.cpf = reader.GetString("cpf");
                    cliente.valorAberto = reader.GetString("valorAberto");
                    cliente.celular = reader.GetString("celular");
                    cliente.email = reader.GetString("email");
                    cliente.desbloqueado = reader.GetString("desbloqueado");
                    cliente.status = reader.GetString("inadiplente");
                    cliente.endereco = reader.GetString("endereco");
                    cliente.funcionario = UTEIS.NomeUsuario;
                    cliente.data = reader.GetString("data");

                    clientes.Add(cliente);
                }
            }
            con.FecharConexao();
            return clientes;
        }
        public void Excluir_cliente(ClienteMODEL clinte)
        {
            con.AbrirConexao();
            sql = "DELETE FROM cliente WHERE cliente_id = @cliente_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_cliente", clinte.cliente_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Salvar_registro_ativado(ClienteMODEL cliente)
        {
            con.AbrirConexao();
            sql = "INSERT INTO cliente(nome, cpf, valorAberto, celular, email, desbloqueado, Inadiplente, endereco, data) VALUES(@nome, @cpf, @valorAberto, @celular, @email, @desbloqueado, @Inadiplente, @endereco, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Parameters.AddWithValue("@cpf", cliente.cpf);
            conn.Parameters.AddWithValue("@valorAberto", 0);
            conn.Parameters.AddWithValue("@celular", cliente.celular);
            conn.Parameters.AddWithValue("@email", cliente.email);
            conn.Parameters.AddWithValue("@desbloqueado", "sim");
            conn.Parameters.AddWithValue("@Inadiplente", "Não");
            conn.Parameters.AddWithValue("@endereco", cliente.endereco);
            conn.Parameters.AddWithValue("@funcionario", UTEIS.NomeUsuario);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Salvar_registro_desativado(ClienteMODEL cliente)
        {
            con.AbrirConexao();
            sql = "INSERT INTO cliente(nome, cpf, valorAberto, celular, email, desbloqueado, Inadiplente, endereco, data) VALUES(@nome, @cpf, @valorAberto, @celular, @email, @desbloqueado, @Inadiplente, @endereco, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Parameters.AddWithValue("@cpf", cliente.cpf);
            conn.Parameters.AddWithValue("@valorAberto", 0);
            conn.Parameters.AddWithValue("@celular", cliente.celular);
            conn.Parameters.AddWithValue("@email", cliente.email);
            conn.Parameters.AddWithValue("@desbloqueado", "Não");
            conn.Parameters.AddWithValue("@Inadiplente", "Não");
            conn.Parameters.AddWithValue("@endereco", cliente.endereco);
            conn.Parameters.AddWithValue("@funcionario", UTEIS.NomeUsuario);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public bool VerificarDuplicidadeFuncionario(int cliente_id, string nomeCampo, string valorCampo)
        {
            try
            {
                con.AbrirConexao();
                string sql = $@"SELECT 
                                    COUNT(*) 
                                FROM 
                                    cliente 
                                WHERE 
                                    {nomeCampo} = @campo
                                AND 
                                    cliente_id != @cliente_id";

                MySqlCommand connVerificar = new MySqlCommand(sql, con.con);
                connVerificar.Parameters.AddWithValue("@campo", valorCampo);
                connVerificar.Parameters.AddWithValue("@cliente_id", cliente_id);

                int count = Convert.ToInt32(connVerificar.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao verificar", ex);
            }
        }
        public void Editar_cliente_ativado(ClienteMODEL cliente)
        {
            con.AbrirConexao();
            sql = "UPDATE cliente SET nome=@nome, cpf=@cpf, valorAberto=@valorAberto, celular=@celular, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario WHERE cliente_id = @cliente_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_clienete", cliente.cliente_id);
            conn.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Parameters.AddWithValue("@cpf", cliente.cpf);
            conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(cliente.valorAberto));
            conn.Parameters.AddWithValue("@celular", cliente.celular);
            conn.Parameters.AddWithValue("@email", cliente.email);
            conn.Parameters.AddWithValue("@desbloqueado", "Sim");
            conn.Parameters.AddWithValue("@Inadiplente", cliente.Inadiplente);
            conn.Parameters.AddWithValue("@endereco", cliente.endereco);
            conn.Parameters.AddWithValue("@funcionario", UTEIS.NomeUsuario);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Editar_cliente_desativado(ClienteMODEL cliente)
        {
            con.AbrirConexao();
            sql = "UPDATE cliente SET nome=@nome, cpf=@cpf, valorAberto=@valorAberto, celular=@celular, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario WHERE cliente_id = @cliente_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_clienete", cliente.cliente_id);
            conn.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Parameters.AddWithValue("@cpf", cliente.cpf);
            conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(cliente.valorAberto));
            conn.Parameters.AddWithValue("@celular", cliente.celular);
            conn.Parameters.AddWithValue("@email", cliente.email);
            conn.Parameters.AddWithValue("@desbloqueado", "Não");
            conn.Parameters.AddWithValue("@Inadiplente", cliente.Inadiplente);
            conn.Parameters.AddWithValue("@endereco", cliente.endereco);
            conn.Parameters.AddWithValue("@funcionario", UTEIS.NomeUsuario);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
