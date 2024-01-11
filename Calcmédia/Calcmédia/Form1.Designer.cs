namespace Calcmedia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_resultado_media = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_calculo = new System.Windows.Forms.TabPage();
            this.ctl_quant_notas = new System.Windows.Forms.ComboBox();
            this.ctl_nota_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctl_nota_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctl_nota_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctl_nota_1 = new System.Windows.Forms.TextBox();
            this.tab_historico = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_calculo.SuspendLayout();
            this.tab_historico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculador de Média";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(468, 323);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(103, 32);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "A média do aluno é:";
            // 
            // lbl_resultado_media
            // 
            this.lbl_resultado_media.AutoSize = true;
            this.lbl_resultado_media.Location = new System.Drawing.Point(465, 140);
            this.lbl_resultado_media.Name = "lbl_resultado_media";
            this.lbl_resultado_media.Size = new System.Drawing.Size(16, 13);
            this.lbl_resultado_media.TabIndex = 12;
            this.lbl_resultado_media.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_calculo);
            this.tabControl1.Controls.Add(this.tab_historico);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_calculo
            // 
            this.tab_calculo.Controls.Add(this.ctl_quant_notas);
            this.tab_calculo.Controls.Add(this.ctl_nota_2);
            this.tab_calculo.Controls.Add(this.lbl_resultado_media);
            this.tab_calculo.Controls.Add(this.label6);
            this.tab_calculo.Controls.Add(this.label4);
            this.tab_calculo.Controls.Add(this.label1);
            this.tab_calculo.Controls.Add(this.ctl_nota_4);
            this.tab_calculo.Controls.Add(this.btn_calcular);
            this.tab_calculo.Controls.Add(this.label5);
            this.tab_calculo.Controls.Add(this.label2);
            this.tab_calculo.Controls.Add(this.ctl_nota_3);
            this.tab_calculo.Controls.Add(this.button2);
            this.tab_calculo.Controls.Add(this.label3);
            this.tab_calculo.Controls.Add(this.ctl_nota_1);
            this.tab_calculo.Location = new System.Drawing.Point(4, 22);
            this.tab_calculo.Name = "tab_calculo";
            this.tab_calculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_calculo.Size = new System.Drawing.Size(588, 370);
            this.tab_calculo.TabIndex = 0;
            this.tab_calculo.Text = "Calculo";
            this.tab_calculo.UseVisualStyleBackColor = true;
            // 
            // ctl_quant_notas
            // 
            this.ctl_quant_notas.FormattingEnabled = true;
            this.ctl_quant_notas.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.ctl_quant_notas.Location = new System.Drawing.Point(62, 52);
            this.ctl_quant_notas.Name = "ctl_quant_notas";
            this.ctl_quant_notas.Size = new System.Drawing.Size(45, 21);
            this.ctl_quant_notas.TabIndex = 13;
            this.ctl_quant_notas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctl_quant_notas_KeyDown);
            this.ctl_quant_notas.Leave += new System.EventHandler(this.ctl_quant_notas_Leave);
            // 
            // ctl_nota_2
            // 
            this.ctl_nota_2.Location = new System.Drawing.Point(62, 121);
            this.ctl_nota_2.Name = "ctl_nota_2";
            this.ctl_nota_2.Size = new System.Drawing.Size(100, 20);
            this.ctl_nota_2.TabIndex = 3;
            this.ctl_nota_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctl_nota_2_KeyDown);
            this.ctl_nota_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctl_nota_2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 3";
            // 
            // ctl_nota_4
            // 
            this.ctl_nota_4.Location = new System.Drawing.Point(62, 185);
            this.ctl_nota_4.Name = "ctl_nota_4";
            this.ctl_nota_4.Size = new System.Drawing.Size(100, 20);
            this.ctl_nota_4.TabIndex = 5;
            this.ctl_nota_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctl_nota_4_KeyDown);
            this.ctl_nota_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctl_nota_4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota1";
            // 
            // ctl_nota_3
            // 
            this.ctl_nota_3.Location = new System.Drawing.Point(62, 152);
            this.ctl_nota_3.Name = "ctl_nota_3";
            this.ctl_nota_3.Size = new System.Drawing.Size(100, 20);
            this.ctl_nota_3.TabIndex = 4;
            this.ctl_nota_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctl_nota_3_KeyDown);
            this.ctl_nota_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctl_nota_3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 2";
            // 
            // ctl_nota_1
            // 
            this.ctl_nota_1.Location = new System.Drawing.Point(62, 91);
            this.ctl_nota_1.Name = "ctl_nota_1";
            this.ctl_nota_1.Size = new System.Drawing.Size(100, 20);
            this.ctl_nota_1.TabIndex = 2;
            this.ctl_nota_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctl_nota_1_KeyDown);
            this.ctl_nota_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctl_nota_1_KeyPress);
            // 
            // tab_historico
            // 
            this.tab_historico.Controls.Add(this.dataGridView2);
            this.tab_historico.Location = new System.Drawing.Point(4, 22);
            this.tab_historico.Name = "tab_historico";
            this.tab_historico.Padding = new System.Windows.Forms.Padding(3);
            this.tab_historico.Size = new System.Drawing.Size(588, 370);
            this.tab_historico.TabIndex = 1;
            this.tab_historico.Text = "Historico";
            this.tab_historico.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(585, 367);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 440);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Calcula Média";
            this.tabControl1.ResumeLayout(false);
            this.tab_calculo.ResumeLayout(false);
            this.tab_calculo.PerformLayout();
            this.tab_historico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_resultado_media;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_calculo;
        private System.Windows.Forms.TabPage tab_historico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctl_nota_4;
        private System.Windows.Forms.TextBox ctl_nota_3;
        private System.Windows.Forms.TextBox ctl_nota_1;
        private System.Windows.Forms.TextBox ctl_nota_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox ctl_quant_notas;
    }
}

