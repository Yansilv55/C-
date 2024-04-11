namespace Moderno.cadastross
{
    partial class Frm_Servicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.llll = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(43, 190);
            this.grid.Name = "grid";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.Size = new System.Drawing.Size(358, 265);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.Location = new System.Drawing.Point(21, 67);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(35, 13);
            this.llll.TabIndex = 1;
            this.llll.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(62, 64);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(396, 20);
            this.txt_Nome.TabIndex = 2;
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(546, 64);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 4;
            this.txt_Valor.TextChanged += new System.EventHandler(this.txt_Valor_TextChanged);
            this.txt_Valor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Valor_KeyDown);
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Image = global::Moderno.Properties.Resources.icons8_trash_can_26px;
            this.btn_Excluir.Location = new System.Drawing.Point(43, 486);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 43;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Image = global::Moderno.Properties.Resources.icons8_Plus_30px1;
            this.btn_Novo.Location = new System.Drawing.Point(153, 486);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(51, 32);
            this.btn_Novo.TabIndex = 44;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Image = global::Moderno.Properties.Resources.icons8_edit_property_24px;
            this.btn_Editar.Location = new System.Drawing.Point(251, 486);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(38, 32);
            this.btn_Editar.TabIndex = 45;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::Moderno.Properties.Resources.icons8_multiply_26px;
            this.btn_Cancelar.Location = new System.Drawing.Point(336, 486);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(45, 32);
            this.btn_Cancelar.TabIndex = 46;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Image = global::Moderno.Properties.Resources.icons8_save_26px1;
            this.btn_Salvar.Location = new System.Drawing.Point(429, 486);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(41, 32);
            this.btn_Salvar.TabIndex = 47;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBusca.Controls.Add(this.lblTitulo);
            this.panelBusca.Location = new System.Drawing.Point(-4, 2);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(1148, 50);
            this.panelBusca.TabIndex = 180;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 26);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "CADASTRO DE SERVIÇO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(59, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 181;
            this.label8.Text = "Excluir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(163, 535);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 182;
            this.label11.Text = "Novo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(248, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 183;
            this.label9.Text = "Editar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(325, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 184;
            this.label10.Text = "Cancelar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(426, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 185;
            this.label7.Text = "Salvar";
            // 
            // Frm_Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(660, 569);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelBusca);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.llll);
            this.Controls.Add(this.grid);
            this.Name = "Frm_Servicos";
            this.Text = "Cadastro de Serviços";
            this.Load += new System.EventHandler(this.Frm_Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}