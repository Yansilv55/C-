﻿using MODEL;
using Moderno.Movimentacoes;
using Moderno.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno
{
    public partial class Frm_Principal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activiform;

        public Frm_Principal()
        {
            InitializeComponent();
            random = new Random();
            btn_Sair.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Wmsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Panel_Title.BackColor = color;
                    Panel_Logo.BackColor = color;
                    btn_Sair.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control priviousBtn in Panel_Menu.Controls)
            {
                if (priviousBtn.GetType() == typeof(Button))
                {
                    priviousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    priviousBtn.ForeColor = Color.Gainsboro;
                    priviousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void AbrirFrmPrincipal(Form abrirForm, object btnSender)
        {
            if (activiform != null)
            {
                activiform.Close();
            }

            ActivateButton(btnSender as Button);
            activiform = abrirForm;
            abrirForm.TopLevel = false;
            abrirForm.FormBorderStyle = FormBorderStyle.None;
            abrirForm.Dock = DockStyle.Fill;
            Panel_Desktop.Controls.Add(abrirForm);
            Panel_Desktop.Tag = abrirForm;
            abrirForm.BringToFront();
            abrirForm.Show();
            lb_Home.Text = abrirForm.Text;
        }

        private void btn_Venda_PDV_Click(object sender, EventArgs e)
        {
            AbrirFrmPrincipal(new Vendas.Frm_Vendas(), sender);
        }

        private void button_Receber_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            AbrirFrmPrincipal(new cadastross.Frm_Clinte(), sender);
        }

        private void btn_Movimentacoes_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            AbrirFrmPrincipal(new cadastross.Frm_Funcionario(), sender);
        }

        private void btn_Lancar_Despesas_Click(object sender, EventArgs e)
        {
            AbrirFrmPrincipal(new cadastross.Frm_Usuario(), sender);
        }

        private void btn_Fluxo_Caixa_Click(object sender, EventArgs e)
        {
            AbrirFrmPrincipal(new Movimentacoes.Frm_Caixa(), sender);
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            AbrirFrmPrincipal(new Movimentacoes.Frm_gastos(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activiform != null)
            {
                activiform.Close();
            }

            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lb_Home.Text = "Home";
            Panel_Title.BackColor = Color.FromArgb(36, 37, 66);
            Panel_Logo.BackColor = Color.FromArgb(36, 37, 66);
            currentButton = null;
            btn_Sair.Visible = false;
        }

        private void Panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Realmente Deseja sair?", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
            Application.Exit();
            }
        }

        private void btn_Maxmizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Status_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Status_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.Frm_Caixa frm = new Frm_Caixa();
            frm.ShowDialog();
        }
        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.Frm_gastos frm = new Frm_gastos();
            frm.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Funcionario frm = new cadastross.Frm_Funcionario();
            frm.ShowDialog();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Clinte frm = new cadastross.Frm_Clinte();
            frm.ShowDialog();
        }
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Cargo frm = new cadastross.Frm_Cargo();
            frm.ShowDialog();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Usuario frm = new cadastross.Frm_Usuario();
            frm.ShowDialog();
        }
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Fornecedores frm = new cadastross.Frm_Fornecedores();
            frm.ShowDialog();
        }
        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Servicos frm = new cadastross.Frm_Servicos();
            frm.ShowDialog();
        }
        private void Frm_Pdv_Moderno_Load(object sender, EventArgs e)
        {
            Status_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Status_Hora.Text = DateTime.Now.ToString("HH:mm:ss");

            lbl_Usuario.Text = UTEIS.NomeUsuario;
            lbl_Cargo.Text = UTEIS.CargoUsuario;
        }
        private void cadastrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produtos.Frm_Produtos frm = new Produtos.Frm_Produtos();
            frm.ShowDialog();
        }
    }
}
