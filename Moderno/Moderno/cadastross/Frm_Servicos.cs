using DAO;
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
using MODEL;

namespace Moderno.cadastross
{
    public partial class Frm_Servicos : Form
    {
        private bool campoClicado = false;
        private string servico_id;
        public Frm_Servicos()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Servicos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "Serviço_ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Valor";
            grid.Columns[2].DefaultCellStyle.Format = "C2";
            grid.Columns[0].Visible = false;
        }
        private void Listar()
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            grid.DataSource = servicoDAO.ListarServicos();
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
        }
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Valor.Text = "";
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            HabilitarCampos();
            LimparCampos();
            Listar();
        }
        private void VerificarCampo()
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
        }
        private void SalvarRigistro(ServicoMODAL servico)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            VerificarCampo();
            
            servico.nome = txt_Nome.Text;
            servico.valor = decimal.Parse(txt_Valor.Text);
            servicoDAO.Salvar_servico(servico);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ServicoMODAL servicoMODAL = new ServicoMODAL();
            SalvarRigistro(servicoMODAL);
        }
        private void EditarRegistro(ServicoMODAL servico)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            VerificarCampo();
            //botao editar
           
            servico.nome = txt_Nome.Text;
            servico.valor = decimal.Parse(txt_Valor.Text);
            servicoDAO.Editar_servico(servico);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Editado com sucesso!", "Cadastro serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            ServicoMODAL servicoMODAL = new ServicoMODAL();
            EditarRegistro(servicoMODAL);
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

                servico_id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Valor.Text = grid.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                return;
            }
        }
        private void ExcluirRegistro(ServicoMODAL servico)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                
                servico.servico_id = int.Parse(servico_id);
                servicoDAO.Excluir_servico(servico);
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
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ServicoMODAL servicoMODAL = new ServicoMODAL();
            ExcluirRegistro(servicoMODAL);
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
        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Valor);
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
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
                txt_Valor.Focus();
            }
        }

        private void txt_Valor_KeyDown(object sender, KeyEventArgs e)
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
