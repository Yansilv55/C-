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
            this.label6 = new System.Windows.Forms.Label();
            this.text_Nome = new System.Windows.Forms.TextBox();
            this.text_Telefone = new System.Windows.Forms.TextBox();
            this.text_Endereço = new System.Windows.Forms.TextBox();
            this.Cb_Cargo = new System.Windows.Forms.ComboBox();
            this.text_Cpf = new System.Windows.Forms.TextBox();
            this.Pic_Foto = new System.Windows.Forms.PictureBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).BeginInit();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto";
            // 
            // text_Nome
            // 
            this.text_Nome.Location = new System.Drawing.Point(54, 20);
            this.text_Nome.Name = "text_Nome";
            this.text_Nome.Size = new System.Drawing.Size(422, 20);
            this.text_Nome.TabIndex = 6;
            // 
            // text_Telefone
            // 
            this.text_Telefone.Location = new System.Drawing.Point(67, 84);
            this.text_Telefone.Name = "text_Telefone";
            this.text_Telefone.Size = new System.Drawing.Size(100, 20);
            this.text_Telefone.TabIndex = 7;
            this.text_Telefone.TextChanged += new System.EventHandler(this.text_Telefone_TextChanged);
            // 
            // text_Endereço
            // 
            this.text_Endereço.Location = new System.Drawing.Point(67, 140);
            this.text_Endereço.Name = "text_Endereço";
            this.text_Endereço.Size = new System.Drawing.Size(380, 20);
            this.text_Endereço.TabIndex = 8;
            // 
            // Cb_Cargo
            // 
            this.Cb_Cargo.FormattingEnabled = true;
            this.Cb_Cargo.Items.AddRange(new object[] {
            "Gerente",
            "Junior",
            "Pleno",
            "Senior"});
            this.Cb_Cargo.Location = new System.Drawing.Point(547, 116);
            this.Cb_Cargo.Name = "Cb_Cargo";
            this.Cb_Cargo.Size = new System.Drawing.Size(219, 21);
            this.Cb_Cargo.TabIndex = 9;
            // 
            // text_Cpf
            // 
            this.text_Cpf.Location = new System.Drawing.Point(539, 21);
            this.text_Cpf.Name = "text_Cpf";
            this.text_Cpf.Size = new System.Drawing.Size(284, 20);
            this.text_Cpf.TabIndex = 10;
            // 
            // Pic_Foto
            // 
            this.Pic_Foto.Location = new System.Drawing.Point(890, 28);
            this.Pic_Foto.Name = "Pic_Foto";
            this.Pic_Foto.Size = new System.Drawing.Size(211, 175);
            this.Pic_Foto.TabIndex = 11;
            this.Pic_Foto.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(20, 209);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(1081, 305);
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
            this.btn_Salvar.Location = new System.Drawing.Point(997, 531);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 16;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 575);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Pic_Foto);
            this.Controls.Add(this.text_Cpf);
            this.Controls.Add(this.Cb_Cargo);
            this.Controls.Add(this.text_Endereço);
            this.Controls.Add(this.text_Telefone);
            this.Controls.Add(this.text_Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Nome;
        private System.Windows.Forms.TextBox text_Telefone;
        private System.Windows.Forms.TextBox text_Endereço;
        private System.Windows.Forms.ComboBox Cb_Cargo;
        private System.Windows.Forms.TextBox text_Cpf;
        private System.Windows.Forms.PictureBox Pic_Foto;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
    }
}