using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Moderno
{
    public partial class FrmLogin : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        string id;
        string nomeAntigo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void chamarLogin()
        {
            if (lb_Usuario.Text.Trim() == "" || lb_Senha.Text.Trim() == "")
            {
                MessageBox.Show("Prencha o Campo", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Frm_Pdv_Moderno Frm = new Frm_Pdv_Moderno();
            Frm.ShowDialog();

            try
            {
                con.AbrirConexao();
                MySqlCommand connVerificar;
                MySqlDataReader reader;
                connVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario AND  senha = @senha", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@usuario", lb_Usuario.Text);
                connVerificar.Parameters.AddWithValue("@senha", lb_Senha.Text);
                reader = connVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Verificar.NomeUsuario = Convert.ToString(reader["usuario"]);
                        Verificar.CargoUsuario = Convert.ToString(Convert.ToString(reader["cargo"]));

                        MessageBox.Show(Verificar.NomeUsuario);
                    }

                    Frm_Pdv_Moderno Yan = new Frm_Pdv_Moderno();
                    Yan.ShowDialog();
                    this.Hide();

                }
                con.FecharConexao();

            }
            catch (Exception)
            {

               
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Realmente Deseja sair?", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Maxmizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Entar_Click(object sender, EventArgs e)
        {
            chamarLogin(); 
        }


    }
}
