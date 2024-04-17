using System;
using System.Data;
using System.Windows.Forms;
using DAO;
using MODEL;
using MySql.Data.MySqlClient;


namespace Moderno.cadastross
{
    public partial class Frm_Fornecedores : Form
    {
        private string fornecedor_id;
        private string cnpjAntigo;
        private bool cnpj = false;
        private bool campoClicado = false;
        public Frm_Fornecedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Fornecedores_Load(object sender, EventArgs e)
        {
            Listar();
            DesabilitarCampos();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CNPJ";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "celular";
            grid.Columns[5].HeaderText = "Vendedor";
            //grid.Columns[6].HeaderText = "Data";

            grid.Columns[0].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;

        }
        private void Listar()
        {
            FornecedorDAO FornecedorDAO = new FornecedorDAO();
            grid.DataSource = FornecedorDAO.ListarFornecedores();
            FormatarGD();
        }
        private void BuscarNome(FornecedorMODEL fornecedor)
        {
           FornecedorDAO fornecedorDAO = new FornecedorDAO();
           fornecedorDAO.Buscar_nome();
           grid.DataSource = fornecedorDAO.Buscar_nome();
           FormatarGD();
        }
        private void BuscarCnpj(FornecedorMODEL fornecedor)
        {
            FornecedorDAO fornecedordao = new FornecedorDAO();
            fornecedordao.Buscar_cnpj();
            grid.DataSource = fornecedordao.Buscar_cnpj();
            fornecedor.buscarCnpj = int.Parse(txt_BuscarCnpj.Text);
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
        }

        private void rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = true;
            txt_BuscarCnpj.Visible = false;
            txt_BuscarCnpj.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarNome.Focus();
        }

        private void rb_Cnpj_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
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
        private bool VerificarCampo()
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return false;
            }
            if (txt_Cnpj.Text == "  .   .   /    -" || txt_Cnpj.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo CNPJ", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cnpj.Focus();
                return false;
            }
            return true;
        }
        private void SalvarRegistro(FornecedorMODEL fornecedor)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.Salvar_fornecedor(fornecedor);
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampo())
            {
                return;
            }         
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            fornecedorMODEL.nome = txt_Nome.Text;
            fornecedorMODEL.cnpj = txt_Cnpj.Text;
            fornecedorMODEL.endereco = txt_Endereco.Text;
            fornecedorMODEL.celular = txt_Celular.Text;
            fornecedorMODEL.vendedor = txt_Vendedor.Text;
            Verificar(fornecedorMODEL);
            SalvarRegistro(fornecedorMODEL);
            Listar();
            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            cnpj = false;
        }
        private void Verificar(FornecedorMODEL fornecedor)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.Verificar_fornecedor(fornecedor);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Cancelar.Enabled = true;
                btn_Salvar.Enabled = false;
                HabilitarCampos();

                cnpjAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                fornecedor_id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Cnpj.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Endereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txt_Celular.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Vendedor.Text = grid.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                campoClicado = false;
            }
        }
        private void EditarRegistro(FornecedorMODEL fornecedor)
        {
            if (!VerificarCampo())
            {
                return;
            }
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            fornecedorMODEL.fornecedor_id = int.Parse(fornecedor_id);
            fornecedorMODEL.nome = txt_Nome.Text;
            fornecedorMODEL.cnpj = txt_Cnpj.Text;
            fornecedorMODEL.endereco = txt_Endereco.Text;
            fornecedorMODEL.celular = txt_Celular.Text;
            fornecedorMODEL.vendedor = txt_Vendedor.Text;
            if (txt_Cnpj.Text != cnpjAntigo)
            {
                Verificar(fornecedorMODEL);
               

            }
            fornecedorDAO.Editar_fornecedor(fornecedor);
            Listar();
            MessageBox.Show("Registro Editado com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            EditarRegistro(fornecedorMODEL);
        }
        private void ExcluirRegistro(FornecedorMODEL fornecedor)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                    fornecedorMODEL.fornecedor_id = int.Parse(fornecedor_id);
                    fornecedorDAO.Ecluir_fornecedor(fornecedor);  
                    btn_Novo.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Excluir.Enabled = false;
                    DesabilitarCampos();
                
                    LimparCampos();
                    Listar();
                    MessageBox.Show("Registro Excluído com sucesso!", "Cadastro fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            ExcluirRegistro(fornecedorMODEL);
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            BuscarNome(fornecedorMODEL);
        }
        private void txt_BuscarCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            if (txt_BuscarCnpj.Text == "  .   .   /    -")
            {
                Listar();
            }
            else { BuscarCnpj(fornecedorMODEL); }
        }
        private void txt_Cnpj_Leave(object sender, EventArgs e)
        {
            FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
            if (cnpj == true)
            {
                Verificar(fornecedorMODEL);
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

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Cnpj.Focus();
            }
        }

        private void txt_Cnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Vendedor.Focus();
            }
        }

        private void txt_Vendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Celular.Focus();
            }
        }

        private void txt_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Endereco.Focus();
            }
        }

        private void txt_Endereco_KeyDown(object sender, KeyEventArgs e)
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
