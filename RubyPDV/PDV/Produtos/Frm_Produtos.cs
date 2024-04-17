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
            grid.Columns[3].HeaderText = "Uni_Medida";
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
            try
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
                if (decimal.Parse(txtEntrada.Text) < 1)
                {
                    MessageBox.Show("Preencha quantidade de Entrada", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEntrada.Text = "0";
                    txtEntrada.Focus();
                    return false;
                }
                if (decimal.Parse(txtCompra.Text) < 0)
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
            catch (Exception)
            {
                throw;
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
            cb_uniMedida.Text = "";
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
        }
        private void Cancelar()
        {
            LimparCampos();
            txtCodBarra.Focus();
        }
        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
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
        private void Excluirregistro()
        {
            ProdutosModel produto = new ProdutosModel();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "Cadastro Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                produto.produto_id = int.Parse(produto_id);
                produtoDAO.ExcluirProduto(produto);
                Listar_grid();
                MessageBox.Show("Registro Excluído com sucesso!.", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluirregistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (grid.CurrentRow.Cells[0].Value != null)
                {
                    produto_id = grid.CurrentRow.Cells[0].Value.ToString();
                }
                if (grid.CurrentRow.Cells[1].Value != null)
                {
                    txtCodBarra.Text = grid.CurrentRow.Cells[1].Value.ToString();
                }
                if (grid.CurrentRow.Cells[2].Value != null)
                {
                    txtNome.Text = grid.CurrentRow.Cells[2].Value.ToString();
                }
                if (grid.CurrentRow.Cells[3].Value != null)
                {
                    cb_uniMedida.Text = grid.CurrentRow.Cells[3].Value.ToString();
                }
                if (grid.CurrentRow.Cells[4].Value != null)
                {
                    txtEstoque.Text = grid.CurrentRow.Cells[4].Value.ToString();
                }
                if (grid.CurrentRow.Cells[5].Value != null)
                {
                    cbFornecedor.Text = grid.CurrentRow.Cells[5].Value.ToString();
                }
                if (grid.CurrentRow.Cells[6].Value != null)
                {
                    txtEntrada.Text = grid.CurrentRow.Cells[6].Value.ToString();
                }
                if (grid.CurrentRow.Cells[7].Value != null)
                {
                    txtCompra.Text = grid.CurrentRow.Cells[7].Value.ToString();
                }
                if (grid.CurrentRow.Cells[8].Value != null)
                {
                    txtValorVenda.Text = grid.CurrentRow.Cells[8].Value.ToString();
                }
                if (grid.CurrentRow.Cells[9].Value != null)
                {
                    txtUnitario.Text = grid.CurrentRow.Cells[9].Value.ToString();
                }
                if (grid.CurrentRow.Cells[10].Value != null)
                {
                    data.Text = grid.CurrentRow.Cells[10].Value.ToString();
                }
                if (grid.CurrentRow.Cells[11].Value != null)
                {
                    txtMinimo.Text = grid.CurrentRow.Cells[11].Value.ToString();
                }
                if (grid.CurrentRow.Cells[12].Value != null)
                {
                    txtNota.Text = grid.CurrentRow.Cells[12].Value.ToString();
                }
                if (grid.CurrentRow.Cells[13].Value != null)
                {
                    txtLucro.Text = grid.CurrentRow.Cells[13].Value.ToString();
                }
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
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
            if (!Verificar_campo())
            {
                return;
            }
            ProdutosModel produto = new ProdutosModel();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produto.codigo_barra = txtCodBarra.Text;
            produto.Nome = txtNome.Text;
            produto.uni_medida = cb_uniMedida.Text;
            produto.Entrada_estoque = txtEstoque.Text;
            produto.Fornecedor = cbFornecedor.Text;
            produto.Entrada = txtEntrada.Text;
            produto.total_compra = double.TryParse(txtCompra.Text, out double compra) ? compra : 0.0;
            produto.Unitario = double.TryParse(txtUnitario.Text, out double unitario) ? unitario : 0;
            produto.valor_venda = double.TryParse(txtValorVenda.Text, out double valorVenda) ? valorVenda : 0.0;
            produto.Minimo = int.TryParse(txtMinimo.Text, out int minimo) ? minimo : 0;
            produto.Nota = int.TryParse(txtNota.Text, out int nota) ? nota : 0;
            produto.eLucro = double.TryParse(txtLucro.Text, out double lucro) ? lucro : 0.0;
            try
            {
                produtoDAO.SalvarProduto(produto);
                MessageBox.Show("Registro salvo com sucesso!", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar_grid();
                LimparCampos();
                HabilitarCampos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EditarRegistro()
        {
            if (!Verificar_campo())
            {
                return;
            }
            ProdutosModel produto = new ProdutosModel();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produto.produto_id = int.Parse(produto_id);
            produto.codigo_barra = txtCodBarra.Text;
            produto.Nome = txtNome.Text;
            produto.uni_medida = cb_uniMedida.Text;
            produto.Entrada_estoque = txtEstoque.Text;
            produto.Fornecedor = cbFornecedor.Text;
            produto.Entrada = txtEntrada.Text;
            produto.total_compra = double.TryParse(txtCompra.Text, out double compra) ? compra : 0.0;
            produto.Unitario = int.TryParse(txtUnitario.Text, out int unitario) ? unitario : 0;
            produto.valor_venda = double.TryParse(txtValorVenda.Text, out double valorVenda) ? valorVenda : 0.0;
            produto.Minimo = int.TryParse(txtMinimo.Text, out int minimo) ? minimo : 0;
            produto.Nota = int.TryParse(txtNota.Text, out int nota) ? nota : 0;
            produto.eLucro = double.TryParse(txtLucro.Text, out double lucro) ? lucro : 0.0;
            try
            {
                produtoDAO.EditaProduto(produto);
                MessageBox.Show("Registro editado com sucesso!", "Cadastro produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar_grid();
                LimparCampos();
                HabilitarCampos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarRegistro();
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
            catch (Exception ex)
            {
                throw ex;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
