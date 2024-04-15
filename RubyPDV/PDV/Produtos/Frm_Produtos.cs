using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MODEL;
using Moderno.cadastross;
using MySql.Data.MySqlClient;

namespace Moderno.Produtos
{
    public partial class Frm_Produtos : Form
    {
        private string produto_id;
        private string codAntigo;
        private double vCompra;
        private double vVenda;
        private double lucroT;
        private double eCompra;
        private double eVenda;
        private double eLucro;
        private bool calcLucro = false;
        private int Entrada;
        public Frm_Produtos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Produtos_Load(object sender, EventArgs e)
        {
            ProdutosModel model = new ProdutosModel();
            Listar_fornecedor();
            txtNome.Focus();
            Listar_grid();
        }
        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "Produto_ID";
            grid.Columns[1].HeaderText = "Codigo de Barra";
            grid.Columns[2].HeaderText = "Produto";
            grid.Columns[3].HeaderText = "Embalagem";
            grid.Columns[4].HeaderText = "Estoque";
            grid.Columns[5].HeaderText = "Fornecedor";
            grid.Columns[6].HeaderText = "Entrada";
            grid.Columns[7].HeaderText = "Total compra";
            grid.Columns[8].HeaderText = "Custo Unitário";
            grid.Columns[9].HeaderText = "Valor Venda";
            grid.Columns[10].HeaderText = "Data";
            grid.Columns[11].HeaderText = "Mínimo";
            grid.Columns[12].HeaderText = "N.Doc";
            grid.Columns[13].HeaderText = "Lucro";

            grid.Columns[7].DefaultCellStyle.Format = "c2";
            grid.Columns[8].DefaultCellStyle.Format = "c2";
            grid.Columns[9].DefaultCellStyle.Format = "c2";
            grid.Columns[13].DefaultCellStyle.Format = "c2";
            grid.Columns[0].Visible = false;
            grid.Columns[14].Visible = false;
            grid.Columns[15].Visible = false;
            grid.Columns[16].Visible = false;
            grid.Columns[17].Visible = false;
            grid.Columns[18].Visible = false;      
        }
        private void Listar_grid()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            grid.DataSource = produtoDAO.ListarProdutos();
            FormatarGrid();
        }
        private void Listar_fornecedor()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            cbFornecedor.DataSource = produtoDAO.Carregar_campo();
            cbFornecedor.DisplayMember = "fornecedor";
        }
        private bool Verificar_campo()
        {
            if (txtCodBarra.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Código de barra", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodBarra.Focus();
                return false;
            }
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }
            if (int.Parse(txtEntrada.Text) < 1)
            {
                MessageBox.Show("Preencha quantidade de Entrada", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEntrada.Text = "0";
                txtEntrada.Focus();
                return false;
            }
            if (vCompra < 0.01)
            {
                MessageBox.Show("Preencha o valor total da compra", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompra.Focus();
                return false;
            }
            if (Convert.ToDouble(txtValorVenda.Text) < 0.01)
            {
                MessageBox.Show("Preencha o valor da venda", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                return false;
            }
            if (txtValorVenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor de venda", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                return false;
            }
            return true;
        }
        private void desabilitarTxt()
        {
            if (Program.DesabilitarTxt == true)
            {
                txtCodBarra.Enabled = false;
                grid.Visible = true;
            }
            else
            {
                txtCodBarra.Enabled = true;
                grid.Visible = false;
            }
        }
        private void HabilitarCampos()
        {
            txtCodBarra.Enabled = true;
            txtCodBarra.Focus();
        }
        private void LimparCampos()
        {
            txtCodBarra.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtBuscarNome.Text = "";
            txtBuscarCod.Text = "";
            txtUnitario.Text = "0";
            txtEntrada.Text = "0";
            txtCompra.Text = "0";
            txtValorVenda.Text = "0";
            txtEstoque.Text = "0";
            txtMinimo.Text = "0";
            txtNota.Text = "0";
            txtLucro.Text = "0";
            cbFornecedor.SelectedIndex = 0;

            lblUltimaEntrada.Text = "0";
            lblValorCompra.Text = "0,00";
            lblValorVenda.Text = "0,00";
            lblValorUnit.Text = "0,00";
            lblLucro.Text = "0,00";
        }
        private void Cancelar()
        {
           /* btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;*/
            LimparCampos();
        }
       

       
        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }
        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbFornecedor.Focus();
            }
        }
        private void cbFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNota.Focus();
            }
        }
        private void txtNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMinimo.Focus();
            }
        }
        private void txtMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEstoque.Focus();
            }
        }
        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEntrada.Focus();
            }
        }
        private void txtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompra.Focus();
            }
        }
        private void txtCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUnitario.Focus();
            }
        }
        private void txtUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValorVenda.Focus();
            }
        }  
        private void txtValorVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLucro.Focus();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e, ProdutosModel produto)
        {
            Verificar_campo();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.EditaProduto(produto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.ExcluirProduto();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex >= 0 )
                {
                   if (grid.CurrentRow.Cells[0].Value != null)
                    {
                        produto_id = grid.CurrentRow.Cells[0].Value?.ToString();
                    }
                   if (grid.CurrentRow.Cells[1].Value != null)
                   {
                    txtCodBarra.Text = grid.CurrentRow.Cells[1].Value?.ToString();
                   }
                    if (grid.CurrentRow.Cells[2].Value != null)
                    {
                        txtNome.Text = grid.CurrentRow.Cells[2].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[3].Value != null)
                    {
                        txtDescricao.Text = grid.CurrentRow.Cells[3].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[4].Value != null)
                    {
                        txtEstoque.Text = grid.CurrentRow.Cells[4].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[5].Value != null)
                    {
                        cbFornecedor.Text = grid.CurrentRow.Cells[5].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[6].Value != null)
                    {
                        txtEntrada.Text = grid.CurrentRow.Cells[6].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[7].Value != null)
                    {
                        txtCompra.Text = grid.CurrentRow.Cells[7].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[8].Value != null)
                    {
                        txtValorVenda.Text = grid.CurrentRow.Cells[8].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[9].Value != null)
                    {
                        txtUnitario.Text = grid.CurrentRow.Cells[9].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[10].Value != null)
                    {
                        data.Text = grid.CurrentRow.Cells[10].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[11].Value != null)
                    {
                        txtMinimo.Text = grid.CurrentRow.Cells[11].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[12].Value != null)
                    {
                        txtNota.Text = grid.CurrentRow.Cells[12].Value?.ToString();
                    }
                    if (grid.CurrentRow.Cells[13].Value != null)
                    {
                        txtLucro.Text = grid.CurrentRow.Cells[13].Value?.ToString();
                    }
                
            }
        }

        private void btnIncluir_Click( object sender, EventArgs e)
        {
            try
            {
                SalvarRegistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SalvarRegistro()
        {
            if (Verificar_campo())
            {
                return;
            }
            ProdutosModel produto = new ProdutosModel();
            ProdutoDAO produtoDAO = new ProdutoDAO();
             produto.produto_id = int.Parse(txtCodBarra.Text);
             produto.codigo_barra = txtCodBarra.Text;
             produto.Nome = txtNome.Text;
             produto.Descricao = txtDescricao.Text;
             produto.Entrada_estoque = txtEstoque.Text;
             produto.Fornecedor = cbFornecedor.Text;
             produto.Entrada = txtEntrada.Text;
             produto.total_compra = double.Parse(txtCompra.Text);
             produto.Unitario = int.Parse(txtUnitario.Text);
             produto.valor_venda = double.Parse(txtValorVenda.Text);
             produto.Minimo = int.Parse(txtMinimo.Text);
             produto.Nota = int.Parse(txtNota.Text);
             produto.eLucro = double.Parse(txtLucro.Text);
            try
            {
                produtoDAO.SalvarProduto(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void formatarTextNumero(object sender, KeyPressEventArgs e)
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

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorVenda);
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtLucro);
        }

        private void txtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtUnitario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtUnitario);
        }

        private void txtUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtCompra);
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtEntrada);
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtBuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtLucro_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Fornecedores frm = new Frm_Fornecedores();
            this.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
