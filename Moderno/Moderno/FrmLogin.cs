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
        Int32 ano;
        string nomeAntigo;
        DateTime data = DateTime.Now;

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



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
        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUÁRIO")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
                lbl_textoErro.Visible = false;
                pictureErro.Visible = false;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUÁRIO";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Senha_Enter(object sender, EventArgs e)
        {
            if (txt_Senha.Text == "SENHA")
            {
                txt_Senha.Text = "";
                txt_Senha.ForeColor = Color.LightGray;
                txt_Senha.UseSystemPasswordChar = true;
                lbl_textoErro.Visible = false;
                pictureErro.Visible = false;
            }
        }

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
            if (txt_Senha.Text == "")
            {
                txt_Senha.Text = "SENHA";
                txt_Senha.ForeColor = Color.DimGray;
                txt_Senha.UseSystemPasswordChar = false;
            }
        }
        private void verificado()
        {
            txt_Usuario.Text = "USUÁRIO";
            txt_Usuario.ForeColor = Color.DimGray;
            txt_Senha.Text = "SENHA";
            txt_Senha.ForeColor = Color.DimGray;
            txt_Senha.UseSystemPasswordChar = false;
        }

        private void chamarLogin()
        {

            if (txt_Usuario.Text.ToString().Trim() == "" || txt_Usuario.Text == "USUÁRIO")
            {
                erroLogin("Usuário ou senha inválida !!!");
                verificado();
            }
            if (txt_Senha.Text.ToString().Trim() == "" || txt_Senha.Text == "SENHA")
            {
                erroLogin("Usuário ou senha inválida.");
                verificado();
            }
            else 
            { 
                erroLogin("Verifique usúario e senha."); 
            }

            try
            {
                con.AbrirConexao();
                MySqlCommand connVerificar;
                MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
                string cSQL = @"SELECT 
	                                u.nome,
                                    c.cargo
                                FROM 
	                                usuarios as u 
                                INNER join 
	                                cargos as c 
                                on 
	                                u.cargo = c.id 
                                WHERE 
	                                usuario = @usuario AND  
                                    senha = @senha";
                connVerificar = new MySqlCommand(cSQL, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
                connVerificar.Parameters.AddWithValue("@senha", txt_Senha.Text);
                reader = connVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    //extraíndo dados do login
                    while (reader.Read())
                    {
                        Program.NomeUsuario = Convert.ToString(reader["nome"]);
                        Program.CargoUsuario = Convert.ToString(Convert.ToString(reader["cargo"]));
                    }
                    lbl_textoErro.Visible = false;
                    pictureErro.Visible = false;
                    verificado();
                    //Message.Frm_Bemvindo frm = new Message.Frm_Bemvindo();
                    //frm.Show();
                    //frm.FormClosed += encerraSecao;
                    //this.Hide();//oculta form
                    Frm_Pdv_Moderno frm = new Frm_Pdv_Moderno();
                    frm.ShowDialog();

                }
                con.FecharConexao();
            }
            catch (Exception m)
            {
                MessageBox.Show("Seu banco de dados apresentou um erro, este problema pode ser causado por diversos problemas no seu computador. Para resolver este erro, entre em contato com o Administrador deste sitema: " + m);
            }

        }
        private void erroLogin(string msn)
        {
            lbl_textoErro.Text = msn;
            lbl_textoErro.Visible = true;
            pictureErro.Visible = true;

        }
        private void encerraSecao(object sender, FormClosedEventArgs e)
        {
            verificado();
            lbl_textoErro.Visible = false;
            pictureErro.Visible = false;
            this.Show();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chamarLogin();
            }
        }


    }
}
