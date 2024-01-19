using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class Frm_funcionario : Form
    {
        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand banco;
        public Frm_funcionario()
        {
            InitializeComponent();
        }

        private void text_Telefone_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "SELECT * FROM `funcionarios`";
            banco = new MySqlCommand(sql, con.con);

            using (MySqlDataReader reader = banco.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    string linha = reader.Read().ToString();

                }
            }
        }
    }
}
