using DAO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using MODEL;

namespace Moderno.cadastross
{
    public partial class Frm_Usuario : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        string usuarioAntigo;
        string Cargo;
        private bool campoClicado = false;
        public Frm_Usuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            Listar();
            LimparCampos();
            CarregarFuncionarios();
            DesabilitarCampos();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Funcionário";
            grid.Columns[2].HeaderText = "Usuário";
            grid.Columns[3].HeaderText = "Senha";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Data";
            grid.Columns[0].Visible = false;

        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM usuarios ORDER BY nome asc";
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
            sql = "SELECT * FROM usuarios WHERE nome LIKE @nome ORDER BY nome asc"; 
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

        private void CarregarFuncionarios()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Funcionario.DataSource = dt;
            //cbCargo.ValueMember = "id";
            cb_Funcionario.DisplayMember = "nome";
            con.FecharConexao();
        }

        private void HabilitarCampos()
        {
            txt_Senha.Enabled = true;
            txt_Usuario.Enabled = true;
            cb_Funcionario.Enabled = true;
            txt_Cargo.Enabled = false;
            txt_Usuario.Focus();
        }
        private void DesabilitarCampos()
        {
            txt_Senha.Enabled = false;
            txt_Usuario.Enabled = false;
            cb_Funcionario.Enabled = false;
            txt_Cargo.Enabled = false;

        }
        private void LimparCampos()
        {
            txt_Usuario.Text = "";
            txt_Senha.Text = "";
            txt_BuscarNome.Text = "";
            txt_Cargo.Text = "Selecione";
            cb_Funcionario.Text = "Selecione";
            cb_Funcionario.Focus();
        }

        private void HabilitarNovo()
        {
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            if (cb_Funcionario.Text == "")
            {
                var res = MessageBox.Show("Não há funcionário cadastrado!!! Deseja cadastrar?", "Cadastro de Usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cadastross.Frm_Funcionario frm = new Frm_Funcionario();
                    frm.ShowDialog();
                    HabilitarCampos();
                    HabilitarNovo();
                    CarregarFuncionarios();
                    Listar();
                }
                else { this.Close(); }
            }
            if (txt_Cargo.Text == "Selecione")
            {
                var res = MessageBox.Show("Não há cargo cadastrado!!! Deseja cadastrar?", "Cadastro de Usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cadastross.Frm_Cargo frm = new Frm_Cargo();
                    frm.ShowDialog();
                    HabilitarCampos();
                    HabilitarNovo();

                    CarregarFuncionarios();
                    Listar();
                }
                else { this.Close(); }
            }


            LimparCampos();
            HabilitarCampos();
            HabilitarNovo();
            Listar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text.Trim() == "")
            {
                MessageBox.Show("Preencher campo Usuário !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Senha.Text.Trim() == "")
            {
                MessageBox.Show("Preencher campo Senha !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_Funcionario.Text == "Selecione" || cb_Funcionario.Text.Trim() == "")
            {
                MessageBox.Show("Preencher selecionar um Funcionário !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Cargo.Text.Trim() == "" || txt_Cargo.Text == "Selecione")
            {
                MessageBox.Show("Preencher selecionar um Cargo !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //botao salvar
            con.AbrirConexao();
            sql = "INSERT INTO usuarios(nome, usuario, senha, cargo, data) VALUES(@nome, @usuario, @senha, @cargo, curDate())";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", cb_Funcionario.Text);
            conn.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
            conn.Parameters.AddWithValue("@senha", txt_Senha.Text);
            conn.Parameters.AddWithValue("@cargo", txt_Cargo.Text);

            //Verificar se usuario ja existe  
            MySqlCommand cmdVerificar;
            cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            cmdVerificar.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já cadastrado", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                return;
            }

            conn.ExecuteNonQuery();
            con.FecharConexao();

            LimparCampos();
            Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (cb_Funcionario.Text == "Selecione" || cb_Funcionario.Text.Trim() == "")
            {
                MessageBox.Show("Preencher selecionar um Funcionário !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Cargo.Text.Trim() == "" || txt_Cargo.Text == "Selecione")
            {
                MessageBox.Show("Preencher selecionar um Cargo !!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Usuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Usuário", "Cadastro usuários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                return;
            }
            if (txt_Senha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo senha", "Cadastro usuários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Senha.Text = "";
                txt_Senha.Focus();
                return;
            }

            //botao editar
            con.AbrirConexao();
            sql = "UPDATE usuarios SET nome = @nome, usuario = @usuario, senha = @senha, cargo = @cargo  where id = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@id", id);
            conn.Parameters.AddWithValue("@nome", cb_Funcionario.Text);
            conn.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
            conn.Parameters.AddWithValue("@senha", txt_Senha.Text);
            conn.Parameters.AddWithValue("@cargo", txt_Cargo.Text);

            //Verificar se cpf ja existe
            if (txt_Usuario.Text != usuarioAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Usuário já registrado", "Cadastro de usuários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Usuario.Text = "";
                    txt_Usuario.Focus();
                    return;
                }
            }

            conn.ExecuteNonQuery();
            con.FecharConexao();

            LimparCampos();
            Listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                HabilitarCampos();

                id = grid.CurrentRow.Cells[0].Value.ToString();
                cb_Funcionario.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Usuario.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Senha.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txt_Cargo.Text = grid.CurrentRow.Cells[4].Value.ToString();

                usuarioAntigo = grid.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                campoClicado = false;
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                con.AbrirConexao();
                sql = "DELETE FROM usuarios WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                cb_Funcionario.Text = "";
                cb_Funcionario.Enabled = false;

                LimparCampos();
                Listar();
            }
        }

        private void cb_Funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            con.AbrirConexao();
            connVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE nome = @nome", con.con);
            connVerificar.Parameters.AddWithValue("@nome", cb_Funcionario.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cargo = Convert.ToString(reader["cargo"]);           
                }
                txt_Cargo.Text = Cargo;
            }
            con.FecharConexao();
        }

        private void cb_Funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Senha.Focus();
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_Funcionario.Focus();
            }
        }

        private void cb_Funcionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (campoClicado)
                {
                    btn_Editar.PerformClick();
                }
                else
                {
                    btn_Salvar.PerformClick();
                }
            }
        }
    }
}
