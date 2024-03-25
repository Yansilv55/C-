using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno.Vendas
{
    public partial class Frm_fechar_venda : Form
    {
        public Frm_fechar_venda()
        {
            InitializeComponent();
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
    }
}
