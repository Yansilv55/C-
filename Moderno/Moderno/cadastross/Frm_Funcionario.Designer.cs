namespace Moderno.cadastross
{
    partial class Frm_Funcionario
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_Celular = new System.Windows.Forms.MaskedTextBox();
            this.lb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.lb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(380, 524);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_Cancelar.TabIndex = 38;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lb_Celular
            // 
            this.lb_Celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Celular.Enabled = false;
            this.lb_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Celular.Location = new System.Drawing.Point(69, 73);
            this.lb_Celular.Mask = "(99) 0 0000-0000";
            this.lb_Celular.Name = "lb_Celular";
            this.lb_Celular.Size = new System.Drawing.Size(102, 16);
            this.lb_Celular.TabIndex = 28;
            // 
            // lb_Cpf
            // 
            this.lb_Cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Cpf.Enabled = false;
            this.lb_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cpf.Location = new System.Drawing.Point(656, 25);
            this.lb_Cpf.Mask = "000.000.000-00";
            this.lb_Cpf.Name = "lb_Cpf";
            this.lb_Cpf.Size = new System.Drawing.Size(88, 16);
            this.lb_Cpf.TabIndex = 27;
            // 
            // btn_foto
            // 
            this.btn_foto.Enabled = false;
            this.btn_foto.ForeColor = System.Drawing.Color.Black;
            this.btn_foto.Location = new System.Drawing.Point(840, 21);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(46, 26);
            this.btn_foto.TabIndex = 31;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(1047, 524);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 34;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Location = new System.Drawing.Point(33, 524);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 37;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Location = new System.Drawing.Point(262, 524);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(86, 32);
            this.btn_Editar.TabIndex = 36;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Location = new System.Drawing.Point(146, 524);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 35;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.Enabled = false;
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Items.AddRange(new object[] {
            "Gerente",
            "Junior",
            "Pleno",
            "Senior"});
            this.cb_Cargo.Location = new System.Drawing.Point(534, 72);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(219, 21);
            this.cb_Cargo.TabIndex = 29;
            // 
            // lb_Endereco
            // 
            this.lb_Endereco.BackColor = System.Drawing.Color.White;
            this.lb_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Endereco.Enabled = false;
            this.lb_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Endereco.Location = new System.Drawing.Point(69, 133);
            this.lb_Endereco.Name = "lb_Endereco";
            this.lb_Endereco.Size = new System.Drawing.Size(684, 16);
            this.lb_Endereco.TabIndex = 30;
            // 
            // lb_Nome
            // 
            this.lb_Nome.BackColor = System.Drawing.Color.White;
            this.lb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Nome.Enabled = false;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(69, 19);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(546, 16);
            this.lb_Nome.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(483, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cel. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(623, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.Enabled = false;
            this.image.Image = global::Moderno.Properties.Resources.icons8_person_32px;
            this.image.Location = new System.Drawing.Point(892, 21);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(243, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 32;
            this.image.TabStop = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid.Location = new System.Drawing.Point(69, 202);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(684, 267);
            this.grid.TabIndex = 52;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick_1);
            // 
            // Frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lb_Celular);
            this.Controls.Add(this.lb_Cpf);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.image);
            this.Controls.Add(this.cb_Cargo);
            this.Controls.Add(this.lb_Endereco);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Funcionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.Frm_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox lb_Celular;
        private System.Windows.Forms.MaskedTextBox lb_Cpf;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.TextBox lb_Endereco;
        private System.Windows.Forms.TextBox lb_Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
    }
}