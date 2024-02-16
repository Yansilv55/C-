namespace Moderno.cadastross
{
    partial class Frm_Clinte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_BuscarNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_BuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Inadiplente = new System.Windows.Forms.ComboBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_ValorAberto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_Email = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.rbAtivado = new System.Windows.Forms.GroupBox();
            this.rb_Inativado = new System.Windows.Forms.RadioButton();
            this.rb_Ativado = new System.Windows.Forms.RadioButton();
            this.rb_Cpf = new System.Windows.Forms.RadioButton();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.rbAtivado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_BuscarNome
            // 
            this.lb_BuscarNome.Enabled = false;
            this.lb_BuscarNome.Location = new System.Drawing.Point(110, 18);
            this.lb_BuscarNome.Name = "lb_BuscarNome";
            this.lb_BuscarNome.Size = new System.Drawing.Size(244, 20);
            this.lb_BuscarNome.TabIndex = 81;
            this.lb_BuscarNome.TextChanged += new System.EventHandler(this.lb_BuscarNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Buscar por Nome";
            // 
            // lb_BuscarCpf
            // 
            this.lb_BuscarCpf.Enabled = false;
            this.lb_BuscarCpf.Location = new System.Drawing.Point(458, 18);
            this.lb_BuscarCpf.Mask = "000.000.000-00";
            this.lb_BuscarCpf.Name = "lb_BuscarCpf";
            this.lb_BuscarCpf.Size = new System.Drawing.Size(88, 20);
            this.lb_BuscarCpf.TabIndex = 79;
            this.lb_BuscarCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.lb_BuscarCpf_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Menu;
            this.label10.Location = new System.Drawing.Point(360, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Buscar por CPF";
            // 
            // cb_Inadiplente
            // 
            this.cb_Inadiplente.FormattingEnabled = true;
            this.cb_Inadiplente.ItemHeight = 13;
            this.cb_Inadiplente.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_Inadiplente.Location = new System.Drawing.Point(886, 97);
            this.cb_Inadiplente.Name = "cb_Inadiplente";
            this.cb_Inadiplente.Size = new System.Drawing.Size(102, 21);
            this.cb_Inadiplente.TabIndex = 8;
            this.cb_Inadiplente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            this.cb_Inadiplente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Inadiplente_KeyPress);
            // 
            // btn_foto
            // 
            this.btn_foto.Enabled = false;
            this.btn_foto.ForeColor = System.Drawing.Color.Black;
            this.btn_foto.Location = new System.Drawing.Point(1277, 189);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(46, 26);
            this.btn_foto.TabIndex = 9;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            this.btn_foto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // lb_Email
            // 
            this.lb_Email.Enabled = false;
            this.lb_Email.Location = new System.Drawing.Point(66, 97);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(650, 20);
            this.lb_Email.TabIndex = 3;
            this.lb_Email.TextChanged += new System.EventHandler(this.lb_Email_TextChanged);
            this.lb_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Email";
            // 
            // lb_ValorAberto
            // 
            this.lb_ValorAberto.Enabled = false;
            this.lb_ValorAberto.Location = new System.Drawing.Point(886, 71);
            this.lb_ValorAberto.Name = "lb_ValorAberto";
            this.lb_ValorAberto.Size = new System.Drawing.Size(102, 20);
            this.lb_ValorAberto.TabIndex = 7;
            this.lb_ValorAberto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            this.lb_ValorAberto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_ValorAberto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(815, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Valor Aberto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(827, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Inadiplete";
            // 
            // lb_codigo
            // 
            this.lb_codigo.Enabled = false;
            this.lb_codigo.Location = new System.Drawing.Point(598, 45);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(118, 20);
            this.lb_codigo.TabIndex = 4;
            this.lb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(552, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Código";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(377, 539);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_Cancelar.TabIndex = 67;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.Enabled = false;
            this.lb_Telefone.Location = new System.Drawing.Point(886, 45);
            this.lb_Telefone.Mask = "(99) 0 0000-0000";
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(102, 20);
            this.lb_Telefone.TabIndex = 6;
            this.lb_Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // lb_Cpf
            // 
            this.lb_Cpf.Enabled = false;
            this.lb_Cpf.Location = new System.Drawing.Point(755, 46);
            this.lb_Cpf.Mask = "000.000.000-00";
            this.lb_Cpf.Name = "lb_Cpf";
            this.lb_Cpf.Size = new System.Drawing.Size(88, 20);
            this.lb_Cpf.TabIndex = 5;
            this.lb_Cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(1484, 539);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(88, 32);
            this.btn_Salvar.TabIndex = 63;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Location = new System.Drawing.Point(30, 539);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(91, 32);
            this.btn_Excluir.TabIndex = 66;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Location = new System.Drawing.Point(259, 539);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(86, 32);
            this.btn_Editar.TabIndex = 65;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Location = new System.Drawing.Point(143, 539);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 64;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Location = new System.Drawing.Point(17, 221);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1558, 273);
            this.grid.TabIndex = 62;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // lb_Endereco
            // 
            this.lb_Endereco.Enabled = false;
            this.lb_Endereco.Location = new System.Drawing.Point(66, 71);
            this.lb_Endereco.Name = "lb_Endereco";
            this.lb_Endereco.Size = new System.Drawing.Size(650, 20);
            this.lb_Endereco.TabIndex = 2;
            this.lb_Endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // lb_Nome
            // 
            this.lb_Nome.Enabled = false;
            this.lb_Nome.Location = new System.Drawing.Point(66, 45);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(480, 20);
            this.lb_Nome.TabIndex = 1;
            this.lb_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(849, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tel. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(722, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome";
            // 
            // img_Email
            // 
            this.img_Email.Image = global::Moderno.Properties.Resources.icons8_secure_24px;
            this.img_Email.Location = new System.Drawing.Point(722, 97);
            this.img_Email.Name = "img_Email";
            this.img_Email.Size = new System.Drawing.Size(27, 31);
            this.img_Email.TabIndex = 82;
            this.img_Email.TabStop = false;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.Enabled = false;
            this.image.Image = global::Moderno.Properties.Resources.icons8_person_32px1;
            this.image.Location = new System.Drawing.Point(1329, 25);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(243, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 75;
            this.image.TabStop = false;
            // 
            // rbAtivado
            // 
            this.rbAtivado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rbAtivado.Controls.Add(this.rb_Inativado);
            this.rbAtivado.Controls.Add(this.rb_Ativado);
            this.rbAtivado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAtivado.ForeColor = System.Drawing.Color.White;
            this.rbAtivado.Location = new System.Drawing.Point(994, 43);
            this.rbAtivado.Name = "rbAtivado";
            this.rbAtivado.Size = new System.Drawing.Size(169, 75);
            this.rbAtivado.TabIndex = 173;
            this.rbAtivado.TabStop = false;
            this.rbAtivado.Text = "Status do cliente?";
            // 
            // rb_Inativado
            // 
            this.rb_Inativado.AutoSize = true;
            this.rb_Inativado.Location = new System.Drawing.Point(6, 42);
            this.rb_Inativado.Name = "rb_Inativado";
            this.rb_Inativado.Size = new System.Drawing.Size(69, 17);
            this.rb_Inativado.TabIndex = 175;
            this.rb_Inativado.TabStop = true;
            this.rb_Inativado.Text = "Inativado";
            this.rb_Inativado.UseVisualStyleBackColor = true;
            // 
            // rb_Ativado
            // 
            this.rb_Ativado.AutoSize = true;
            this.rb_Ativado.Location = new System.Drawing.Point(6, 19);
            this.rb_Ativado.Name = "rb_Ativado";
            this.rb_Ativado.Size = new System.Drawing.Size(61, 17);
            this.rb_Ativado.TabIndex = 174;
            this.rb_Ativado.TabStop = true;
            this.rb_Ativado.Text = "Ativado";
            this.rb_Ativado.UseVisualStyleBackColor = true;
            // 
            // rb_Cpf
            // 
            this.rb_Cpf.AutoSize = true;
            this.rb_Cpf.Location = new System.Drawing.Point(6, 3);
            this.rb_Cpf.Name = "rb_Cpf";
            this.rb_Cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_Cpf.TabIndex = 174;
            this.rb_Cpf.TabStop = true;
            this.rb_Cpf.Text = "CPF";
            this.rb_Cpf.UseVisualStyleBackColor = true;
            this.rb_Cpf.CheckedChanged += new System.EventHandler(this.rb_Cpf_CheckedChanged);
            this.rb_Cpf.Click += new System.EventHandler(this.rb_Cpf_Click);
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Location = new System.Drawing.Point(79, 3);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.rb_Nome.TabIndex = 175;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            this.rb_Nome.CheckedChanged += new System.EventHandler(this.rb_Nome_CheckedChanged);
            this.rb_Nome.Click += new System.EventHandler(this.rb_Nome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Cpf);
            this.panel1.Controls.Add(this.rb_Nome);
            this.panel1.Location = new System.Drawing.Point(566, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 26);
            this.panel1.TabIndex = 176;
            // 
            // Frm_Clinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1587, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbAtivado);
            this.Controls.Add(this.img_Email);
            this.Controls.Add(this.lb_BuscarNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_BuscarCpf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Inadiplente);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.image);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_ValorAberto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lb_Telefone);
            this.Controls.Add(this.lb_Cpf);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lb_Endereco);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(803, 60);
            this.Name = "Frm_Clinte";
            this.Text = "Cadastro de Clinte";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_Clinte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.rbAtivado.ResumeLayout(false);
            this.rbAtivado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lb_BuscarNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox lb_BuscarCpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Inadiplente;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox lb_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lb_ValorAberto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lb_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox lb_Telefone;
        private System.Windows.Forms.MaskedTextBox lb_Cpf;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox lb_Endereco;
        private System.Windows.Forms.TextBox lb_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_Email;
        private System.Windows.Forms.GroupBox rbAtivado;
        private System.Windows.Forms.RadioButton rb_Inativado;
        private System.Windows.Forms.RadioButton rb_Ativado;
        private System.Windows.Forms.RadioButton rb_Cpf;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.Panel panel1;
    }
}