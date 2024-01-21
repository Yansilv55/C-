namespace PDV.cadastro
{
    partial class Frm_funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Nome = new System.Windows.Forms.TextBox();
            this.btn_Endereco = new System.Windows.Forms.TextBox();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Telefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo";
            // 
            // btn_Nome
            // 
            this.btn_Nome.Location = new System.Drawing.Point(54, 20);
            this.btn_Nome.Name = "btn_Nome";
            this.btn_Nome.Size = new System.Drawing.Size(422, 20);
            this.btn_Nome.TabIndex = 6;
            // 
            // btn_Endereco
            // 
            this.btn_Endereco.Location = new System.Drawing.Point(67, 140);
            this.btn_Endereco.Name = "btn_Endereco";
            this.btn_Endereco.Size = new System.Drawing.Size(380, 20);
            this.btn_Endereco.TabIndex = 8;
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Items.AddRange(new object[] {
            "Gerente",
            "Junior",
            "Pleno",
            "Senior"});
            this.cb_Cargo.Location = new System.Drawing.Point(547, 116);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(219, 21);
            this.cb_Cargo.TabIndex = 9;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.Location = new System.Drawing.Point(890, 28);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(243, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 11;
            this.image.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(20, 243);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(1113, 282);
            this.Grid.TabIndex = 12;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(144, 531);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 13;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(260, 531);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(86, 32);
            this.btn_Editar.TabIndex = 14;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(31, 531);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 15;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(1045, 531);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 16;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(838, 28);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(46, 26);
            this.btn_foto.TabIndex = 17;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_Cpf
            // 
            this.btn_Cpf.Location = new System.Drawing.Point(547, 19);
            this.btn_Cpf.Mask = "000.000.000-00";
            this.btn_Cpf.Name = "btn_Cpf";
            this.btn_Cpf.Size = new System.Drawing.Size(88, 20);
            this.btn_Cpf.TabIndex = 18;
            // 
            // btn_Telefone
            // 
            this.btn_Telefone.Location = new System.Drawing.Point(78, 87);
            this.btn_Telefone.Mask = "(99) 0 0000-0000";
            this.btn_Telefone.Name = "btn_Telefone";
            this.btn_Telefone.Size = new System.Drawing.Size(102, 20);
            this.btn_Telefone.TabIndex = 19;
            // 
            // Frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.btn_Telefone);
            this.Controls.Add(this.btn_Cpf);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.image);
            this.Controls.Add(this.cb_Cargo);
            this.Controls.Add(this.btn_Endereco);
            this.Controls.Add(this.btn_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.Frm_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btn_Nome;
        private System.Windows.Forms.TextBox btn_Endereco;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.MaskedTextBox btn_Cpf;
        private System.Windows.Forms.MaskedTextBox btn_Telefone;
    }
}