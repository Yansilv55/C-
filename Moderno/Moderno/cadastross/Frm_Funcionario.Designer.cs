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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_Celular = new System.Windows.Forms.MaskedTextBox();
            this.lb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.lb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.txt_BuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.rb_Cpf = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCargo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(482, 564);
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
            this.lb_Celular.Location = new System.Drawing.Point(751, 65);
            this.lb_Celular.Mask = "(99) 0 0000-0000";
            this.lb_Celular.Name = "lb_Celular";
            this.lb_Celular.Size = new System.Drawing.Size(102, 16);
            this.lb_Celular.TabIndex = 28;
            this.lb_Celular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // lb_Cpf
            // 
            this.lb_Cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Cpf.Enabled = false;
            this.lb_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cpf.Location = new System.Drawing.Point(592, 64);
            this.lb_Cpf.Mask = "000.000.000-00";
            this.lb_Cpf.Name = "lb_Cpf";
            this.lb_Cpf.Size = new System.Drawing.Size(88, 16);
            this.lb_Cpf.TabIndex = 27;
            this.lb_Cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // btn_foto
            // 
            this.btn_foto.Enabled = false;
            this.btn_foto.ForeColor = System.Drawing.Color.Black;
            this.btn_foto.Location = new System.Drawing.Point(952, 54);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(46, 26);
            this.btn_foto.TabIndex = 31;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            this.btn_foto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Location = new System.Drawing.Point(154, 573);
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
            this.cb_Cargo.Location = new System.Drawing.Point(69, 151);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(219, 21);
            this.cb_Cargo.TabIndex = 29;
            this.cb_Cargo.SelectedIndexChanged += new System.EventHandler(this.cb_Cargo_SelectedIndexChanged);
            this.cb_Cargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // lb_Endereco
            // 
            this.lb_Endereco.BackColor = System.Drawing.Color.White;
            this.lb_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Endereco.Enabled = false;
            this.lb_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Endereco.Location = new System.Drawing.Point(69, 103);
            this.lb_Endereco.Name = "lb_Endereco";
            this.lb_Endereco.Size = new System.Drawing.Size(784, 16);
            this.lb_Endereco.TabIndex = 30;
            this.lb_Endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // lb_Nome
            // 
            this.lb_Nome.BackColor = System.Drawing.Color.White;
            this.lb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Nome.Enabled = false;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(69, 64);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(466, 16);
            this.lb_Nome.TabIndex = 26;
            this.lb_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(714, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cel. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid.Location = new System.Drawing.Point(12, 217);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(841, 267);
            this.grid.TabIndex = 52;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick_1);
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBusca.Controls.Add(this.txt_BuscarCpf);
            this.panelBusca.Controls.Add(this.lblTitulo);
            this.panelBusca.Controls.Add(this.txt_BuscarNome);
            this.panelBusca.Controls.Add(this.label6);
            this.panelBusca.Controls.Add(this.rb_Nome);
            this.panelBusca.Controls.Add(this.rb_Cpf);
            this.panelBusca.Location = new System.Drawing.Point(1, 1);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(1246, 45);
            this.panelBusca.TabIndex = 149;
            // 
            // txt_BuscarCpf
            // 
            this.txt_BuscarCpf.Location = new System.Drawing.Point(853, 15);
            this.txt_BuscarCpf.Mask = "000,000,000-00";
            this.txt_BuscarCpf.Name = "txt_BuscarCpf";
            this.txt_BuscarCpf.Size = new System.Drawing.Size(86, 20);
            this.txt_BuscarCpf.TabIndex = 30;
            this.txt_BuscarCpf.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 26);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "CADASTRO DE FUNCIONÁRIO";
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(716, 16);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(119, 20);
            this.txt_BuscarNome.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(599, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Busca";
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.ForeColor = System.Drawing.Color.White;
            this.rb_Nome.Location = new System.Drawing.Point(481, 16);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.rb_Nome.TabIndex = 31;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            this.rb_Nome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rb_Cpf
            // 
            this.rb_Cpf.AutoSize = true;
            this.rb_Cpf.ForeColor = System.Drawing.Color.White;
            this.rb_Cpf.Location = new System.Drawing.Point(540, 16);
            this.rb_Cpf.Name = "rb_Cpf";
            this.rb_Cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_Cpf.TabIndex = 32;
            this.rb_Cpf.TabStop = true;
            this.rb_Cpf.Text = "CPF";
            this.rb_Cpf.UseVisualStyleBackColor = true;
            this.rb_Cpf.CheckedChanged += new System.EventHandler(this.rb_Cpf_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1165, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "Salvar";
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.BackColor = System.Drawing.Color.Gray;
            this.btnAddCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCargo.FlatAppearance.BorderSize = 0;
            this.btnAddCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAddCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCargo.Image = global::Moderno.Properties.Resources.icons8_Plus_24px_1;
            this.btnAddCargo.Location = new System.Drawing.Point(294, 151);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.Size = new System.Drawing.Size(32, 21);
            this.btnAddCargo.TabIndex = 166;
            this.btnAddCargo.UseVisualStyleBackColor = false;
            this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Image = global::Moderno.Properties.Resources.icons8_save_26px1;
            this.btn_Salvar.Location = new System.Drawing.Point(1151, 564);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(60, 63);
            this.btn_Salvar.TabIndex = 34;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Image = global::Moderno.Properties.Resources.icons8_trash_can_26px1;
            this.btn_Excluir.Location = new System.Drawing.Point(47, 538);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(67, 83);
            this.btn_Excluir.TabIndex = 37;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Image = global::Moderno.Properties.Resources.icons8_edit_text_file_50px;
            this.btn_Editar.Location = new System.Drawing.Point(294, 556);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(64, 66);
            this.btn_Editar.TabIndex = 36;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.Enabled = false;
            this.image.Image = global::Moderno.Properties.Resources.icons8_person_32px;
            this.image.Location = new System.Drawing.Point(1004, 52);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(243, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 32;
            this.image.TabStop = false;
            // 
            // Frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1248, 692);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddCargo);
            this.Controls.Add(this.panelBusca);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Funcionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
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
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.MaskedTextBox txt_BuscarCpf;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.RadioButton rb_Cpf;
        private System.Windows.Forms.Button btnAddCargo;
        private System.Windows.Forms.Label label7;
    }
}