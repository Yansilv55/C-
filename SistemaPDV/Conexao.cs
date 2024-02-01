using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaHotel
{
    class Conexao
    {
        //para usar servidor local
        public string conec = "SERVER=localhost; DATABASE=vendas; UID=root; PWD=; PORT=;";
        
        public MySqlConnection con = null;
        
        public void AbrirConexao()
        {            
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                //ao inves do throw ex; usar o messageBox, assim o sistema pode ser usado mesmo dando erro ao abrir o BD
                MessageBox.Show("Erro de conexão com o Banco de Dados: " + ex.Message);
            }
        }
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
                con.Dispose(); //derruba algumas conexoes abertas
                con.ClearAllPoolsAsync(); //metodo de limpeza
            }
            catch (Exception ex)
            {
                //ao inves do throw ex; usar o messageBox, assim o sistema pode ser usado mesmo dando erro fechando o BD
                MessageBox.Show("Erro de conexão com o Banco de Dados: " + ex.Message); 
            }
        }
       
    }
}
