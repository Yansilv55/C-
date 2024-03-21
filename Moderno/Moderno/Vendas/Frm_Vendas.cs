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

namespace Moderno.Vendas
{
    public partial class Frm_Vendas : Form
    {
        string id, idExcluirProduto, nomeProduto, qtdProduto, unitario, ultimoIdVenda;
        int item = 0; //conta o numero do lancamento do item      
        double qtd, valorUnitario, subTotal, valorVenda, dinheiro, pix, cartao, valorDescontado, troco, dinheiroX;


        double valor_totaly, valor_totalx, valor_totalz, valor_total, totalPagar, cartaoDinheiroPix;
        string idProduto, codigoProduto, atualizarEstoque, ultimoIdGrid, numeroNota, idDetalheVenda;
        int estoqueProduto, nota;
        public Frm_Vendas()
        {
            InitializeComponent();
        }

        

        private void detalhes_lancarvendas()
        {
            gridDetalhes.Columns[0].HeaderText = "Id";
            gridDetalhes.Columns[1].HeaderText = "Id. Vendas";
            gridDetalhes.Columns[2].HeaderText = "Código";
            gridDetalhes.Columns[3].HeaderText = "Item";
            gridDetalhes.Columns[4].HeaderText = "Descrição";
            gridDetalhes.Columns[5].HeaderText = "Qtd";
            gridDetalhes.Columns[6].HeaderText = "Unitário";
            gridDetalhes.Columns[7].HeaderText = "Subtotal";
            gridDetalhes.Columns[8].HeaderText = "Atendente";
            gridDetalhes.Columns[9].HeaderText = "id_produto";
            gridDetalhes.Columns[10].HeaderText = "Data";
            gridDetalhes.Columns[11].HeaderText = "Recibo";
            gridDetalhes.Columns[6].DefaultCellStyle.Format = "c2";
            gridDetalhes.Columns[7].DefaultCellStyle.Format = "c2";
            gridDetalhes.Columns[0].Visible = false;
            gridDetalhes.Columns[1].Visible = false;
            gridDetalhes.Columns[8].Visible = false;
            gridDetalhes.Columns[9].Visible = false;
            gridDetalhes.Columns[10].Visible = false;
            gridDetalhes.Columns[11].Visible = false;
        }

        private void txt_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //pegar dados do cliente
                informacoesCliente();
                txt_Clientes.Enabled = false;
                btnConfirmar.Enabled = false;

                panelCliente.Visible = true;
                if (lblClienteBloqeado.Text == "Não")
                {
                    bntConcluirVenda.Enabled = true;
                    txtDinheiro.Focus();
                }
                else if (lblClienteBloqeado.Text == "Sim")
                {
                    bntConcluirVenda.Enabled = false;
                    MessageBox.Show("Cliente bloqueado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.KeyCode == Keys.Tab)
            {

                //pegar dados do cliente
                informacoesCliente();
                txt_Clientes.Enabled = false;
                btnConfirmar.Enabled = false;

                panelCliente.Visible = true;
                if (lblClienteBloqeado.Text == "Não")
                {
                    bntConcluirVenda.Enabled = true;
                    txtDinheiro.Focus();
                }
                else if (lblClienteBloqeado.Text == "Sim")
                {
                    bntConcluirVenda.Enabled = false;
                    MessageBox.Show("Cliente bloqueado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void somaItem()
        {
            item += 1;
        }
        private void limparVendaPrazo()
        {
            valor_totaly = 0;
            valor_totalx = 0;
            valor_total = 0;
            totalPagar = 0;
            cartaoDinheiroPix = 0;
        }
        private void limparCampos()
        {
            txtCodProduto.Text = "";
            txtBusca.Text = "";
            txtQuantidade.Text = "1";
            estoqueProduto = 0;
            FinalizarVendas.IdProduto = 0;
            txtCodProduto.Focus();

            lblIdPro.Text = "0";
            lblIdItem.Text = "0";
            lblEstoque.Text = "0";
        }

        private void LimparItem()
        {
            txtDescricao.Text = "...";
            txtQtd.Text = "0";
            txtValorUnitario.Text = "0,00";
            txtSubTotal.Text = "0,00";
            txtItem.Text = "0";
            txtTotalVenda.Text = "0,00";
        }
        private void calcSubTotal() // esse é usado quando o item é pego pelo código, tive q fazer a divisao por 100
        {
            qtd = Convert.ToInt32(txtQuantidade.Text);
            valorUnitario = Convert.ToDouble(unitario) / 100; //dividindo por 100 para quem o valor fique certo, 7,00 e nao 7.000
            subTotal = (qtd * valorUnitario);//como já dividi valorUnitario por 100 a multiplicacao fica certa ex.: 2 * 7,00 = 14,00 (senao ficava erada, 2*7.000=14.000)
            txtSubTotal.Text = String.Format("{0:C2}", subTotal);
            valorVenda += subTotal;
            txtTotalVenda.Text = String.Format("{0:C2}", valorVenda);
        }
        private void TotalizandoEntradas()
        {
            double total = 0;

            //percorrendo cada linha da grid, p/ pegar e somar cada linha do array 'subtotal'. Não é na tabela.
            foreach (DataGridViewRow row in gridDetalhes.Rows)
            {
                if (row.Cells["data"].Value.ToString() == DateTime.Today.ToString()) // a grid em aberto neste momento
                {
                    //pegando a celular e somando 
                    total += Convert.ToDouble(row.Cells["subtotal"].Value); //pode ser pelo indece tb
                }

            }
            txtTotalVenda.Text = Convert.ToDouble(total).ToString("C2");
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBusca.Text.Trim() == "")
                {
                    MessageBox.Show("Selecione o item do lançamento!!! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodProduto.Focus();
                    return;
                }

                LimparItem();// ---------ok
                txtDescricao.Text = txtBusca.Text;
                txtQtd.Text = txtQuantidade.Text;
                txtItem.Text = item.ToString();
                TotalizandoEntradas(); //----------------------------------------------------------------------------- ok
                calcSubTotal();
                txtValorUnitario.Text = String.Format("{0:C2}", valorUnitario);
                LancarItemNaVenda(); //  criar a tab. a prazo para lançar consumo a prazo
                limparCampos();
                TotalizandoEntradas(); //----------------------------------------------------------------------------- ok
            }
            if (e.KeyCode == Keys.Tab)
            {
                if (txtBusca.Text.Trim() == "")
                {
                    MessageBox.Show("Selecione o item do lançamento!!! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodProduto.Focus();
                }

                LimparItem();// ---------ok
                txtDescricao.Text = txtBusca.Text;
                txtQtd.Text = txtQuantidade.Text;
                txtItem.Text = item.ToString();
                TotalizandoEntradas(); //----------------------------------------------------------------------------- ok
                calcSubTotal();
                txtValorUnitario.Text = String.Format("{0:C2}", valorUnitario); // ---------mexendo aqui
                LancarItemNaVenda(); // criar a tab. a prazo para lançar consumo a prazo
                limparCampos();
                TotalizandoEntradas(); //----------------------------------------------------------------------------- ok
            }
        }

        private void bntConcluirVenda_Click(object sender, EventArgs e)
        {
            if (txt_Clientes.Text.Trim() == "")
            {
                MessageBox.Show("Necessário selecionar o cliente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Clientes.Focus();
            }
            else
            {
                txt_Clientes.Focus();
                valor_totaly = Double.Parse(lblValorPagar.Text, System.Globalization.NumberStyles.Currency); //double SEM R$ Convert.ToDouble(lblValorPagar.Text);
                valor_totalx = Convert.ToDouble(txtDesconto.Text);
                valor_totalz = Convert.ToDouble(txtTaxa.Text);
                valor_total = valor_totaly - valor_totalx;

                totalPagar = Double.Parse(txtValorPagar.Text, System.Globalization.NumberStyles.Currency); //double SEM R$
                cartaoDinheiroPix = (dinheiro + pix + cartao);
                if (cartaoDinheiroPix >= totalPagar)
                {
                    MessageBox.Show("Valor inserido de:  " + cartaoDinheiroPix.ToString("C2") + " corresponde ao valor total do consumo, aplique o pagamento á vista", "AVISO");

                    dinheiro = 0;
                    pix = 0;
                    cartao = 0;
                    txtDinheiro.Text = "0";
                    txtPix.Text = "0";
                    txtCartao.Text = "0";
                    txtDinheiro.Focus();
                    return;
                }
                VendasDAO vendasDAO = new VendasDAO();
                vendasDAO.ConcluirVendas(nome);

                vendasDAO.Verificar_vendas();

                if (cartaoDinheiroPix > 0)
                {

                    vendasDAO.lanca_movimentações();
                    
                }

                //relacionar os itens com a venda
                vendasDAO.Relacionar_vendas();
                //fim relacionar os itens com a venda


                cancelar();
                limparCampos();
                LimparItem();
                limparVendaPrazo();
                Listardetalhes_lancarvendas();
                lblNota.Text = "0";
                panelVenda.Enabled = true;
                panelLancamento.Visible = true;
                panelVendaAvista.Visible = false;
                panelVendaAPrazo.Visible = false;
                this.panelLancamento.Location = new Point(1, 71);
                MessageBox.Show("Concluído com sucesso!", "AVISO");
                if (MessageBox.Show("Deseja emitir recibo ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Program.idVenda = ultimoIdVenda;
                    Relatorios.FrmRecibo frm = new Relatorios.FrmRecibo();
                    frm.ShowDialog();
                }
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            cancelarVenda();
            panelVenda.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            informacoesCliente();
            txt_Clientes.Enabled = false;
            btnConfirmar.Enabled = false;

            panelCliente.Visible = true;
            if (lblClienteBloqeado.Text == "Não")
            {
                bntConcluirVenda.Enabled = true;
                txtDinheiro.Focus();
            }
            else if (lblClienteBloqeado.Text == "Sim")
            {
                bntConcluirVenda.Enabled = false;
                MessageBox.Show("Cliente bloqueado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDinheiro);
            dinheiro = Convert.ToDouble(txtDinheiro.Text);
        }

        private void txtPix_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPix);
            pix = Convert.ToDouble(txtPix.Text);
        }

        private void txtCartao_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtCartao);
            cartao = Convert.ToDouble(txtCartao.Text);
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDesconto);
            var l = Double.Parse(lblValorPagar.Text, System.Globalization.NumberStyles.Currency);
            var d = Double.Parse(txtDesconto.Text, System.Globalization.NumberStyles.Currency);//Convert.ToDouble(txtDesconto.Text);
            var valorPrazo = l - d;
            txtValorPagar.Text = String.Format("{0:C2}", valorPrazo);
        }

        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTaxa);
            var vp = Double.Parse(lblValorPagar.Text, System.Globalization.NumberStyles.Currency);
            var t = Double.Parse(txtTaxa.Text, System.Globalization.NumberStyles.Currency);
            var taxaPrazo = vp + t;
            txtValorPagar.Text = String.Format("{0:C2}", taxaPrazo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
            txtDinheiro.Focus();
            panelVenda.Enabled = false;
        }

        private void gridDetalhes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletarItem();
            }
        }

        private void txtDinheiroAvista_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDinheiroAvista);
            dinheiro = Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text);
            if (txtDinheiroAvista.Text == "0,00")
            {
                labelTroco.Text = "0,00";
            }
            Troco();
        }

        private void txtDescontoAvista_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDescontoAvista);
            var lbl = Double.Parse(lblValorAvista.Text, System.Globalization.NumberStyles.Currency);
            var txt = Double.Parse(txtDescontoAvista.Text, System.Globalization.NumberStyles.Currency);
            var valor = lbl - txt;
            txtValorAvista.Text = String.Format("{0:C2}", valor);
            //se houver desconto            
            valorDescontado = txt;

        }

        private void txtTaxaAvista_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTaxaAvista);
            //var valor = Convert.ToDouble(lblValorAvista.Text) - Convert.ToDouble(txtDescontoAvista.Text);
            var lblTaxa = Double.Parse(lblValorAvista.Text, System.Globalization.NumberStyles.Currency);
            var txtTaxa = Double.Parse(txtTaxaAvista.Text, System.Globalization.NumberStyles.Currency);
            var valorTaxa = lblTaxa + txtTaxa;
            txtValorAvista.Text = String.Format("{0:C2}", valorTaxa);
        }

        private void txtPixAvista_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPixAvista);
            pix = Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text);
            Troco();
        }

        private void txtCartaoAvista_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtCartaoAvista);
            cartao = Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text);
            Troco();
        }

        private void txtDescontoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtTaxaAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtDinheiroAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Troco();
            }
        }

        private void txtPixAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Troco();
            }
        }

        private void txtCartaoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Troco();
                vDinheiro();
            }
        }

        private void txtPixAvista_Leave(object sender, EventArgs e)
        {
            Troco();
            vDinheiro();
            txtDinheiroAvista.Focus();
        }

        private void txtDescontoAvista_Click(object sender, EventArgs e)
        {
            txtDescontoAvista.Text = "0";
            txtTaxaAvista.Text = "0";
            txtDinheiroAvista.Text = "0";
            txtPixAvista.Text = "0";
            txtCartaoAvista.Text = "0";
            labelTroco.Text = "0,00";
        }

        private void txtTaxaAvista_Click(object sender, EventArgs e)
        {
            txtDescontoAvista.Text = "0";
            txtTaxaAvista.Text = "0";
            txtDinheiroAvista.Text = "0";
            txtPixAvista.Text = "0";
            txtCartaoAvista.Text = "0";
            labelTroco.Text = "0,00";
        }

        private void txtDinheiroAvista_Click(object sender, EventArgs e)
        {
            txtDinheiroAvista.Text = "0";
            txtPixAvista.Text = "0";
            txtCartaoAvista.Text = "0";
            labelTroco.Text = "0,00";
        }

        private void txtCartaoAvista_Leave(object sender, EventArgs e)
        {
            Troco();
            vDinheiro();
            txtPixAvista.Focus();
        }

        private void txtCartaoAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVendaAvista.Focus();
            }
        }

        private void txtDescontoAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDinheiroAvista.Focus();
            }
        }

        private void txtTaxaAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDinheiroAvista.Focus();
            }
        }

        private void txtDinheiroAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPixAvista.Focus();
            }
        }

        private void txtPixAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCartaoAvista.Focus();
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtPix_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void btnConfirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDinheiro.Focus();
            }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPix.Focus();
            }
        }

        private void txtPix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCartao.Focus();
            }
        }

        private void txtCartao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntConcluirVenda.Focus();
            }
        }

        private void txtDinheiro_Click(object sender, EventArgs e)
        {
            txtPix.Text = "0";
            txtCartao.Text = "0";
            pix = 0;
            cartao = 0;
        }

        private void txtPix_Click(object sender, EventArgs e)
        {
            txtCartao.Text = "0";
            cartao = 0;
        }

        private void txtDesconto_Click(object sender, EventArgs e)
        {
            txtDesconto.Text = "0";
            txtDinheiro.Text = "0";
            txtPix.Text = "0";
            txtCartao.Text = "0";
            txtTaxa.Text = "0";
            dinheiro = 0;
            pix = 0;
            cartao = 0;
        }

        private void txtTaxa_Click(object sender, EventArgs e)
        {
            txtDesconto.Text = "0";
            txtDinheiro.Text = "0";
            txtPix.Text = "0";
            txtCartao.Text = "0";
            dinheiro = 0;
            pix = 0;
            cartao = 0;
        }

        private void btnCancelarAvista_Click(object sender, EventArgs e)
        {
            lblValorAvista.Text = "0";
            cancelarAvista();
            panelVenda.Enabled = true;
            panelLancamento.Visible = true;
            panelVendaAvista.Visible = false;
            panelVendaAPrazo.Visible = false;
            this.panelLancamento.Location = new Point(1, 71);
            txtCodProduto.Focus();
        }
        private void cancelarAvista()
        {
            txtValorAvista.Text = lblValorAvista.Text;
            txtDescontoAvista.Text = "0";
            txtTaxaAvista.Text = "0";
            txtDinheiroAvista.Text = "0";
            txtPixAvista.Text = "0";
            txtCartaoAvista.Text = "0";
            labelTroco.Text = "0";
        }
        private void vDinheiro()
        {
            //usado p/ terminar o q foi em dinheiro, pq parte foi em cartao e /ou PIX (zero ou mais) e outra foi em dinheiro tb tira o desconto e acrescenta a taxa (valor: 42,50 - desconot:2,50 + taxa: 0)-(carta:5 - pix:15) = 20 pa dinheiro 
            dinheiroX = (Double.Parse(lblValorAvista.Text, System.Globalization.NumberStyles.Currency) - Convert.ToDouble(txtDescontoAvista.Text) + Convert.ToDouble(txtTaxaAvista.Text)) - Convert.ToDouble(txtCartaoAvista.Text) - Convert.ToDouble(txtPixAvista.Text);

        }

        private void gridDetalhes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                gridDetalhes.ClearSelection();
                return;
            }
            else
            {
                btnExcluirItem.Enabled = true;
                id = gridDetalhes.CurrentRow.Cells[0].Value.ToString();
                nomeProduto = gridDetalhes.CurrentRow.Cells[4].Value.ToString();
                qtdProduto = gridDetalhes.CurrentRow.Cells[5].Value.ToString();
                idExcluirProduto = gridDetalhes.CurrentRow.Cells[9].Value.ToString(); //id do produto p/ excluir da lista do item e devolver ao estoque
                idProduto = gridDetalhes.CurrentRow.Cells[9].Value.ToString();
                lblIdPro.Text = gridDetalhes.CurrentRow.Cells[9].Value.ToString();
                numeroNota = gridDetalhes.CurrentRow.Cells[11].Value.ToString();
                //item selecionado na grid
                txtItem.Text = gridDetalhes.CurrentRow.Cells[3].Value.ToString();
                txtDescricao.Text = gridDetalhes.CurrentRow.Cells[4].Value.ToString();
                txtQtd.Text = gridDetalhes.CurrentRow.Cells[5].Value.ToString();
                txtValorUnitario.Text = gridDetalhes.CurrentRow.Cells[6].Value.ToString();
                txtSubTotal.Text = gridDetalhes.CurrentRow.Cells[7].Value.ToString();

                //recuperando o total do estoque do produto (usando p/ devolver item dá venda)
                VendasDAO vendasDAO = new VendasDAO();
                vendasDAO.BuscarPorEstoque();
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            DeletarItem();
        }
        private void DeletarItem()
        {
            btnExcluirItem.Enabled = false;
            //

            if (MessageBox.Show("Deseja excluir o item: " + nomeProduto + " ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    // ao inves de deletar, moistrar com cancelada
                    con.AbrirConexao();
                    sql = "UPDATE detalhes_lancarvendas SET codigo_produto=@codigo_produto, quantidade=@quantidade, valor_unitario=@valor_unitario, subtotal=@subtotal, data = curDate() WHERE id=@id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@codigo_produto", "Item cancelado");
                    cmd.Parameters.AddWithValue("@quantidade", 0);
                    cmd.Parameters.AddWithValue("@valor_unitario", 0);
                    cmd.Parameters.AddWithValue("@subtotal", 0);
                    //cmd.Parameters.AddWithValue("@id_produto", 0);//coloquei pro id do produto assumir zero, ou seja nehum produto
                    cmd.Parameters.AddWithValue("@id", id);//WHERE                 
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();

                }
                catch (Exception)
                {
                }

                try
                {
                    //devolver quantidade no estoque 
                    con.AbrirConexao();
                    sql = "UPDATE produtos SET estoque=@estoque WHERE id=@id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", idProduto); //**id do produto q vem detalhes vendas, local
                    cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(atualizarEstoque) + Convert.ToInt32(qtdProduto));
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    //
                }
                catch (Exception)
                {
                }

                try
                {
                    //recuperar ultimo ITEM da venda  para exibir nos text o ultimo item da lista de detalhes da venda
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
                    cmdVerificar = new MySqlCommand("SELECT id FROM detalhes_lancarvendas ORDER BY id DESC LIMIT 1", con.con); //SELECT MAX(id) as maxId FROM table
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    reader = cmdVerificar.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())//extraíndo dados do id
                        {
                            ultimoIdGrid = Convert.ToString(reader["id"]);
                        }

                        // exibindo nos text o ultimo item 
                        MySqlCommand cmdVerifi;
                        MySqlDataReader real; //com o reader vou conseguir extrair dados da tabela e usar em outros form, neste caso quero o dinheiro e cartao de movimento
                        con.AbrirConexao();
                        cmdVerifi = new MySqlCommand("SELECT * FROM detalhes_lancarvendas WHERE id=@id", con.con);
                        cmdVerifi.Parameters.AddWithValue("@id", ultimoIdGrid);
                        MySqlDataAdapter Ada = new MySqlDataAdapter();
                        Ada.SelectCommand = cmdVerifi;
                        real = cmdVerifi.ExecuteReader();
                        if (real.HasRows)
                        {
                            while (real.Read())
                            {
                                txtItem.Text = Convert.ToString(real["item"]);
                                txtDescricao.Text = Convert.ToString(real["descricao"]); //descricao
                                txtQtd.Text = Convert.ToString(real["quantidade"]);
                                txtValorUnitario.Text = Convert.ToString(real["valor_unitario"]);
                                txtSubTotal.Text = Convert.ToString(real["subtotal"]);
                            }
                        }
                        con.FecharConexao();
                        //                        
                    }
                    else
                    {
                        txtItem.Text = "0";
                        txtDescricao.Text = "..."; //descricao
                        txtQtd.Text = "0";
                        txtSubTotal.Text = "0,00";
                        txtValorUnitario.Text = "0,00";
                    }
                    con.FecharConexao();
                    //fim recuperar ultimo ITEM da venda

                    //FIM, recuperar ultimo ITEM da venda  para exibir nos text o ultimo item da lista de detalhes da venda
                }
                catch (Exception)
                {
                }

                Listardetalhes_lancarvendas();
                TotalizandoEntradas();
                gridDetalhes.ClearSelection();
                txtCodProduto.Focus();
            }
        }

        private void btnVendaVista_Click(object sender, EventArgs e)
        {
            finalizarVendaAvista();
            panelVenda.Enabled = false;
        }

        private void btnVendaPrazo_Click(object sender, EventArgs e)
        {
            finalizarVendaPrazo(); //metodo finalizar vendas que chama a tela que ira determinar como sera a venda...
            bntConcluirVenda.Enabled = true;
            panelVenda.Enabled = false;
        }
        

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void ProdutoPorNome()
        {
            NumeroNota();

            MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form, neste caso quero o dinheiro e cartao de movimento
            con.AbrirConexao();
            cmdVerificar = new MySqlCommand("SELECT * FROM produtos WHERE nome=@nome", con.con);
            cmdVerificar.Parameters.AddWithValue("@nome", txtBusca.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FinalizarVendas.IdProduto = Convert.ToInt32(reader["id"]);
                    txtCodProduto.Text = Convert.ToString(reader["cod"]);
                    txtBusca.Text = Convert.ToString(reader["nome"]);
                    estoqueProduto = Convert.ToInt32(reader["estoque"]);
                    lblEstoque.Text = Convert.ToString(reader["estoque"]);
                    double unit = Convert.ToDouble(reader[8]); //* foi preciso pq obtendo o item pelo codigo o valor vem ao ives de vim 7,00 vem como 7.000 aí no metodo calcSubTotal() eu diviso por 100 pra dá ceto.
                    unitario = (unit * 100).ToString();//* só que aqui double unit = Convert.ToDouble(reader[8]); //*  pego o valor certo, 7,00 e tenho q multiplicar por 100 pra ficar 7.000 pro metodo calcSubTotal() dividir por 100

                    //
                    lblEstoque.Text = estoqueProduto.ToString();
                    lblIdPro.Text = FinalizarVendas.IdProduto.ToString();

                    somaItem();
                }
            }
            else
            {
                txtBusca.Text = "Produto não cadastrado";
            }
            con.FecharConexao();
            lblNota.Text = nota.ToString();

        }

        private void cancelar()
        {
            txt_Clientes.Enabled = true;
            btnConfirmar.Enabled = true;
            txt_Clientes.Text = "";
            lblValorAberto.Text = "0";
            lblCliente.Text = "0";
            lblClienteBloqeado.Text = "...";
            txtDesconto.Text = "0";
            txtTaxa.Text = "0";
            txtValorPagar.Text = "0";
            txtDinheiro.Text = "0";
            txtPix.Text = "0";
            txtCartao.Text = "0";
            dinheiro = 0;
            pix = 0;
            cartao = 0;
            panelCliente.Visible = false;
            DateTime fimMes = DateTime.Now;
            DateTime vencimento = fimMes.AddDays(30);
            dtVencimento.Text = vencimento.ToString();
            txt_Clientes.Focus();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProdutoPorCodigo();
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
            if (e.KeyCode == Keys.Tab)
            {
                ProdutoPorCodigo();
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
            //telas
            if (e.KeyCode == Keys.F3)
            {
                finalizarVendaAvista();// finalizar venda a vista
            }
            if (e.KeyCode == Keys.F4)
            {
                finalizarVendaPrazo();//finalizar vendas a prazo
            }

            if (e.KeyCode == Keys.F5)
            {
                cancelarVenda();
            }
            if (e.KeyCode == Keys.Escape)
            {
               /* Vendas.FrmAjuda frm = new Vendas.FrmAjuda();
                frm.ShowDialog();*/
            }
        }
        private void LancarItemNaVenda()
        {
            con.AbrirConexao();
            sql = "INSERT INTO detalhes_lancarvendas(id_venda, codigo_produto, item, descricao, quantidade, valor_unitario, subtotal, funcionario, id_produto, data, nota) VALUES(@id_venda, @codigo_produto, @item, @descricao, @quantidade, @valor_unitario, @subtotal, @funcionario, @id_produto, curDate(), @nota)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_venda", "0");
            cmd.Parameters.AddWithValue("@codigo_produto", codigoProduto);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@quantidade", txtQtd.Text);
            cmd.Parameters.AddWithValue("@valor_unitario", valorUnitario);
            //cmd.Parameters.AddWithValue("@valor_unitario", txtValorUnitario.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@subtotal", subTotal);
            cmd.Parameters.AddWithValue("@funcionario", Program.NomeUsuario); //* estiver em rede.            
            cmd.Parameters.AddWithValue("@id_produto", FinalizarVendas.IdProduto);
            cmd.Parameters.AddWithValue("@nota", nota);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            //abater quantidade no estoque (como eu faço uso dessa rotina duas vezes poderia criar um metodo)
            con.AbrirConexao();
            sql = "UPDATE produtos SET estoque=@estoque WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", FinalizarVendas.IdProduto);
            cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(estoqueProduto) - Convert.ToInt32(txtQuantidade.Text));
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            //fim abater

            idDetalheVenda = ""; //recolocando o id vazio, p/ que seja necessario selecionar o item p/ excluir tornando-o nao vazio / é pego o id ao clicar na gridDetalhes
            Listardetalhes_lancarvendas();// quando acionado, atualiza a grid q exibe os itens lançado naquele momento, a venda em execução no momento

        }
        private void informacoesCliente()
        {
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
            con.AbrirConexao();
            cmdVerificar = new MySqlCommand("SELECT * FROM clientes WHERE nome=@nome", con.con);
            cmdVerificar.Parameters.AddWithValue("@nome", txt_Clientes.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //extraíndo dados da tab quartos
                while (reader.Read())
                {
                    lblCliente.Text = Convert.ToString(reader["nome"]);
                    lblValorAberto.Text = Convert.ToString(reader["valorAberto"]);
                    lblClienteBloqeado.Text = Convert.ToString(reader["desbloqueado"]);
                }
            }
            con.FecharConexao();
        }
        private void cancelarVenda()
        {
            var res = double.Parse(txtTotalVenda.Text, System.Globalization.NumberStyles.Currency);//double SEM R$            
            if (res > 0)
            {
                MessageBox.Show("Necessário excluir todos os itens da lista, antes de excluir!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Deletar todos os itens de detalhes_lancarvendas  com o mesmo numero de nota 
                con.AbrirConexao();
                sql = "DELETE FROM detalhes_lancarvendas WHERE nota=@nota";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nota", numeroNota);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                //atualizar lista a

                limparCampos();
                LimparItem();
                lblNota.Text = "0";
                Listardetalhes_lancarvendas();

                panelVenda.Enabled = true;
                panelLancamento.Visible = true;
                panelVendaAvista.Visible = false;
                panelVendaAPrazo.Visible = false;
                this.panelLancamento.Location = new Point(1, 71);

                MessageBox.Show("Lançamento excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //lançando item na venda
        private void Listardetalhes_lancarvendas() // exibir venda atual e ainda com o id_venda zero
        {
            try
            {
            VendasDAO VendasDAO = new VendasDAO();
            VendasDAO.detalhes_lancarvendas();
            
            gridDetalhes.DataSource = dt;
            detalhes_lancarvendas();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VendasDAO VendasDAO = new VendasDAO();
                VendasDAO.Buscar_produto_vendas(TextBox txt_Buscar);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txt_Clientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Clientes.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
                VendasDAO VendasDAO = new VendasDAO();
                VendasDAO.Buscar_clientes();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProdutoPorCodigo();
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
            if (e.KeyCode == Keys.Tab)
            {
                ProdutoPorCodigo();
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
            //telas
            if (e.KeyCode == Keys.F3)
            {
                finalizarVendaAvista();// finalizar venda a vista
            }
            if (e.KeyCode == Keys.F4)
            {
                finalizarVendaPrazo();//finalizar vendas a prazo
            }

            if (e.KeyCode == Keys.F5)
            {
                cancelarVenda();
            }
            if (e.KeyCode == Keys.Escape)
            {
               /* Vendas.FrmAjuda frm = new Vendas.FrmAjuda();
                frm.ShowDialog();*/
            }
        }
        private void ProdutoPorCodigo()
        {
            NumeroNota();
            if (txtCodProduto.Text.Trim() != "")
            {
                con.AbrirConexao();//aqui p/ jogar no TEXTBOX os dados de produto
                MySqlCommand Cmm = new MySqlCommand("SELECT * FROM produtos WHERE cod=@cod", con.con);
                Cmm.CommandText = "SELECT  * from produtos WHERE cod =  " + txtCodProduto.Text;
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con.con;
                MySqlDataReader DR;
                DR = Cmm.ExecuteReader();
                DR.Read();
                //if (dt.Rows.Count > 0) 
                if (DR.HasRows) //existe
                {
                    id = Convert.ToString(DR.GetInt64(0));
                    FinalizarVendas.IdProduto = DR.GetInt32(0);
                    txtCodProduto.Text = DR.GetString(1);
                    txtBusca.Text = DR.GetString(2);
                    unitario = Convert.ToString(DR.GetMySqlDecimal(8)); //para multiplicar com a quantidade e fazer o subTotal
                    codigoProduto = DR.GetString(1);
                    estoqueProduto = DR.GetInt32(4);
                    lblIdPro.Text = FinalizarVendas.IdProduto.ToString();
                    lblEstoque.Text = estoqueProduto.ToString();

                    somaItem();
                }
                else
                {
                    txtBusca.Text = "Produto não cadastrado";
                }
                con.FecharConexao();
                lblNota.Text = nota.ToString();
            }
        }
        private void finalizarVendaAvista()
        {
            var res = double.Parse(txtTotalVenda.Text, System.Globalization.NumberStyles.Currency);//double SEM R$ 
            if (res > 0)
            {
                panelLancamento.Visible = false;
                panelVendaAPrazo.Visible = false;
                panelVendaAvista.Visible = true;
                this.panelVendaAvista.Location = new Point(7, 71);
                txtValorAvista.Text = txtTotalVenda.Text;
                lblValorAvista.Text = txtTotalVenda.Text;
                txtDinheiroAvista.Focus();
            }
            else
            {
                MessageBox.Show("Para finalizar um lançamento,  deve adiconar itens.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void finalizarVendaPrazo()
        {
            var res = double.Parse(txtTotalVenda.Text, System.Globalization.NumberStyles.Currency);//double SEM R$ 
            if (res > 0)
            {
                panelLancamento.Visible = false;
                panelVendaAvista.Visible = false;
                panelVendaAPrazo.Visible = true;
                this.panelVendaAPrazo.Location = new Point(7, 71);
                txtValorPagar.Text = txtTotalVenda.Text;
                lblValorPagar.Text = txtTotalVenda.Text;
                DateTime fimMes = DateTime.Now;
                DateTime vencimento = fimMes.AddDays(30);
                dtVencimento.Text = vencimento.ToString();
                txt_Clientes.Focus();
            }
            else
            {
                MessageBox.Show("Para finalizar um lançamento,  deve adiconar itens.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void NumeroNota()
        {
            //recuperar ultimo id da venda
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
            cmdVerificar = new MySqlCommand("SELECT id FROM lancar_vendas ORDER BY id DESC LIMIT 1", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //extraíndo dados do id
                while (reader.Read())
                {
                    nota = Convert.ToInt32(reader["id"]);
                }
            }
            con.FecharConexao();
            //fim recuperar ultimo id da venda
        }
        private void btnVendaAvista_Click(object sender, EventArgs e)
        {
            //valor maior é permitido pq tem troco,
            var Pagar = Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text); //double
            var totalPagarAvista = Double.Parse(txtValorAvista.Text, System.Globalization.NumberStyles.Currency); //double SEM R$           
            if (Pagar < totalPagarAvista)
            {
                MessageBox.Show("Não é permitido pagamento à vista com valor MENOR que o consumo! Você pode aplicar DESCONTO", "AVISTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCartaoAvista.Text = "0";
                txtDinheiroAvista.Text = "0";
                txtPixAvista.Text = "0";
                txtDinheiroAvista.Focus();
                return;
            }

            var Xvalor = Double.Parse(lblValorAvista.Text, System.Globalization.NumberStyles.Currency); //double SEM R$ 
            var x = Xvalor;
            var y = Double.Parse(txtDescontoAvista.Text);
            var z = Convert.ToDouble(txtTaxaAvista.Text);
            var XvalorAvista = (x - y) + z;

            vDinheiro();
            //lançar vendas avista
            con.AbrirConexao();
            sql = "INSERT INTO lancar_vendas(cliente, valor, desconto, taxa, valor_total, entrada, pago, apagar, pix, dinheiro, cartao, nota, funcionario, data, status) VALUES(@cliente, @valor, @desconto, @taxa, @valor_total, @entrada, @pago, @apagar, @pix, @dinheiro, @cartao, @nota, @funcionario, curDate(), @status)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cliente", "Padrão");
            cmd.Parameters.AddWithValue("@valor", Xvalor);
            cmd.Parameters.AddWithValue("@desconto", Convert.ToDouble(txtDescontoAvista.Text));
            cmd.Parameters.AddWithValue("@taxa", Convert.ToDouble(txtTaxaAvista.Text));
            cmd.Parameters.AddWithValue("@valor_total", XvalorAvista);
            cmd.Parameters.AddWithValue("@entrada", 0);
            cmd.Parameters.AddWithValue("@pago", XvalorAvista);
            cmd.Parameters.AddWithValue("@apagar", 0);
            cmd.Parameters.AddWithValue("@pix", Convert.ToDouble(txtPixAvista.Text));
            cmd.Parameters.AddWithValue("@dinheiro", dinheiroX);
            cmd.Parameters.AddWithValue("@cartao", Convert.ToDouble(txtCartaoAvista.Text));
            cmd.Parameters.AddWithValue("@nota", Convert.ToInt32(lblNota.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            cmd.Parameters.AddWithValue("@status", "Quitado");
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            //recuperar ultimo id da venda *********** APENAS GERA MOVIMENTO SE HOVER PAGO ALGUM VALOR, seja cartao e/ou dinheiro, pix ** ou quando QUITAR
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
            cmdVerificar = new MySqlCommand("SELECT id FROM lancar_vendas ORDER BY id DESC LIMIT 1", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo dados do id
                while (reader.Read())
                {
                    ultimoIdVenda = Convert.ToString(reader["id"]);
                }
            }
            con.FecharConexao();//fim recuperar ultimo id da venda

            //salvando venda na tabela de movimentaçoes 
            var Yvalor = Double.Parse(lblValorAvista.Text, System.Globalization.NumberStyles.Currency); //double SEM R$
            con.AbrirConexao();
            sql = "INSERT INTO lancar_movimentacoes(cliente, tipo, movimento, descricao, valor, desconto, taxa, valor_total, cartao, pix, dinheiro, nota, valor_pago, funcionario, id_movimento, data) VALUES(@cliente, @tipo, @movimento, @descricao, @valor, @desconto, @taxa, @valor_total, @cartao, @pix, @dinheiro, @nota, @valor_pago, @funcionario, @id_movimento, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cliente", "Padrão");
            cmd.Parameters.AddWithValue("@tipo", "Entrada");
            cmd.Parameters.AddWithValue("@movimento", "Venda mercadoria");
            cmd.Parameters.AddWithValue("@descricao", "Produto");
            cmd.Parameters.AddWithValue("@valor", Yvalor);
            cmd.Parameters.AddWithValue("@desconto", Convert.ToDouble(txtDescontoAvista.Text));
            cmd.Parameters.AddWithValue("@taxa", Convert.ToDouble(txtTaxaAvista.Text));
            cmd.Parameters.AddWithValue("@valor_total", XvalorAvista);
            cmd.Parameters.AddWithValue("@cartao", Convert.ToDouble(txtCartaoAvista.Text));
            cmd.Parameters.AddWithValue("@pix", Convert.ToDouble(txtPixAvista.Text));
            cmd.Parameters.AddWithValue("@dinheiro", dinheiroX); //------------ testando
            cmd.Parameters.AddWithValue("@nota", lblNota.Text);
            cmd.Parameters.AddWithValue("@valor_pago", XvalorAvista); //-------------- ok
            cmd.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            cmd.Parameters.AddWithValue("@id_movimento", ultimoIdVenda);
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            ////fim salvando venda na tabela de movimentaçoes

            //relacionar os itens com a venda
            con.AbrirConexao();
            sql = "UPDATE detalhes_lancarvendas SET id_venda = @id_venda WHERE id_venda = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", "0");
            cmd.Parameters.AddWithValue("@id_venda", ultimoIdVenda);
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            //fim relacionar os itens com a venda

            cancelarAvista();

            Listardetalhes_lancarvendas();
            limparCampos();
            LimparItem();
            lblNota.Text = "0";
            panelVenda.Enabled = true;
            panelLancamento.Visible = true;
            panelVendaAvista.Visible = false;
            panelVendaAPrazo.Visible = false;
            this.panelLancamento.Location = new Point(1, 71);
            MessageBox.Show("Concluído com sucesso!", "AVISO");
            if (MessageBox.Show("Deseja emitir recibo ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Program.idVenda = ultimoIdVenda;
                /*Relatorios.FrmRecibo frm = new Relatorios.FrmRecibo();*/
                frm.ShowDialog();
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

        //TextBox ao digitar apresenta no formato moeda
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
        //metodo troco
        private void Troco()
        {
            if (valorDescontado > 0)
            {
                //troco = (Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text)) - valorDescontado;

                //testando
                var Pagando = Double.Parse(txtValorAvista.Text, System.Globalization.NumberStyles.Currency); //double SEM R$
                troco = (Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text)) - Pagando;
                labelTroco.Text = String.Format("{0:C2}", troco);
            }
            if (valorDescontado <= 0)
            {
                var vTotal = Double.Parse(txtValorAvista.Text, System.Globalization.NumberStyles.Currency);
                troco = (Convert.ToDouble(txtDinheiroAvista.Text) + Convert.ToDouble(txtPixAvista.Text) + Convert.ToDouble(txtCartaoAvista.Text)) - vTotal;
                labelTroco.Text = String.Format("{0:C2}", troco);
            }
        }


    }//fim

}
