using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Moderno.cadastross
{
    public partial class Frm_Fornecedores : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        string cnpjAntigo;
        bool cnpj = false;
        public Frm_Fornecedores()
        {
            InitializeComponent();
        }

        private void Frm_Fornecedores_Load(object sender, EventArgs e)
        {
            rb_Nome.Checked = true;
            Listar();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CNPJ";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "Email";
            grid.Columns[5].HeaderText = "celular";
            grid.Columns[6].HeaderText = "Código";
            grid.Columns[7].HeaderText = "Vendedor";
            grid.Columns[8].HeaderText = "Valor Aberto";


            grid.Columns[0].Visible = false;

        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }
        private void BuscarNome()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores WHERE nome LIKE @nome ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", txt_BuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }
        private void BuscarCnpj()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores WHERE cnpj = @cnpj ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cnpj", txt_BuscarCnpj.Text);
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
            txt_Cnpj.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Celular.Enabled = true;
            txt_Vendedor.Enabled = true;
            txt_Nome.Focus();
        }
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Cnpj.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Celular.Enabled = false;
            txt_Vendedor.Enabled = false;

        }
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Cnpj.Text = "";
            txt_Endereco.Text = "";
            txt_Celular.Text = "";
            txt_Vendedor.Text = "";
            txt_Email.Text = "";
            txt_ValorAberto.Text = "";
            txt_Codigo.Text = "";
        }

        private void rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = true;
            txt_BuscarCnpj.Visible = false;
            txt_BuscarCpf.Visible = false;
            txt_BuscarCnpj.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarNome.Focus();
        }

        private void rb_Cnpj_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
            txt_BuscarCpf.Visible = false;
            txt_BuscarCnpj.Visible = true;
            txt_BuscarCnpj.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarCnpj.Focus();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            cnpj = true;
            HabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            Listar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Cnpj.Text == "  .   .   /    -" || txt_Cnpj.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo CNPJ", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cnpj.Focus();
                return;
            }
            con.AbrirConexao();
            sql = "INSERT INTO fornecedores(nome, cnpj, endereco, email, celular, codigo, vendedor, valor) VALUES(@nome, @cnpj, @endereco, @email, @celular, @codigo, @vendedor, @valor)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
            conn.Parameters.AddWithValue("@cnpj", txt_Cnpj.Text);
            conn.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
            conn.Parameters.AddWithValue("@email", txt_Email.Text);
            conn.Parameters.AddWithValue("@celular", txt_Celular.Text);
            conn.Parameters.AddWithValue("@codigo", txt_Codigo.Text);
            conn.Parameters.AddWithValue("@vendedor", txt_Vendedor.Text);
            conn.Parameters.AddWithValue("@valor", txt_ValorAberto.Text);
            Verificar();

            conn.ExecuteNonQuery();
            con.FecharConexao();

            Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            cnpj = false;
        }
        private void Verificar()
        {
            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand("SELECT * FROM fornecedores WHERE cnpj = @cnpj", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@cnpj", txt_Cnpj.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("CPF já registrado", "Cadastro de fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_Cnpj.Text = "";
                txt_Cnpj.Focus();
                return;
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Cancelar.Enabled = true;
                btn_Salvar.Enabled = false;
                HabilitarCampos();

                cnpjAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Cnpj.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Endereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txt_Email.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Celular.Text = grid.CurrentRow.Cells[5].Value.ToString();
                txt_Codigo.Text = grid.CurrentRow.Cells[6].Value.ToString();
                txt_Vendedor.Text = grid.CurrentRow.Cells[7].Value.ToString();
                txt_ValorAberto.Text = grid.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            /*if (txt_Cnpj.Text == "  .   .   /    -" || txt_Cnpj.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo CNPJ", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cnpj.Focus();
                return;
            }*/
            con.AbrirConexao();
            sql = "UPDATE fornecedores SET nome = @nome, cnpj = @cnpj, endereco = @endereco, email = @email, celular = @celular, codigo = @codigo, vendedor = @vendedor, valor = @valor  where id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id", id);
            conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
            conn.Parameters.AddWithValue("@cnpj", txt_Cnpj.Text);
            conn.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
            conn.Parameters.AddWithValue("@email", txt_Email.Text);
            conn.Parameters.AddWithValue("@celular", txt_Celular.Text);
            conn.Parameters.AddWithValue("@codigo", txt_Codigo.Text);
            conn.Parameters.AddWithValue("@vendedor", txt_Vendedor.Text);
            conn.Parameters.AddWithValue("@valor", txt_ValorAberto.Text);
            /*try
            {*/

            if (txt_Cnpj.Text != cnpjAntigo)
            {
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand("SELECT * FROM fornecedores WHERE cnpj = @cnpj", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@cnpj", txt_Cnpj.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado", "Cadastro de fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Cnpj.Text = "";
                    txt_Cnpj.Focus();
                    return;
                }

            }

            conn.ExecuteNonQuery();
            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
          /*  }
            catch (Exception)
            {
                MessageBox.Show("Error", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM fornecedores WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                Listar();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
        private void txt_BuscarCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txt_BuscarCnpj.Text == "  .   .   /    -")
            {
                Listar();
            }
            else { BuscarCnpj(); }
        }
        private void txt_Cnpj_Leave(object sender, EventArgs e)
        {
            if (cnpj == true)
            {
                Verificar();
            }
        }
        private void rb_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
            txt_BuscarCnpj.Visible = false;
            txt_BuscarCpf.Visible = true;
            txt_BuscarCnpj.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarCpf.Focus();
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

        private void Frm_Fornecedores_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                }

        }
    }
}
