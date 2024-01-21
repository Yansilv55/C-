using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Conexao
    {   
        public string connectionString = "Server=localhost;Database=pdv;User ID=root;Password=;PORT=;";

        public void Conectar()
        {

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                // Execute suas operações no banco de dados aqui
                Console.WriteLine("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na conexão: {ex.Message}");
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }

        }

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            con = new MySqlConnection(connectionString);
            con.Open(); 
        }
         
        public void FecharConexao()
        { 

            con = new MySqlConnection(connectionString);
            con.Close(); 
            con.Dispose();
            con.ClearAllPoolsAsync(); //metodo de limpeza
         } 
    }
}
