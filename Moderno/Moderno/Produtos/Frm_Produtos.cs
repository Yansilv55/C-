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
            txtNome.Focus();
            Listar_grid();
        }
        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Produto";
            grid.Columns[2].HeaderText = "Embalagem";
            grid.Columns[3].HeaderText = "Estoque";
            grid.Columns[4].HeaderText = "Fornecedor";
            grid.Columns[5].HeaderText = "Entrada";
            grid.Columns[6].HeaderText = "V.Pago";
            grid.Columns[7].HeaderText = "Venda";
            grid.Columns[8].HeaderText = "CustoUnit";
            grid.Columns[9].HeaderText = "Data";
            grid.Columns[10].HeaderText = "Mínimo";
            grid.Columns[11].HeaderText = "N.Doc";
            grid.Columns[12].HeaderText = "Lucro";

            grid.Columns[6].DefaultCellStyle.Format = "c2";
            grid.Columns[7].DefaultCellStyle.Format = "c2";
            grid.Columns[8].DefaultCellStyle.Format = "c2";
            grid.Columns[13].DefaultCellStyle.Format = "c2";
            grid.Columns[0].Visible = false;
            grid.Columns[10].Visible = false;
            grid.Columns[6].Visible = false;
        }
        private void Listar_grid()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            grid.DataSource = produtoDAO.ListarProdutos();
        }
        private void Verificar_campo()
        {
            if (txtCodBarra.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Código de barra", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodBarra.Focus();
                return;
            }
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (int.Parse(txtEntrada.Text) < 1)
            {
                MessageBox.Show("Preencha quantidade de Entrada", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEntrada.Text = "0";
                txtEntrada.Focus();
                return;
            }
            if (vCompra < 0.01)
            {
                MessageBox.Show("Preencha o valor total da compra", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompra.Focus();
                return;
            }
            if (Convert.ToDouble(txtValorVenda.Text) < 0.01)
            {
                MessageBox.Show("Preencha o valor da venda", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                return;
            }
            if (txtValorVenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor de venda", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                return;
            }
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
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            LimparCampos();
        }
       

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.BuscarProduto();
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
                txtEntrada.Focus();
            }
        }

        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {
           
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

        private void btnIncluir_Click(object sender, EventArgs e, ProdutosModel produto)
        {
            Verificar_campo();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.SalvarProduto(produto);
            vCompra = Convert.ToDouble(txtCompra.Text);
            vVenda = Convert.ToDouble(txtValorVenda.Text);
            Entrada = int.Parse(txtEntrada.Text);
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
            if (e.RowIndex >= 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnIncluir.Enabled = false;
                txtNome.Focus();


                produto_id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtDescricao.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtEstoque.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cbFornecedor.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txtEntrada.Text = grid.CurrentRow.Cells[5].Value.ToString();
                txtCompra.Text = grid.CurrentRow.Cells[6].Value.ToString();
                txtValorVenda.Text = grid.CurrentRow.Cells[7].Value.ToString();
                txtCompra.Text = grid.CurrentRow.Cells[8].Value.ToString();
                data.Text = grid.CurrentRow.Cells[9].Value.ToString();
                txtMinimo.Text = grid.CurrentRow.Cells[10].Value.ToString();
                txtNota.Text = grid.CurrentRow.Cells[11].Value.ToString();
                txtLucro.Text = grid.CurrentRow.Cells[12].Value.ToString();
            }
        }
    }
}
