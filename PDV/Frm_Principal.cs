using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Menu_sair_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Realmente Deseja sair?", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Menu_funcionarios_Click(object sender, EventArgs e)
        {
            cadastro.Frm_funcionario frm = new cadastro.Frm_funcionario();
            frm.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro.Frm_Cargo frm = new cadastro.Frm_Cargo();
            frm.ShowDialog();
        }
    }
}
