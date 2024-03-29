namespace Moderno.Vendas
{
    partial class Frm_fechar_venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorRecebido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalapagar = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TotalVenda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "F6 - Dinheiro",
            "F5 - Pix",
            "F4 - Cartão Credito",
            "F3 - Cartão Debito ",
            "F2 - Cartão Credito Tef",
            "F1 - Cartão Debito Tef"});
            this.listBox1.Location = new System.Drawing.Point(375, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 244);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_totalapagar);
            this.panel1.Controls.Add(this.txt_desconto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_SubTotal);
            this.panel1.Location = new System.Drawing.Point(39, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 363);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txt_troco);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_valorRecebido);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 63);
            this.panel2.TabIndex = 317;
            // 
            // txt_troco
            // 
            this.txt_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_troco.ForeColor = System.Drawing.Color.Red;
            this.txt_troco.Location = new System.Drawing.Point(540, 20);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.ReadOnly = true;
            this.txt_troco.Size = new System.Drawing.Size(185, 38);
            this.txt_troco.TabIndex = 315;
            this.txt_troco.Text = "0,00";
            this.txt_troco.TextChanged += new System.EventHandler(this.txt_troco_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 313;
            this.label4.Text = "VALOR RECEBIDO:";
            // 
            // txt_valorRecebido
            // 
            this.txt_valorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorRecebido.ForeColor = System.Drawing.Color.Red;
            this.txt_valorRecebido.Location = new System.Drawing.Point(6, 20);
            this.txt_valorRecebido.Name = "txt_valorRecebido";
            this.txt_valorRecebido.ReadOnly = true;
            this.txt_valorRecebido.Size = new System.Drawing.Size(188, 38);
            this.txt_valorRecebido.TabIndex = 314;
            this.txt_valorRecebido.Text = "0,00";
            this.txt_valorRecebido.TextChanged += new System.EventHandler(this.txt_valorRecebido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(537, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 316;
            this.label5.Text = "TROCO:";
            // 
            // txt_totalapagar
            // 
            this.txt_totalapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalapagar.ForeColor = System.Drawing.Color.Red;
            this.txt_totalapagar.Location = new System.Drawing.Point(6, 223);
            this.txt_totalapagar.Name = "txt_totalapagar";
            this.txt_totalapagar.ReadOnly = true;
            this.txt_totalapagar.Size = new System.Drawing.Size(188, 38);
            this.txt_totalapagar.TabIndex = 312;
            this.txt_totalapagar.Text = "0,00";
            this.txt_totalapagar.TextChanged += new System.EventHandler(this.txt_totalapagar_TextChanged);
            // 
            // txt_desconto
            // 
            this.txt_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desconto.ForeColor = System.Drawing.Color.Red;
            this.txt_desconto.Location = new System.Drawing.Point(6, 135);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(188, 38);
            this.txt_desconto.TabIndex = 311;
            this.txt_desconto.Text = "0,00";
            this.txt_desconto.TextChanged += new System.EventHandler(this.txt_desconto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 310;
            this.label2.Text = "TOTAL A PAGAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 307;
            this.label1.Text = "DESCONTO:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(-500, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(581, 68);
            this.textBox1.TabIndex = 305;
            this.textBox1.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-500, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 306;
            this.label3.Text = "TOTAL PAGAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(3, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "SUBTOTAL:";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.ForeColor = System.Drawing.Color.Red;
            this.txt_SubTotal.Location = new System.Drawing.Point(6, 44);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(185, 38);
            this.txt_SubTotal.TabIndex = 7;
            this.txt_SubTotal.Text = "0,00";
            this.txt_SubTotal.TextChanged += new System.EventHandler(this.txt_SubTotal_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(-192, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 31);
            this.label12.TabIndex = 306;
            this.label12.Text = "TOTAL PAGAR";
            // 
            // txt_TotalVenda
            // 
            this.txt_TotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_TotalVenda.Location = new System.Drawing.Point(-192, 467);
            this.txt_TotalVenda.Name = "txt_TotalVenda";
            this.txt_TotalVenda.ReadOnly = true;
            this.txt_TotalVenda.Size = new System.Drawing.Size(581, 68);
            this.txt_TotalVenda.TabIndex = 305;
            this.txt_TotalVenda.Text = "0,00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.lblTituloProdutos);
            this.panel3.Location = new System.Drawing.Point(-2, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 54);
            this.panel3.TabIndex = 307;
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTituloProdutos.Location = new System.Drawing.Point(265, 10);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(285, 26);
            this.lblTituloProdutos.TabIndex = 73;
            this.lblTituloProdutos.Text = "FECHAMENTO DE VENDA";
            // 
            // Frm_fechar_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_TotalVenda);
            this.Name = "Frm_fechar_venda";
            this.Text = "FECHAMENTO DE VENDA";
            this.Load += new System.EventHandler(this.Frm_fechar_venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_fechar_venda_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TotalVenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_totalapagar;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valorRecebido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTituloProdutos;
    }
}