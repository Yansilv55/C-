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
using DAO;
using MODEL;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moderno.cadastross
{
    public partial class Frm_Funcionario : Form

    {
        private string funcionario_id;
        private string cpfAntigo;
        private string celAntigo;
        private bool campoClicado = false;
        private object dt;

        public Frm_Funcionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Frm_Funcionario_Load(object sender, EventArgs e)
        {
            FuncionarioMODEL model = new FuncionarioMODEL();
            Listar();
            ListarCargos(model);
            cb_Cargo.Text = "Selecione o Cargo";
            txt_Celular.Text = "(00) 0 0000-0000";
        }
        //------------------------------------------------------------------------------
        private void BuscarNome(FuncionarioMODEL Funcionario, DataGridView grid)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            funcionario.Buscar_nome(Funcionario, grid);
            FormatarGD();
        }
        //------------------------------------------------------------------------------
        private void BuscarCpf(FuncionarioMODEL Funcionario, DataGridView grid)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            funcionario.Buscar_cpf(Funcionario, grid);
            FormatarGD();
        }

        private void VerificarCampo()
        {
            string cpf = txt_Cpf.Text;
            string numeroCpf = new string(cpf.Where(char.IsDigit).ToArray());
            string celular = txt_Celular.Text;
            string numerocel = new string(celular.Where(char.IsDigit).ToArray());

            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (!CPFValidator.ValidateCPF(numeroCpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
            if (numerocel.Length != 11)
            {
                MessageBox.Show("preencha o Campo Telefone.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Celular.Focus();
                return;
            }
            if (cb_Cargo.Text == "Selcionar cargo")
            {
                MessageBox.Show("Por favor preencha o Campo.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Cargo.Focus();
                return;
            }
            if (txt_Endereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Endereço.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Endereco.Text = "";
                txt_Endereco.Focus();
                return;
            }
        }

        private void SalvarRegistrro()
        {
            VerificarCampo();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            FuncionarioMODEL funcionario = new FuncionarioMODEL();
            funcionario.nome = txt_Nome.Text;
            funcionario.cpf = txt_Cpf.Text;
            funcionario.celular = txt_Celular.Text;
            funcionario.cargo = cb_Cargo.Text;
            funcionario.endereco = txt_Endereco.Text;

            if (VerificarDuplicidade())
            {
                return;
            }
            

            try
            {
                funcionarioDAO.Salvar_funcionario(funcionario);

                MessageBox.Show("Registro Salvo com sucesso!.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                LimparCampos();
                Listar();
                funcionarioDAO.AtualizarLinhas();

                DesabilitarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarRegistrro();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void CelularJaCadastrado(FuncionarioMODEL Funcionario)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            funcionario.VerificarDuplicidadeCelular(Funcionario);
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Tel. :";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";

            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            LimparCampos();
            txt_Nome.Focus();
        }

        private void Listar()
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            grid.DataSource = funcionario.ListarFuncionario();
            FormatarGD();
        }
        private void habilitarCampos()
        {
            btn_Salvar.Enabled = true;
            txt_Nome.Enabled = true;
            txt_Cpf.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Celular.Enabled = true;
            cb_Cargo.Enabled = true;
            btn_Novo.Enabled = false;
        }

        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Cpf.Text = "";
            txt_Endereco.Text = "";
            txt_Celular.Text = "";
            cb_Cargo.Text = "";
        }
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Cpf.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Celular.Enabled = false;
            cb_Cargo.Enabled = false;
        }
        private void Carregar_Campo(FuncionarioMODEL Funcionario)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
           //funcionario.Carregar_campo(Funcionario);

        }
        private bool VerificarDuplicidade()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            FuncionarioMODEL funcionario = new FuncionarioMODEL();
            funcionario.cpf = txt_Cpf.Text;
            funcionario.celular = txt_Celular.Text;
            if (txt_Cpf.Text != cpfAntigo)
            {
                if (funcionarioDAO.VerificarDuplicidadeFuncionario(funcionario.funcionario_id, "cpf", funcionario.cpf.ToString()))
                {
                    MessageBox.Show("CPF já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Cpf.Text = "";
                    txt_Cpf.Focus();
                    return true;
                }
            }
            if (txt_Celular.Text != celAntigo)
            {
                if (funcionarioDAO.VerificarDuplicidadeFuncionario(funcionario.funcionario_id, "telefone", funcionario.celular.ToString()))
                {
                    MessageBox.Show("Celular já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Celular.Text = "";
                    txt_Celular.Focus();
                    return true;
                }
            }
            return false;
        }
        private void EditarRegistro()
        {
            VerificarCampo();

            FuncionarioMODEL funcionario = new FuncionarioMODEL();
            funcionario.nome = txt_Nome.Text;
            funcionario.cpf = txt_Cpf.Text;
            funcionario.celular = txt_Celular.Text;
            funcionario.cargo = cb_Cargo.Text;
            funcionario.endereco = txt_Endereco.Text;
            funcionario.funcionario_id = int.Parse(funcionario_id);
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            if (VerificarDuplicidade())
            {
                return;
            }
            
            try
            {
                funcionarioDAO.Editar_funcionario(funcionario);

                Listar();

                MessageBox.Show("Registro Editado com sucesso!", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarRegistro();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {Ex.Message}", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
        private void ExcluirRegistro()
        {
            FuncionarioMODEL funcionario = new FuncionarioMODEL();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "Cadastro Funciónario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                funcionario.funcionario_id = int.Parse(funcionario_id);
                funcionarioDAO.Excluir_Registro(funcionario);
                MessageBox.Show("Registro Excluído com sucesso!.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                funcionarioDAO.AtualizarLinhas();
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
            }
        }
 
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                ExcluirRegistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ListarCargos(FuncionarioMODEL funcionario)
        {
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            cb_Cargo.DataSource = funcionariodao.Carregar_campo();
            cb_Cargo.DisplayMember = "cargo";
        }
        private void grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                habilitarCampos();
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = false;
                txt_Nome.Focus();


                if (grid.CurrentRow.Cells[0].Value != null)
                {
                    funcionario_id = grid.CurrentRow.Cells[0].Value.ToString();
                }
                if (grid.CurrentRow.Cells[1].Value != null)
                {
                    txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                }
                if (grid.CurrentRow.Cells[2].Value != null)
                {
                    txt_Cpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                    cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                }
                if (grid.CurrentRow.Cells[3].Value != null)
                {
                    txt_Celular.Text = grid.CurrentRow.Cells[3].Value.ToString();
                }
                if (grid.CurrentRow.Cells[4].Value != null)
                {
                    cb_Cargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                }
                if (grid.CurrentRow.Cells[5].Value != null)
                {
                    txt_Endereco.Text = grid.CurrentRow.Cells[5].Value.ToString();
                }
            }
            else
            {
                campoClicado = false;
            }
        }
        private void cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  cb_Cargo.DropDownStyle = ComboBoxStyle.DropDownList;
            FuncionarioDAO funcionariodao = new FuncionarioDAO();
            cb_Cargo.DataSource = funcionariodao.Carregar_campo();
            cb_Cargo.DisplayMember = "cargo";*/
        }
        public class CPFValidator
        {
            public static bool ValidateCPF(string cpf)
            {
                cpf = cpf.Trim().Replace(".", "").Replace("-", "");

                if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                    return false;

                // Obtém os dígitos verificadores
                string digitosVerificadores = cpf.Substring(9, 2);

                // Calcula o primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (10 - i);
                }
                int resto = soma % 11;
                int primeiroDigito = resto < 2 ? 0 : 11 - resto;

                // Verifica se o primeiro dígito verificador está correto
                if (primeiroDigito != int.Parse(digitosVerificadores[0].ToString()))
                    return false;

                // Calcula o segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (11 - i);
                }
                resto = soma % 11;
                int segundoDigito = resto < 2 ? 0 : 11 - resto;

                // Verifica se o segundo dígito verificador está correto
                if (segundoDigito != int.Parse(digitosVerificadores[1].ToString()))
                    return false;

                return true;
            }
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = true;
            txt_BuscarCpf.Visible = false;
            txt_BuscarCpf.Text = "";
            txt_BuscarNome.Text = "";
        }
        private void rb_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
            txt_BuscarCpf.Visible = true;
            txt_BuscarCpf.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarNome.Focus();
        }
        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Cargo frm = new Frm_Cargo();
            FuncionarioMODEL model = new FuncionarioMODEL();
            this.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Carregar_Campo(model);
        }
        private void lb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Cpf.Focus();
            }
        }
        private void lb_Cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Celular.Focus();
            }
        }
        private void lb_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Endereco.Focus();
            }
        }
        private void lb_Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_Cargo.Focus();
            }
        }
        private void cb_Cargo_KeyDown(object sender, KeyEventArgs e)
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
