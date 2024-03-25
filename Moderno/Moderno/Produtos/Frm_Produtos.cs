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
        }

        private void Frm_Produtos_Load(object sender, EventArgs e)
        {

        }
        private void Formatargrid()
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
    }
}
