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

        public void Excluir_cliente(ClienteMODEL clinte)
        {
            con.AbrirConexao();
            sql = "DELETE FROM clientes WHERE cliente_id = @cliente_id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id_cliente", clinte.cliente_id);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
        public void Salvar_registro_ativado(ClienteMODEL cliente)
        {
            con.AbrirConexao();
            sql = "INSERT INTO clientes(nome, cpf, valorAberto, tel, email, desbloqueado, Inadiplente, endereco, data) VALUES(@nome, @cpf, @valorAberto, @tel, @email, @desbloqueado, @Inadiplente, @endereco, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Parameters.AddWithValue("@cpf", cliente.cpf);
            conn.Parameters.AddWithValue("@valorAberto", 0);
            conn.Parameters.AddWithValue("@tel", cliente.celular);
            conn.Parameters.AddWithValue("@email", cliente.email);
            conn.Parameters.AddWithValue("@desbloqueado", "Não");
            conn.Parameters.AddWithValue("@Inadiplente", "Não");
            conn.Parameters.AddWithValue("@endereco", cliente.endereco);
            conn.Parameters.AddWithValue("@funcionario", UTEIS.NomeUsuario);
            conn.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
