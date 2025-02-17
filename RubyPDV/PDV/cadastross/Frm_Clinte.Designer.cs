﻿namespace Moderno.cadastross
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
            this.cb_Inadiplente = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ValorAberto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rb_Ativado = new System.Windows.Forms.RadioButton();
            this.rb_Inativado = new System.Windows.Forms.RadioButton();
            this.rbAtivado = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.img_Email = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.panelBusca.SuspendLayout();
            this.rbAtivado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Inadiplente
            // 
            this.cb_Inadiplente.FormattingEnabled = true;
            this.cb_Inadiplente.ItemHeight = 13;
            this.cb_Inadiplente.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_Inadiplente.Location = new System.Drawing.Point(705, 78);
            this.cb_Inadiplente.Name = "cb_Inadiplente";
            this.cb_Inadiplente.Size = new System.Drawing.Size(102, 21);
            this.cb_Inadiplente.TabIndex = 8;
            this.cb_Inadiplente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Inadiplente_KeyDown);
            this.cb_Inadiplente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Inadiplente_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(66, 97);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(428, 20);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.TextChanged += new System.EventHandler(this.lb_Email_TextChanged);
            this.txt_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Email_KeyDown);
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
            // txt_ValorAberto
            // 
            this.txt_ValorAberto.Enabled = false;
            this.txt_ValorAberto.Location = new System.Drawing.Point(705, 45);
            this.txt_ValorAberto.Name = "txt_ValorAberto";
            this.txt_ValorAberto.Size = new System.Drawing.Size(102, 20);
            this.txt_ValorAberto.TabIndex = 7;
            this.txt_ValorAberto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_ValorAberto_KeyDown);
            this.txt_ValorAberto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_ValorAberto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(634, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Valor Aberto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(634, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Inadiplete";
            // 
            // txt_Celular
            // 
            this.txt_Celular.Enabled = false;
            this.txt_Celular.Location = new System.Drawing.Point(533, 77);
            this.txt_Celular.Mask = "(99) 0 0000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(86, 20);
            this.txt_Celular.TabIndex = 6;
            this.txt_Celular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Telefone_KeyDown);
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Enabled = false;
            this.txt_Cpf.Location = new System.Drawing.Point(533, 44);
            this.txt_Cpf.Mask = "000.000.000-00";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(86, 20);
            this.txt_Cpf.TabIndex = 5;
            this.txt_Cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Cpf_KeyDown);
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Enabled = false;
            this.txt_Endereco.Location = new System.Drawing.Point(66, 71);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(428, 20);
            this.txt_Endereco.TabIndex = 2;
            this.txt_Endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Endereco_KeyDown);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(66, 45);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(428, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_Nome_KeyDown);
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
            this.label3.Location = new System.Drawing.Point(500, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cel. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(500, 51);
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
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBusca.Controls.Add(this.lblTitulo);
            this.panelBusca.Location = new System.Drawing.Point(-3, 0);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(956, 37);
            this.panelBusca.TabIndex = 177;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 26);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "CADASTRO DE CLIENTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(150, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 182;
            this.label11.Text = "Novo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(332, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 181;
            this.label12.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(244, 557);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 180;
            this.label13.Text = "Editar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(42, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 179;
            this.label14.Text = "Excluir";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(441, 557);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 178;
            this.label15.Text = "Salvar";
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
            // rb_Inativado
            // 
            this.rb_Inativado.AutoSize = true;
            this.rb_Inativado.Location = new System.Drawing.Point(6, 34);
            this.rb_Inativado.Name = "rb_Inativado";
            this.rb_Inativado.Size = new System.Drawing.Size(69, 17);
            this.rb_Inativado.TabIndex = 175;
            this.rb_Inativado.TabStop = true;
            this.rb_Inativado.Text = "Inativado";
            this.rb_Inativado.UseVisualStyleBackColor = true;
            // 
            // rbAtivado
            // 
            this.rbAtivado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rbAtivado.Controls.Add(this.rb_Inativado);
            this.rbAtivado.Controls.Add(this.rb_Ativado);
            this.rbAtivado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAtivado.ForeColor = System.Drawing.Color.White;
            this.rbAtivado.Location = new System.Drawing.Point(823, 45);
            this.rbAtivado.Name = "rbAtivado";
            this.rbAtivado.Size = new System.Drawing.Size(109, 56);
            this.rbAtivado.TabIndex = 173;
            this.rbAtivado.TabStop = false;
            this.rbAtivado.Text = "Status do cliente?";
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(14, 172);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(918, 283);
            this.grid.TabIndex = 183;
            // 
            // img_Email
            // 
            this.img_Email.Image = global::Moderno.Properties.Resources.icons8_secure_24px;
            this.img_Email.Location = new System.Drawing.Point(500, 97);
            this.img_Email.Name = "img_Email";
            this.img_Email.Size = new System.Drawing.Size(27, 31);
            this.img_Email.TabIndex = 82;
            this.img_Email.TabStop = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::Moderno.Properties.Resources.icons8_multiply_26px;
            this.btn_Cancelar.Location = new System.Drawing.Point(335, 522);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(43, 32);
            this.btn_Cancelar.TabIndex = 67;
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
            this.btn_Salvar.Location = new System.Drawing.Point(441, 522);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(48, 32);
            this.btn_Salvar.TabIndex = 63;
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
            this.btn_Excluir.Location = new System.Drawing.Point(45, 522);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(40, 32);
            this.btn_Excluir.TabIndex = 66;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Image = global::Moderno.Properties.Resources.icons8_edit_property_24px;
            this.btn_Editar.Location = new System.Drawing.Point(235, 522);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(54, 32);
            this.btn_Editar.TabIndex = 65;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Image = global::Moderno.Properties.Resources.icons8_Plus_30px1;
            this.btn_Novo.Location = new System.Drawing.Point(127, 522);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 32);
            this.btn_Novo.TabIndex = 64;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // Frm_Clinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(949, 588);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panelBusca);
            this.Controls.Add(this.rbAtivado);
            this.Controls.Add(this.img_Email);
            this.Controls.Add(this.cb_Inadiplente);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ValorAberto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Nome);
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
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.rbAtivado.ResumeLayout(false);
            this.rbAtivado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Inadiplente;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ValorAberto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.MaskedTextBox txt_Cpf;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_Email;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_Ativado;
        private System.Windows.Forms.RadioButton rb_Inativado;
        private System.Windows.Forms.GroupBox rbAtivado;
        private System.Windows.Forms.DataGridView grid;
    }
}