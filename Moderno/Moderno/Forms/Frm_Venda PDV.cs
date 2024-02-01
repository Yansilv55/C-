using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno.Forms
{
    public partial class Frm_Venda_PDV : Form
    {
        public Frm_Venda_PDV()
        {
            InitializeComponent();
            CarregarTheme();
        }

        private void Frm_Venda_PDV_Load(object sender, EventArgs e)
        {

        }

        private void CarregarTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimeiraColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SegundaColor;
                }
            }
            label1.ForeColor = ThemeColor.SegundaColor;
            label2.ForeColor = ThemeColor.PrimeiraColor;
        }
    }
}
