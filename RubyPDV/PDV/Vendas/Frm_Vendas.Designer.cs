namespace Moderno.Vendas
{
    partial class Frm_Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CodProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.gridDetalhes = new System.Windows.Forms.DataGridView();
            this.panelLancamento = new System.Windows.Forms.Panel();
            this.txt_ValorUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TotalVenda = new System.Windows.Forms.TextBox();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelVenda = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalhes)).BeginInit();
            this.panelLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 248;
            this.label2.Text = "PRODUTO";
            // 
            // txt_CodProduto
            // 
            this.txt_CodProduto.AutoCompleteCustomSource.AddRange(new string[] {
            "Acre",
            "Bahia",
            "Ceara",
            "Minas"});
            this.txt_CodProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_CodProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CodProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodProduto.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodProduto.Location = new System.Drawing.Point(19, 68);
            this.txt_CodProduto.Name = "txt_CodProduto";
            this.txt_CodProduto.Size = new System.Drawing.Size(403, 38);
            this.txt_CodProduto.TabIndex = 1;
            this.txt_CodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CodProduto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(425, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 242;
            this.label4.Text = "QUANTIDADE";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Quantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(428, 68);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(85, 38);
            this.txt_Quantidade.TabIndex = 3;
            this.txt_Quantidade.Text = "1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.btnExcluirItem);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.lblNota);
            this.panel5.Location = new System.Drawing.Point(1, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(807, 34);
            this.panel5.TabIndex = 191;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirItem.Enabled = false;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirItem.Location = new System.Drawing.Point(412, 3);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(147, 24);
            this.btnExcluirItem.TabIndex = 303;
            this.btnExcluirItem.Text = "EXCLUIR ITEM";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(37, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 16);
            this.label22.TabIndex = 303;
            this.label22.Text = "RECIBO N.:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.Black;
            this.lblNota.Location = new System.Drawing.Point(125, 8);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(15, 16);
            this.lblNota.TabIndex = 302;
            this.lblNota.Text = "0";
            // 
            // gridDetalhes
            // 
            this.gridDetalhes.AllowUserToAddRows = false;
            this.gridDetalhes.AllowUserToDeleteRows = false;
            this.gridDetalhes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDetalhes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDetalhes.BackgroundColor = System.Drawing.Color.White;
            this.gridDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetalhes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalhes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetalhes.ColumnHeadersHeight = 30;
            this.gridDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalhes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetalhes.EnableHeadersVisualStyles = false;
            this.gridDetalhes.GridColor = System.Drawing.Color.White;
            this.gridDetalhes.Location = new System.Drawing.Point(1, 108);
            this.gridDetalhes.Name = "gridDetalhes";
            this.gridDetalhes.ReadOnly = true;
            this.gridDetalhes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalhes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetalhes.RowHeadersVisible = false;
            this.gridDetalhes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridDetalhes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalhes.Size = new System.Drawing.Size(804, 477);
            this.gridDetalhes.TabIndex = 194;
            // 
            // panelLancamento
            // 
            this.panelLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.panelLancamento.Controls.Add(this.txt_CodProduto);
            this.panelLancamento.Controls.Add(this.label2);
            this.panelLancamento.Controls.Add(this.txt_Quantidade);
            this.panelLancamento.Controls.Add(this.label4);
            this.panelLancamento.Controls.Add(this.txt_ValorUnitario);
            this.panelLancamento.Controls.Add(this.label9);
            this.panelLancamento.Controls.Add(this.txt_SubTotal);
            this.panelLancamento.Controls.Add(this.label11);
            this.panelLancamento.Location = new System.Drawing.Point(805, 75);
            this.panelLancamento.Name = "panelLancamento";
            this.panelLancamento.Size = new System.Drawing.Size(537, 510);
            this.panelLancamento.TabIndex = 304;
            // 
            // txt_ValorUnitario
            // 
            this.txt_ValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorUnitario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_ValorUnitario.Location = new System.Drawing.Point(19, 154);
            this.txt_ValorUnitario.Name = "txt_ValorUnitario";
            this.txt_ValorUnitario.ReadOnly = true;
            this.txt_ValorUnitario.Size = new System.Drawing.Size(240, 38);
            this.txt_ValorUnitario.TabIndex = 4;
            this.txt_ValorUnitario.Text = "0,00";
            this.txt_ValorUnitario.TextChanged += new System.EventHandler(this.txt_ValorUnitario_TextChanged);
            this.txt_ValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorUnitario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(16, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "VALOR UNITÁRIO";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.ForeColor = System.Drawing.Color.Red;
            this.txt_SubTotal.Location = new System.Drawing.Point(265, 154);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(248, 38);
            this.txt_SubTotal.TabIndex = 7;
            this.txt_SubTotal.Text = "0,00";
            this.txt_SubTotal.TextChanged += new System.EventHandler(this.txt_SubTotal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(262, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "SUBTOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(12, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "TOTAL PAGAR";
            // 
            // txt_TotalVenda
            // 
            this.txt_TotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_TotalVenda.Location = new System.Drawing.Point(9, 652);
            this.txt_TotalVenda.Name = "txt_TotalVenda";
            this.txt_TotalVenda.ReadOnly = true;
            this.txt_TotalVenda.Size = new System.Drawing.Size(796, 68);
            this.txt_TotalVenda.TabIndex = 11;
            this.txt_TotalVenda.Text = "0,00";
            this.txt_TotalVenda.TextChanged += new System.EventHandler(this.txt_TotalVenda_TextChanged);
            this.txt_TotalVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TotalVenda_KeyDown);
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTituloProdutos.Location = new System.Drawing.Point(12, 21);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(341, 26);
            this.lblTituloProdutos.TabIndex = 252;
            this.lblTituloProdutos.Text = "GERENCIAMENTO DE VENDAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Moderno.Properties.Resources._0_7asj1rKS8d2mead_;
            this.pictureBox1.Location = new System.Drawing.Point(1269, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 249;
            this.pictureBox1.TabStop = false;
            // 
            // panelVenda
            // 
            this.panelVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelVenda.Controls.Add(this.pictureBox1);
            this.panelVenda.Controls.Add(this.lblTituloProdutos);
            this.panelVenda.Location = new System.Drawing.Point(1, 1);
            this.panelVenda.Name = "panelVenda";
            this.panelVenda.Size = new System.Drawing.Size(1344, 71);
            this.panelVenda.TabIndex = 189;
            // 
            // Frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1345, 732);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelLancamento);
            this.Controls.Add(this.gridDetalhes);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_TotalVenda);
            this.Controls.Add(this.panelVenda);
            this.Name = "Frm_Vendas";
            this.Text = "Frm_Vendas";
            this.Load += new System.EventHandler(this.Frm_Vendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Vendas_KeyDown);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalhes)).EndInit();
            this.panelLancamento.ResumeLayout(false);
            this.panelLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelVenda.ResumeLayout(false);
            this.panelVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.DataGridView gridDetalhes;
        private System.Windows.Forms.Panel panelLancamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ValorUnitario;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelVenda;
    }
}