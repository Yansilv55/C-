using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno.cadastross
{
    public partial class Frm_Servicos : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        public Frm_Servicos()
        {
            InitializeComponent();
        }

        private void Frm_Servicos_Load(object sender, EventArgs e)
        {
            Listar();
            if (cb_Tipo.Items.Count > 0)
            {
                cb_Tipo.SelectedIndex = 0;
            }
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Serviço";
            grid.Columns[2].HeaderText = "Valor";
            grid.Columns[3].HeaderText = "Ativado";
            grid.Columns[2].DefaultCellStyle.Format = "C2";
            //grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM servicos ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
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
            txt_Nome.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Nome.Focus();
        }
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Valor.Enabled = false;
            cb_Ativo.Enabled = false;
        }
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Valor.Text = "";
            if (cb_Tipo.Items.Count > 0)
            {
                cb_Tipo.SelectedIndex = 0;
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            btn_Salvar.Enabled = true;
            cb_Ativo.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            HabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher campo nome do serviço !!", "Cadastro de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher campo valor !!", "Cadastro de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //botao salvar
            con.AbrirConexao();
            sql = "INSERT INTO servicos(nome, valor, ativo) VALUES(@nome, @valor, @ativo)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
            conn.Parameters.AddWithValue("@valor", txt_Valor.Text.Replace(",", "."));
            if (cb_Ativo.Checked == true)
            {
                conn.Parameters.AddWithValue("@ativo", "Sim");
            }
            if (cb_Ativo.Checked == false)
            {
                conn.Parameters.AddWithValue("@ativo", "Não");
            }
            conn.ExecuteNonQuery();
            con.FecharConexao();
            btn_Novo.Enabled = true;
            cb_Ativo.Enabled = false;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome do serviço", "Cadastro serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo valor do serviço", "Cadastro serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }

            //botao editar
            con.AbrirConexao();
            sql = "UPDATE servicos SET nome = @nome, valor = @valor, ativo = @ativo WHERE id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id", id);
            conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
            conn.Parameters.AddWithValue("@valor", txt_Valor.Text.Replace(",", "."));
            if (cb_Ativo.Checked == true)
            {
                conn.Parameters.AddWithValue("@ativo", "Sim");
            }
            if (cb_Ativo.Checked == false)
            {
                conn.Parameters.AddWithValue("@ativo", "Não");
            }
            conn.ExecuteNonQuery();
            con.FecharConexao();

            btn_Novo.Enabled = true;
            cb_Ativo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Editado com sucesso!", "Cadastro serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                cb_Ativo.Enabled = true;
                btn_Salvar.Enabled = false;
                HabilitarCampos();

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Valor.Text = grid.CurrentRow.Cells[2].Value.ToString();
                if (grid.CurrentRow.Cells[3].Value.ToString() == "Sim")
                {
                    cb_Ativo.Checked = true;
                }
                else
                {
                    cb_Ativo.Checked = false;
                }
            }
            else
            {
                return;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                con.AbrirConexao();
                sql = "DELETE FROM servicos WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                txt_Nome.Text = "";
                txt_Valor.Text = "";
                LimparCampos();
                DesabilitarCampos();
                Listar();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(2, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;

                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
            }
        }

        private void formatarTextNumero(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -2)
                {
                    e.Handled = true;
                }


                if (e.KeyChar == ','
                    && (sender as TextBox).Text.IndexOf(',') > -2)
                {
                    e.Handled = true;
                }

                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }
        private void Buscartipo()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM servicos WHERE ativo = @ativo ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@ativo", cb_Tipo.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();

        }
        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Valor);
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void cb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Tipo.SelectedIndex == 0)
            {
                Listar();
            }
            else
            {
                Buscartipo();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;

            DesabilitarCampos();
            LimparCampos();
        }
    }
}
