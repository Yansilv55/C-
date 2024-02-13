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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.llll = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.cb_Ativo = new System.Windows.Forms.CheckBox();
            this.panelBuscar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(43, 190);
            this.grid.Name = "grid";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Size = new System.Drawing.Size(347, 265);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.Location = new System.Drawing.Point(40, 23);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(35, 13);
            this.llll.TabIndex = 1;
            this.llll.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(82, 15);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(82, 59);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 4;
            this.txt_Valor.TextChanged += new System.EventHandler(this.txt_Valor_TextChanged);
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ativo";
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(286, 58);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_Tipo.TabIndex = 7;
            this.cb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cb_Tipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Location = new System.Drawing.Point(12, 525);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 43;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Location = new System.Drawing.Point(143, 525);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 44;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Location = new System.Drawing.Point(262, 525);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(86, 32);
            this.btn_Editar.TabIndex = 45;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(381, 525);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_Cancelar.TabIndex = 46;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(1031, 525);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 47;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // cb_Ativo
            // 
            this.cb_Ativo.AutoSize = true;
            this.cb_Ativo.Location = new System.Drawing.Point(45, 5);
            this.cb_Ativo.Name = "cb_Ativo";
            this.cb_Ativo.Size = new System.Drawing.Size(80, 17);
            this.cb_Ativo.TabIndex = 48;
            this.cb_Ativo.Text = "checkBox1";
            this.cb_Ativo.UseVisualStyleBackColor = true;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.cb_Ativo);
            this.panelBuscar.Controls.Add(this.label2);
            this.panelBuscar.Location = new System.Drawing.Point(241, 12);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(130, 24);
            this.panelBuscar.TabIndex = 49;
            // 
            // Frm_Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.llll);
            this.Controls.Add(this.grid);
            this.Name = "Frm_Servicos";
            this.Text = "Cadastro de Serviços";
            this.Load += new System.EventHandler(this.Frm_Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.CheckBox cb_Ativo;
        private System.Windows.Forms.Panel panelBuscar;
    }
}