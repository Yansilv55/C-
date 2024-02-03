using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Moderno.cadastross
{
    public partial class Frm_Clinte : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        string cpfAntigo;
        string foto;
        string alterouImagem = "nao";
        string radButton = "";
        String desbloqueado, inadiplente;
        bool emailAdress = false;

        int codCliente, IdAnterior;
        public Frm_Clinte()
        {
            InitializeComponent();
        }

        private void Frm_Clinte_Load(object sender, EventArgs e)
        {

        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Código";
            grid.Columns[2].HeaderText = "Nome";
            grid.Columns[3].HeaderText = "Cpf";
            grid.Columns[4].HeaderText = "Em Aberto";
            grid.Columns[5].HeaderText = "Telefone";
            grid.Columns[6].HeaderText = "Email";
            grid.Columns[7].HeaderText = "Desbloqueado";
            grid.Columns[8].HeaderText = "Status";
            grid.Columns[9].HeaderText = "Endereço";
            grid.Columns[10].HeaderText = "Fucionário";
            grid.Columns[11].HeaderText = "igm";
            grid.Columns[12].HeaderText = "Data";
            //grid.Columns[0].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[11].Visible = false;
            grid.Columns[4].DefaultCellStyle.Format = "c2";
        }

        private void Listar()
        {

            con.AbrirConexao();
            sql = "SELECT * FROM clientes ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

            FormatarGD();
        }

        private void BuscarNome()
        {

            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE nome LEKE @nome ORDER BY nome asc"; //LIKE, buseca nome per aproximacao
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", lb_Bucar_Nome.Text + "%"); //"%" eperader LIKE, busca neme per aproximacao
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

            con.FecharConexao();
            FormatarGD();
        }

        private void BuscarCpf()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE cpf=@cpf ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cpf", lb_Buscar_Cpf.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

            con.FecharConexao();
            FormatarGD();
        }

        private void HabilitarCampos()
        {
            lb_Nome.Enabled = true;
            lb_Cpf.Enabled = true;
            lb_Endereco.Enabled = true;
            lb_Telefone.Enabled = true;
            lb_Email.Enabled = true;
            cb_Inadiplete.Enabled = true;
            lb_Valor_Aberto.Enabled = true;
            lb_Nome.Focus();
        }

        private void DesabilitarCampos()
        {
            lb_Nome.Enabled = false;
            lb_Cpf.Enabled = false;
            lb_Endereco.Enabled = false;
            lb_Telefone.Enabled = false;
            lb_Email.Enabled = false;
            cb_Inadiplete.Enabled = false;
            lb_Valor_Aberto.Enabled = false;
        }

        private void LimparCampos()
        {
            lb_Nome.Text = "";
            lb_Cpf.Text = "";
            lb_Endereco.Text = "";
            lb_Telefone.Text = "";
            lb_Email.Text = "";
            cb_Inadiplete.SelectedIndex = 0;
        }

        private void Status()
        {
            radButton = grupo_Box.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked)?.Text;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            LimparFotos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = true;
        }

        private void verificarEmail()
        {
            string email = lb_Email.Text;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (rg.IsMatch(email))
            {
                emailAdress = true;
                btn_Salvar.Enabled = true;
                img_Email.Image = Properties.Resources.icons8_ok_24px;
            }
            else
            {
                emailAdress = false;
                btn_Salvar.Enabled = false;
                img_Email.Image = Properties.Resources.icons8_multiply_26px;
            }
        }
        private void ultimoIdCliente()
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            sql = "SELECT id FROM clientes ORDER BY id DESC LIMIT 1";
            connVerificar = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdAnterior = Convert.ToInt32(reader["id"]);
                    codCliente = IdAnterior + 1;
                }
            }
        }
        private byte[] img()
        {
            byte[] image_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image_byte = br.ReadBytes((int)fs.Length);
            return image_byte;
        }

        private void LimparFotos()
        {
            image.Image = Properties.Resources.icons8_person_32px;
            foto = "img/icons8_person_32px.png";
        }
    }
}
