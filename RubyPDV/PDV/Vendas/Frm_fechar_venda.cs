using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Moderno.Vendas.Frm_Vendas;

namespace Moderno.Vendas
{
    public partial class Frm_fechar_venda : Form
    {
        public Frm_fechar_venda()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txt_SubTotal.Text = new Venda().sub_total.ToString();
            txt_TotalVenda.Text = new Venda().valor_total.ToString();
        }

        private void Frm_fechar_venda_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_fechar_venda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F6)
            {
                MessageBox.Show("Pagamento no Dinheiro", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void txt_SubTotal_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_SubTotal);
        }

        private void txt_desconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_desconto);
        }

        private void txt_totalapagar_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_totalapagar);
        }

        private void txt_valorRecebido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_valorRecebido);
        }

        private void txt_troco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_troco);
        }
    }
}
