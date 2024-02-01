﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activiform;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                    /*Panel_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimeiraColor = color;
                    ThemeColor.SegundaColor = ThemeColor.ChangeColorBrightness(color, -0.3); */
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
            //ActivateButton(sender);
            AbrirFrmPrincipal(new Forms.Frm_Venda_PDV(), sender);
        }

        private void button_Receber_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            AbrirFrmPrincipal(new Forms.Frm_Receber(), sender);
        }

        private void btn_Movimentacoes_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            AbrirFrmPrincipal(new Forms.Frm_Movimentacoes(), sender);
        }

        private void btn_Lancar_Despesas_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
        }

        private void btn_Fluxo_Caixa_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
        }
    }
}
