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
using DAO;
using MODEL;
using Moderno.Movimentacoes;
using Newtonsoft.Json;

namespace Moderno.Vendas
{
    public partial class Frm_Vendas : Form
    {
        private int item = 0;
        private int venda_id = 0;
        private int estoqueProduto = 0;
        private int nota = 0;
        private string idExcluirProduto;
        private string nomeProduto;
        private string tipo;
        private string qtdProduto;
        private string unitario;
        private string ultimoIdVenda;
        private string idProduto;
        private string entrada;
        private string codigoProduto;
        private string atualizarEstoque;
        private string ultimoIdGrid;
        private string numeroNota;
        private string idDetalheVenda;
        private string nomeCliente;
        private double qtd;
        private double valorUnitario;
        private double movimentacao;
        private double subTotal;
        private double valorVenda;
        private double dinheiro;
        private double taxa;
        private double pix;
        private double cartao;
        private double valorDescontado;
        private double troco;
        private double dinheiroX;
        private double valor_totaly;
        private double valor_totalx;
        private double valor_totalz;
        private double valor_total;
        private double valor_pago;
        private double totalPagar;
        private double cartaoDinheiroPix;
        public Frm_Vendas()
        {
            InitializeComponent();
        }

        public class Venda
        {
            public decimal sub_total { get; set; }
            public decimal valor_total { get; set; }
        }

        private void Frm_Vendas_Load(object sender, EventArgs e)
        {
            DesabilitarCampo();
            txt_CodProduto.Focus();
        }

        private void Frm_Vendas_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_TotalVenda_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_CodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               Vendas.Frm_fechar_venda frm = new Frm_fechar_venda();
                frm.ShowDialog();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if(txt_CodProduto.Text != "")
                {
                    VendaProduto();
                }
                else
                {
                    //
                }
            }
        }

        private void VendaProduto()
        {
            ProdutosModel produto = new ProdutosModel();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            string codigo_barra = txt_CodProduto.Text;
            produto.codigo_barra = codigo_barra;

            produto = produtoDAO.BuscarProduto(codigo_barra);

            string arquivoJson = JsonConvert.SerializeObject(produto);

            //produto = produtoDAO.BuscarProduto(codBarras);
            if (produto != null)
            {
                gridDetalhes.DataSource = produtoDAO;
            }
        }
        private void DesabilitarCampo()
        {
            txt_Quantidade.Enabled = false;
            txt_SubTotal.Enabled = false;
            txt_TotalVenda.Enabled = false;
            txt_ValorUnitario.Enabled = false;
        }
        private void txt_ValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txt_ValorUnitario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_ValorUnitario);
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
        private void txt_SubTotal_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_SubTotal);
        }
        private void txt_TotalVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_TotalVenda);
        }
        static void Main(string[] args)
        {
            // Caminho do arquivo JSON
            string caminhoArquivo = "itens.json";

            // Ler os itens existentes do arquivo JSON (se existir)
            List<Item> itensExistente = LerItensDeArquivo(caminhoArquivo);

            // Adicionar novos itens
            itensExistente.Add(new Item { Nome = "Novo Item 1", Quantidade = 20 });
            itensExistente.Add(new Item { Nome = "Novo Item 2", Quantidade = 30 });

            // Salvar a lista atualizada de volta no arquivo JSON
            SalvarItensEmArquivo(itensExistente, caminhoArquivo);

            Console.WriteLine("Novos itens adicionados e arquivo JSON atualizado com sucesso.");
        }
        static List<Item> LerItensDeArquivo(string caminhoArquivo)
        {
            // Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Ler o conteúdo do arquivo JSON
                string json = File.ReadAllText(caminhoArquivo);

                // Desserializar o JSON para uma lista de itens
                return JsonConvert.DeserializeObject<List<Item>>(json);
            }
            else
            {
                // Se o arquivo não existir, retornar uma nova lista vazia
                return new List<Item>();
            }
        }
        static void SalvarItensEmArquivo(List<Item> itens, string caminhoArquivo)
        {
            // Serializa a lista de itens para formato JSON
            string json = JsonConvert.SerializeObject(itens, Formatting.Indented);

            // Escreve o JSON no arquivo
            File.WriteAllText(caminhoArquivo, json);
        }
    }
    public class Item
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}
