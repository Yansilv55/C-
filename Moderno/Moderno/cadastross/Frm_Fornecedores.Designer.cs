namespace Moderno.cadastross
{
    partial class Frm_Fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rb_Cpf = new System.Windows.Forms.RadioButton();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb_Cnpj = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Ativado = new System.Windows.Forms.RadioButton();
            this.rb_Inativado = new System.Windows.Forms.RadioButton();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_BuscarCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txt_Vendedor = new System.Windows.Forms.TextBox();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.txt_ValorAberto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Cpf
            // 
            this.rb_Cpf.AutoSize = true;
            this.rb_Cpf.Location = new System.Drawing.Point(62, 3);
            this.rb_Cpf.Name = "rb_Cpf";
            this.rb_Cpf.Size = new System.Drawing.Size(41, 17);
            this.rb_Cpf.TabIndex = 0;
            this.rb_Cpf.TabStop = true;
            this.rb_Cpf.Text = "Cpf";
            this.rb_Cpf.UseVisualStyleBackColor = true;
            this.rb_Cpf.CheckedChanged += new System.EventHandler(this.rb_Cpf_CheckedChanged);
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Location = new System.Drawing.Point(3, 3);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.rb_Nome.TabIndex = 1;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            this.rb_Nome.CheckedChanged += new System.EventHandler(this.rb_Nome_CheckedChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(375, 525);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_Cancelar.TabIndex = 43;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(1042, 525);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 39;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Location = new System.Drawing.Point(12, 525);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 42;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Location = new System.Drawing.Point(257, 525);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(86, 32);
            this.btn_Editar.TabIndex = 41;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Location = new System.Drawing.Point(141, 525);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 40;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Buscar por Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Buscar por Cpf";
            // 
            // txt_BuscarCpf
            // 
            this.txt_BuscarCpf.Location = new System.Drawing.Point(101, 70);
            this.txt_BuscarCpf.Name = "txt_BuscarCpf";
            this.txt_BuscarCpf.Size = new System.Drawing.Size(248, 20);
            this.txt_BuscarCpf.TabIndex = 47;
            // 
            // grid
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(46, 190);
            this.grid.Name = "grid";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.Size = new System.Drawing.Size(879, 238);
            this.grid.TabIndex = 48;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(372, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 49;
            this.Nome.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(419, 16);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(351, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(419, 49);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(100, 20);
            this.txt_Celular.TabIndex = 2;
            this.txt_Celular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cel.";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(101, 135);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(603, 20);
            this.txt_Endereco.TabIndex = 8;
            this.txt_Endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Endereço";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rb_Nome);
            this.flowLayoutPanel1.Controls.Add(this.rb_Cpf);
            this.flowLayoutPanel1.Controls.Add(this.rb_Cnpj);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 27);
            this.flowLayoutPanel1.TabIndex = 57;
            // 
            // rb_Cnpj
            // 
            this.rb_Cnpj.AutoSize = true;
            this.rb_Cnpj.Location = new System.Drawing.Point(109, 3);
            this.rb_Cnpj.Name = "rb_Cnpj";
            this.rb_Cnpj.Size = new System.Drawing.Size(52, 17);
            this.rb_Cnpj.TabIndex = 2;
            this.rb_Cnpj.TabStop = true;
            this.rb_Cnpj.Text = "CNPJ";
            this.rb_Cnpj.UseVisualStyleBackColor = true;
            this.rb_Cnpj.CheckedChanged += new System.EventHandler(this.rb_Cnpj_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Ativado);
            this.groupBox1.Controls.Add(this.rb_Inativado);
            this.groupBox1.Location = new System.Drawing.Point(913, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb_Ativado
            // 
            this.rb_Ativado.AutoSize = true;
            this.rb_Ativado.Location = new System.Drawing.Point(8, 19);
            this.rb_Ativado.Name = "rb_Ativado";
            this.rb_Ativado.Size = new System.Drawing.Size(61, 17);
            this.rb_Ativado.TabIndex = 65;
            this.rb_Ativado.TabStop = true;
            this.rb_Ativado.Text = "Ativado";
            this.rb_Ativado.UseVisualStyleBackColor = true;
            // 
            // rb_Inativado
            // 
            this.rb_Inativado.AutoSize = true;
            this.rb_Inativado.Location = new System.Drawing.Point(8, 42);
            this.rb_Inativado.Name = "rb_Inativado";
            this.rb_Inativado.Size = new System.Drawing.Size(69, 17);
            this.rb_Inativado.TabIndex = 66;
            this.rb_Inativado.TabStop = true;
            this.rb_Inativado.Text = "Inativado";
            this.rb_Inativado.UseVisualStyleBackColor = true;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(419, 79);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Valor Aberto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(719, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Código";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(765, 49);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 6;
            this.txt_Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "CNPJ";
            // 
            // txt_Cnpj
            // 
            this.txt_Cnpj.Location = new System.Drawing.Point(766, 81);
            this.txt_Cnpj.Name = "txt_Cnpj";
            this.txt_Cnpj.Size = new System.Drawing.Size(100, 20);
            this.txt_Cnpj.TabIndex = 7;
            this.txt_Cnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            this.txt_Cnpj.Leave += new System.EventHandler(this.txt_Cnpj_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Buscar por CNPJ";
            // 
            // txt_BuscarCnpj
            // 
            this.txt_BuscarCnpj.Location = new System.Drawing.Point(101, 96);
            this.txt_BuscarCnpj.Name = "txt_BuscarCnpj";
            this.txt_BuscarCnpj.Size = new System.Drawing.Size(248, 20);
            this.txt_BuscarCnpj.TabIndex = 70;
            this.txt_BuscarCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_BuscarCnpj_MaskInputRejected);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(535, 56);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(53, 13);
            this.txt.TabIndex = 71;
            this.txt.Text = "Vendedor";
            // 
            // txt_Vendedor
            // 
            this.txt_Vendedor.Location = new System.Drawing.Point(604, 53);
            this.txt_Vendedor.Name = "txt_Vendedor";
            this.txt_Vendedor.Size = new System.Drawing.Size(100, 20);
            this.txt_Vendedor.TabIndex = 4;
            this.txt_Vendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(101, 42);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(248, 20);
            this.txt_BuscarNome.TabIndex = 73;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // txt_ValorAberto
            // 
            this.txt_ValorAberto.Location = new System.Drawing.Point(604, 88);
            this.txt_ValorAberto.Name = "txt_ValorAberto";
            this.txt_ValorAberto.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorAberto.TabIndex = 5;
            this.txt_ValorAberto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            // 
            // Frm_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.txt_ValorAberto);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.txt_Vendedor);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_BuscarCnpj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Cnpj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txt_BuscarCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Name = "Frm_Fornecedores";
            this.Text = "Frm_Fornecedores";
            this.Load += new System.EventHandler(this.Frm_Fornecedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Fornecedores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Cpf;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_BuscarCpf;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.RadioButton rb_Ativado;
        private System.Windows.Forms.RadioButton rb_Inativado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Cnpj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_BuscarCnpj;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txt_Vendedor;
        private System.Windows.Forms.RadioButton rb_Cnpj;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.TextBox txt_ValorAberto;
    }
}