using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcmedia
{
    public partial class Form1 : Form
    {
        private List<Media> list_medias = new  List<Media>();
        private float media = 0;

        public Form1()
        {
            InitializeComponent();
            Configura_grid(null);
        }

        private void Configura_grid(Media medias)
        {
            if (medias == null)
            {
                dataGridView2.DataSource = null;
            }
            else
            {
                list_medias.Add(medias);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = list_medias;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TodosCamposPreenchidos())
            {
                float soma, valor;
                soma = 0;

                foreach (Control controle in this.tab_calculo.Controls)
                {
                    if ((controle is TextBox) && (controle.Enabled == true))
                    {
                        valor = Convert.ToSingle(((TextBox)controle).Text);
                        soma += valor;
                    }
                }

                media = soma / float.Parse(ctl_quant_notas.Text);
                lbl_resultado_media.Text = media.ToString();

                if (Grava_info() == true)
                {
                    MessageBox.Show("Dados salvos com sucesso!", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de calcular a média.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TodosCamposPreenchidos()
        {
            foreach (Control controle in this.tab_calculo.Controls)
            {
                if ((controle is TextBox) && (controle.Enabled == true))
                {
                    if (string.IsNullOrEmpty(((TextBox)controle).Text))
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            foreach (Control controle in this.tab_calculo.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";                            
                }
                this.tab_calculo.Controls["lbl_resultado_media"].Text = "...";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctl_nota_1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (ctl_nota_1.Text != ""))
            {
                ctl_nota_2.Focus();
            }
        }

        private void ctl_nota_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ctl_nota_3.Enabled)
                {
                ctl_nota_3.Focus();
                }
                else
                {
                    btn_calcular.Focus();
                }
            }
        }

        private void ctl_nota_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(ctl_nota_4.Enabled)
                {
                    ctl_nota_4.Focus();
                }
                else
                {
                    btn_calcular.Focus();
                }
            }
        }

        private void ctl_nota_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_calcular.Focus();
            }
        }

        private bool Grava_info()
        {
            Media medias = new Media();
            medias.media = media;
            medias.nota_1 = float.Parse(ctl_nota_1.Text);
            medias.nota_2 = float.Parse(ctl_nota_2.Text);
            medias.nota_3 = ctl_nota_3.Enabled ? float.Parse(ctl_nota_3.Text) : 0;
            medias.nota_4 = ctl_nota_4.Enabled ? float.Parse(ctl_nota_4.Text) : 0;
            if(medias != null)
            {
                Configura_grid(medias);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ctl_nota_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctl_nota_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctl_nota_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctl_nota_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctl_quant_notas_Leave(object sender, EventArgs e)
        {
            switch (ctl_quant_notas.Text)
            {
                case "2":
                    ctl_nota_1.Enabled = true;
                    ctl_nota_2.Enabled = true;
                    ctl_nota_3.Enabled = false;
                    ctl_nota_4.Enabled = false;
                    break;
                case "3":
                    ctl_nota_1.Enabled = true;
                    ctl_nota_2.Enabled = true;
                    ctl_nota_3.Enabled = true;
                    ctl_nota_4.Enabled = false;
                    break;
                case "4":
                    ctl_nota_1.Enabled = true;
                    ctl_nota_2.Enabled = true;
                    ctl_nota_3.Enabled = true;
                    ctl_nota_4.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Quantidade invalida. Favor informar números de 2 a 4.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ctl_quant_notas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctl_nota_1.Focus();
            }
        }
    }
}
