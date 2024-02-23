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

namespace Moderno.Movimentacoes
{
    public partial class Frm_Caixa : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        double pagtoD = 0;
        double pagtoC = 0;
        double pagtoP = 0;

        public Frm_Caixa()
        {
            InitializeComponent();
        }

        private void Frm_Caixa_Load(object sender, EventArgs e)
        {
            dt_Inicial.Text = DateTime.Now.ToString();
            dt_Final.Text = DateTime.Now.ToString();
            cb_Tipo.SelectedIndex = 0;

            BuscarTipo();
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor")
            {
                grid.Enabled = true;
                btn_Add.Enabled = true;
                btn_Sub.Enabled = true;
                lbl_TransRecebidaNaConta.Visible = true;
                lbl_TransRecebidaNoCaixa.Visible = true;
                btn_Conta.Enabled = true;
                btn_OKCaixa.Enabled = true;
                cb_Tipo.Enabled = true;
                lbl_Entrada.Visible = true;
                lbl_Transferencias.Visible = true;
                dt_Inicial.Enabled = true;
                dt_Final.Enabled = true;
                Listar();
            }
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Data";
            grid.Columns[2].HeaderText = "Hisórico";
            grid.Columns[3].HeaderText = "Forma Pagamento";
            grid.Columns[4].HeaderText = "Valor";
            grid.Columns[5].HeaderText = "Taxa";
            grid.Columns[6].HeaderText = "Total";
            grid.Columns[7].HeaderText = "Saídas";
            grid.Columns[8].HeaderText = "Transf. D/C";
            grid.Columns[9].HeaderText = "Transf. C/D";
            grid.Columns[10].HeaderText = "tipo";
            grid.Columns[11].HeaderText = "Dinheiro";
            grid.Columns[12].HeaderText = "Pix";
            grid.Columns[13].HeaderText = "Cartão";
            grid.Columns[14].HeaderText = "Funcionário";

            grid.Columns[4].DefaultCellStyle.Format = "C2";
            grid.Columns[5].DefaultCellStyle.Format = "C2";
            grid.Columns[6].DefaultCellStyle.Format = "C2";
            grid.Columns[7].DefaultCellStyle.Format = "C2";
            grid.Columns[8].DefaultCellStyle.Format = "C2";
            grid.Columns[9].DefaultCellStyle.Format = "C2";
            grid.Columns[10].DefaultCellStyle.Format = "C2";
            grid.Columns[11].DefaultCellStyle.Format = "C2";
            grid.Columns[12].DefaultCellStyle.Format = "C2";
            grid.Columns[0].Visible = false;
            //como os metodos Listar() e BuscarData() sempre chama o metodo FormatarGD(), ideal colocar o metodo Totalizando() aqui.
            Totalizando();
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM caixa ORDER BY data desc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }
        private void LimparCampos()
        {
            text_Descricao.Text = "";
            txt_Saida.Text = "0";
            txt_Descricao.Text = "";
            txt_Entrada.Text = "0";
            txt_Taxa.Text = "0";
            txt_Taxa.Enabled = false;
            cb_FormaPagto.SelectedIndex = 0;
        }
        private void BuscarData()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM caixa WHERE data>=@dataInicial AND data<=@dataFinal AND tipo=@tipo ORDER BY data DESC ";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(dt_Inicial.Text));
            conn.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(dt_Final.Text));
            conn.Parameters.AddWithValue("@tipo", cb_Tipo.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }
        private void BuscarTipo()
        {
            try
            {
                con.AbrirConexao();
                if (cb_Tipo.SelectedIndex == 0)
                {
                    sql = "SELECT * FROM caixa WHERE data>=@dataInicial AND data<=@dataFinal ORDER BY data desc";
                    conn = new MySqlCommand(sql, con.con);
                }
                else
                {
                    sql = "SELECT * FROM caixa WHERE data>=@dataInicial AND data<=@dataFinal AND tipo=@tipo ORDER BY data desc";
                    conn = new MySqlCommand(sql, con.con);
                    conn.Parameters.AddWithValue("@tipo", cb_Tipo.Text);
                }
                conn.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(dt_Inicial.Text));
                conn.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(dt_Final.Text));
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = conn;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();
                FormatarGD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

            }
            else
            {
                return;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Entrada.Text.ToString().Trim() == "" || txt_Entrada.Text == "0" || txt_Entrada.Text == "0,00")
            {
                MessageBox.Show("Preencher o valor da Entrada(+)", " Mensagem ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Entrada.Focus();
                return;
            }
            if (txt_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o campo da Justificativa.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Descricao.Focus();
                return;
            }

            if (cb_FormaPagto.Text == "Dinheiro")
            {
                pagtoD = Convert.ToDouble(txt_Entrada.Text);
                pagtoC = 0;
                pagtoP = 0;
            }
            if (cb_FormaPagto.Text == "Pix")
            {
                pagtoP = Convert.ToDouble(txt_Entrada.Text);
                pagtoC = 0;
                pagtoD = 0;
            }
            if (cb_FormaPagto.Text == "Cartão")
            {
                pagtoC = Convert.ToDouble(txt_Entrada.Text);
                pagtoD = 0;
                pagtoP = 0;
            }
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO caixa(data, historico, forma_pagto, valor, taxa, total, saida, trans_dinheiro, trans_conta, tipo, dinheiro, pix, cartao, funcionario) VALUES(curDate(), @historico, @forma_pagto, @valor, @taxa, @total, @saida,  @trans_dinheiro, @trans_conta, @tipo, @dinheiro, @pix, @cartao, @funcionario)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@historico", txt_Descricao.Text);
                conn.Parameters.AddWithValue("@forma_pagto", cb_FormaPagto.Text);
                conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_Entrada.Text));
                conn.Parameters.AddWithValue("@taxa", Convert.ToDouble(txt_Taxa.Text));
                conn.Parameters.AddWithValue("@total", Convert.ToDouble(txt_Entrada.Text) - Convert.ToDouble(txt_Taxa.Text));
                conn.Parameters.AddWithValue("@saida", 0);
                conn.Parameters.AddWithValue("@trans_dinheiro", 0);
                conn.Parameters.AddWithValue("@trans_conta", 0);
                conn.Parameters.AddWithValue("@tipo", "Entrada");
                conn.Parameters.AddWithValue("@dinheiro", pagtoD);
                conn.Parameters.AddWithValue("@pix", pagtoP);
                conn.Parameters.AddWithValue("@cartao", pagtoC);
                conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.ExecuteNonQuery();
                con.FecharConexao();

                cb_FormaPagto.Enabled = true;
            }
            catch (Exception h)
            {
                MessageBox.Show("Feche o sistema e abra novamente...   " + h);
            }

            LimparCampos();
            BuscarTipo();
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor")
            {
                Listar();
            }
            MessageBox.Show("Lançado com sucesso", "Lançamento");
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            if (txt_Saida.Text.ToString().Trim() == "" || txt_Saida.Text == "0" || txt_Saida.Text == "0,00")
            {
                MessageBox.Show("Preencher campo Saída(-)", " Mensagem ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Saida.Focus();
                return;
            }
            if (text_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o campo descrição !!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_Descricao.Focus();
                return;
            }
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO caixa(data, historico, forma_pagto, valor, taxa, total, saida, trans_dinheiro, trans_conta, tipo, dinheiro, pix, cartao, funcionario) VALUES(curDate(), @historico, @forma_pagto, @valor, @taxa, @total, @saida, @trans_dinheiro, @trans_conta, @tipo, @dinheiro, @pix, @cartao, @funcionario)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@historico", text_Descricao.Text);
                conn.Parameters.AddWithValue("@forma_pagto", "Retirada");
                conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_Saida.Text));
                conn.Parameters.AddWithValue("@taxa", 0);
                conn.Parameters.AddWithValue("@total", 0);
                conn.Parameters.AddWithValue("@saida", Convert.ToDouble(txt_Saida.Text));
                conn.Parameters.AddWithValue("@trans_dinheiro", 0);
                conn.Parameters.AddWithValue("@trans_conta", 0);
                conn.Parameters.AddWithValue("@tipo", "Saída");
                conn.Parameters.AddWithValue("@dinheiro", 0);
                conn.Parameters.AddWithValue("@pix", 0);
                conn.Parameters.AddWithValue("@cartao", 0);
                conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception h)
            {
                MessageBox.Show("Feche o sistema e abra novamente...   " + h);
            }
            LimparCampos();
            BuscarTipo();
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor")
            {
                Listar();
            }
            MessageBox.Show("Lançado com sucesso", "Lançamento");
        }
        private void Totalizando()
        {
            double total = 0;
            double totalD = 0;
            double totalC = 0;
            double totalP = 0;
            double taxa = 0;
            double totalSaida = 0;
            double transfD = 0;
            double transfC = 0;
            //percorrendo cada linha da grid, p/ pegar e somar cada linha do array 'Valor'.
            foreach (DataGridViewRow row in grid.Rows)
            {
                //pegando a celular e somando
                total += Convert.ToDouble(row.Cells["total"].Value);
                totalD += Convert.ToDouble(row.Cells["dinheiro"].Value);
                totalP += Convert.ToDouble(row.Cells["pix"].Value);
                totalC += Convert.ToDouble(row.Cells["cartao"].Value);
                taxa += Convert.ToDouble(row.Cells["taxa"].Value);
                totalSaida += Convert.ToDouble(row.Cells["saida"].Value);
                transfC += Convert.ToDouble(row.Cells["trans_dinheiro"].Value);
                transfD += Convert.ToDouble(row.Cells["trans_conta"].Value);
            }
            lbl_Entrada.Text = Convert.ToDouble(total).ToString("C2");
            lbl_Saida.Text = Convert.ToDouble(totalSaida).ToString("C2");
            lbl_Dinheiro.Text = Convert.ToDouble(totalD).ToString("C2");
            lbl_Pix.Text = Convert.ToDouble(totalP).ToString("C2");
            lbl_Cartao.Text = Convert.ToDouble(totalC).ToString("C2");
            lbl_Taxas.Text = Convert.ToDouble(taxa).ToString("C2");
            lbl_EmContas.Text = string.Format("{0:c2}", (totalC - taxa) + totalP + transfC);// 
            lbl_EmCaixa.Text = string.Format("{0:c2}", (totalD - totalSaida) + transfD);// 
            lbl_Saida.Text = string.Format("{0:c2}", totalSaida);
            lbl_Transferencias.Text = string.Format("{0:c2}", transfD + transfC);
            lbl_Saldo.Text = string.Format("{0:c2}", total - totalSaida);
            lbl_SaldoEmCaixa.Text = string.Format("{0:c2}", (totalD - totalSaida) + transfD);
            lbl_SaldoEmConta.Text = string.Format("{0:c2}", (totalC - taxa) + totalP + transfC);
            lbl_TransRecebidaNoCaixa.Text = string.Format("{0:c2}", transfD);
            lbl_TransRecebidaNaConta.Text = string.Format("{0:c2}", transfC);
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

        private void txt_Entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txt_Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txt_Saida_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txt_Entrada_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Entrada);
        }

        private void txt_Desconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Taxa);
        }

        private void txt_Saida_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Saida);
        }

        private void cb_FormaPagto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FormaPagto.Text == "Cartão")
            {
                MessageBox.Show("Insira o valor cobrado pelo cartão.", "TAXA DA BANDEIRA DO CARTÃO");
                txt_Taxa.Enabled = true;
                txt_Taxa.Focus();
            }
            if (cb_FormaPagto.Text == "Pix")
            {
                txt_Taxa.Enabled = false;
            }
            if (cb_FormaPagto.Text == "Dinheiro")
            {
                txt_Taxa.Enabled = false;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_ParaCaixa.Text = "0";
            txt_ParaConta.Text = "0";
        }

        private void btn_OKCaixa_Click(object sender, EventArgs e)
        {
            if (txt_ParaConta.Text.ToString().Trim() == "" || txt_ParaConta.Text == "0" || txt_ParaConta.Text == "0,00")
            {
                MessageBox.Show("Não foi declarado o valor da conta a ser transferido.", "TRANSFERÊCIA");
                txt_ParaConta.Focus();
                return;
            }
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO caixa(data, historico, forma_pagto, valor, taxa, total, saida, trans_dinheiro, trans_conta, tipo, dinheiro, pix, cartao, funcionario) VALUES(curDate(), @historico, @forma_pagto, @valor, @taxa, @total, @saida, @trans_dinheiro, @trans_conta, @tipo, @dinheiro, @pix, @cartao, @funcionario)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@historico", "Dinheiro p/ Conta");
                conn.Parameters.AddWithValue("@forma_pagto", "Transferência");
                conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_ParaConta.Text));
                conn.Parameters.AddWithValue("@taxa", 0);
                conn.Parameters.AddWithValue("@total", 0);
                conn.Parameters.AddWithValue("@saida", 0);
                conn.Parameters.AddWithValue("@trans_dinheiro", Convert.ToDouble(txt_ParaConta.Text));
                conn.Parameters.AddWithValue("@trans_conta", 0);
                conn.Parameters.AddWithValue("@tipo", "Transferência");
                conn.Parameters.AddWithValue("@dinheiro", Convert.ToDouble(txt_ParaConta.Text) * -1);
                conn.Parameters.AddWithValue("@pix", 0);
                conn.Parameters.AddWithValue("@cartao", 0);
                conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception h)
            {
                MessageBox.Show("Feche o sistema e abra novamente...   " + h);
            }
            txt_ParaConta.Text = "0";
            LimparCampos();
            BuscarTipo();
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor")
            {
                Listar();
            }
            MessageBox.Show("Transferido com sucesso.", "TRANSFERÊCIA");
        }

        private void btn_Conta_Click(object sender, EventArgs e)
        {
            if (txtParaCaixa.Text.ToString().Trim() == "" || txtParaCaixa.Text == "0" || txtParaCaixa.Text == "0,00")
            {
                MessageBox.Show("Não foi declarado o valor do caixa a ser transferido.", "TRANSFERÊCIA");
                txtParaCaixa.Focus();
                return;
            }
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO caixa(data, historico, forma_pagto, valor, taxa, total, saida, trans_dinheiro, trans_conta, tipo, dinheiro, pix, cartao, funcionario) VALUES(curDate(), @historico, @forma_pagto, @valor, @taxa, @total, @saida, @trans_dinheiro, @trans_conta, @tipo, @dinheiro, @pix, @cartao, @funcionario)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@historico", "Conta p/ Dinheiro");
                conn.Parameters.AddWithValue("@forma_pagto", "Transferência");
                conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_ParaConta.Text));
                conn.Parameters.AddWithValue("@taxa", 0);
                conn.Parameters.AddWithValue("@total", 0);
                conn.Parameters.AddWithValue("@saida", 0);
                conn.Parameters.AddWithValue("@trans_dinheiro", 0);
                conn.Parameters.AddWithValue("@trans_conta", Convert.ToDouble(txtParaCaixa.Text));
                conn.Parameters.AddWithValue("@tipo", "Transferência");
                conn.Parameters.AddWithValue("@dinheiro", 0);
                conn.Parameters.AddWithValue("@pix", Convert.ToDouble(txtParaCaixa.Text) * -1);
                conn.Parameters.AddWithValue("@cartao", 0);
                conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception h)
            {
                MessageBox.Show("Feche o sistema e abra novamente...   " + h);//
            }
            txtParaCaixa.Text = "0";
            LimparCampos();
            BuscarTipo();
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor")
            {
                Listar();
            }
            MessageBox.Show("Transferido com sucesso.", "TRANSFERÊCIA");
        }

        private void txt_ParaConta_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_ParaConta);
        }

        private void txt_ParaConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtParaCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txtParaCaixa_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtParaCaixa);
        }

        private void txt_ParaConta_Click(object sender, EventArgs e)
        {
            txtParaCaixa.Text = "0";
        }

        private void txtParaCaixa_Click(object sender, EventArgs e)
        {
            txt_ParaConta.Text = "0";
        }

        private void cb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarTipo();
        }

        private void dt_Inicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarTipo();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            BuscarTipo();
        }
    }
}
