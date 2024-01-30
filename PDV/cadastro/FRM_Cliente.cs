﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class Frm_Cliente : Form
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
        bool emailAddress = false;
        int codCliente, IdAnterior;
        float grupoBox;

        private void lb_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        public Frm_Cliente()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FRM_Cliente_Load(object sender, EventArgs e)
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
            radButton = grupoBox.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton =>  RadioButton.Checked).Text;
        }

        private void verificarEmail()
        {
            string email = lb_Email.Text;

            Regex rg = new Regex(@"");

            if (rg.IsMatch(email))
            {
                emailAddress = true;
                btn_Salvar.Enabled = true;
                imgEmail.Image = Properties.Resources.Ok;
            }
            else
            {
                emailAddress = false;
                btn_Salvar.Enabled = false;
                imgEmail.Image = Properties.Resources.oculpado;
            }
        }

        private void ultimoIdCliente()
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlCommand reader;
            sql = "SELECT id FROM clientes ORDER BY id DESC LIMIT 1";
            connVerificar = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows())
            {
                while (reader.Reade())
                {
                    IdAnterior = Convert.ToInt32(reader["id"]);
                    codCliente = IdAnterior + 1;
                }
            }
        }
    }
}
