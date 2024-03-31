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
        string cargo_id;
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
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            grid.DataSource = usuarioDAO.ListarServicos();

            FormatarGD();
        }
        private void BuscarNome(UsuarioMODEL usuarioMODEL)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Buscar_nome(usuarioMODEL);
            FormatarGD();
        }

        private void CarregarFuncionarios()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Carregar_funcionario();
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
        private void SalvarRegistro(UsuarioMODEL usuarioMODEL)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Salvar_usuario(usuarioMODEL);
        }
        private void VerificarCampo()
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
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            
            VerificarCampo();
            //botao salvar
            UsuarioMODEL usuarioMODEL = new UsuarioMODEL();
            SalvarRegistro(usuarioMODEL);
            usuarioMODEL.Nome = cb_Funcionario.Text;
            usuarioMODEL.Usuario = txt_Usuario.Text;
            usuarioMODEL.Senha = int.Parse(txt_Senha.Text);
            usuarioMODEL.Cargo = txt_Cargo.Text;
            //Verificar se usuario ja existe  
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Verificar_usuario(usuarioMODEL);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já cadastrado", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                return;
            }
            LimparCampos();
            Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
        }
        private void EditarRegistro(UsuarioMODEL usuarioMODEL)
        {
            UsuarioDAO usuarioDAO= new UsuarioDAO();
            usuarioDAO.Editar_usuario(usuarioMODEL);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            VerificarCampo();

            //botao editar
            UsuarioMODEL usuarioMODEL = new UsuarioMODEL();
            EditarRegistro(usuarioMODEL);
            usuarioMODEL.cargo_id = cargo_id;
            usuarioMODEL.Nome = cb_Funcionario.Text;
            usuarioMODEL.Usuario = txt_Usuario.Text;
            usuarioMODEL.Senha = int.Parse(txt_Senha.Text);
            usuarioMODEL.Cargo = txt_Cargo.Text;
            //Verificar se cpf ja existe
            if (txt_Usuario.Text != usuarioAntigo)
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.Verificar_usuario(usuarioMODEL);

            }
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
            UsuarioMODEL usuarioMODEL = new UsuarioMODEL();
            BuscarNome(usuarioMODEL);
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

                cargo_id = grid.CurrentRow.Cells[0].Value.ToString();
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
        private void ExcluirRegistro(UsuarioMODEL usuarioMODEL)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Excluir_usuario(usuarioMODEL);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                UsuarioMODEL usuarioMODEL = new UsuarioMODEL();
                ExcluirRegistro(usuarioMODEL);
                usuarioMODEL.cargo_id = cargo_id;
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
        private void BuscarCargo(UsuarioMODEL usuarioMODEL)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Buscar_cargo(usuarioMODEL);
        }

        private void cb_Funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuarioMODEL usuarioMODEL = new UsuarioMODEL();
            BuscarNome(usuarioMODEL);
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
