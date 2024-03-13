namespace Moderno.cadastross
{
    partial class Frm_Usuario
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
            this.cb_Funcionario = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Funcionario
            // 
            this.cb_Funcionario.FormattingEnabled = true;
            this.cb_Funcionario.ItemHeight = 13;
            this.cb_Funcionario.Location = new System.Drawing.Point(77, 135);
            this.cb_Funcionario.Name = "cb_Funcionario";
            this.cb_Funcionario.Size = new System.Drawing.Size(169, 21);
            this.cb_Funcionario.TabIndex = 0;
            this.cb_Funcionario.SelectedIndexChanged += new System.EventHandler(this.cb_Funcionario_SelectedIndexChanged);
            this.cb_Funcionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Usuario_KeyDown);
            this.cb_Funcionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Funcionario_KeyPress);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Location = new System.Drawing.Point(27, 177);
            this.grid.Name = "grid";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Size = new System.Drawing.Size(751, 291);
            this.grid.TabIndex = 1;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(77, 99);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(118, 20);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Usuario_KeyDown);
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(251, 99);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(133, 20);
            this.txt_Cargo.TabIndex = 20;
            this.txt_Cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cargo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(765, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por Nome";
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(860, 16);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(270, 20);
            this.txt_BuscarNome.TabIndex = 7;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuário";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(77, 65);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(307, 20);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Usuario_KeyDown);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::Moderno.Properties.Resources.icons8_multiply_26px;
            this.btn_Cancelar.Location = new System.Drawing.Point(417, 502);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(44, 32);
            this.btn_Cancelar.TabIndex = 43;
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
            this.btn_Salvar.Location = new System.Drawing.Point(493, 502);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(36, 32);
            this.btn_Salvar.TabIndex = 39;
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
            this.btn_Excluir.Location = new System.Drawing.Point(210, 502);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(36, 32);
            this.btn_Excluir.TabIndex = 42;
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
            this.btn_Editar.Location = new System.Drawing.Point(339, 502);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(45, 32);
            this.btn_Editar.TabIndex = 41;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.ForeColor = System.Drawing.Color.Black;
            this.btn_Novo.Image = global::Moderno.Properties.Resources.icons8_Plus_30px1;
            this.btn_Novo.Location = new System.Drawing.Point(268, 502);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(43, 32);
            this.btn_Novo.TabIndex = 40;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Funcionário";
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBusca.Controls.Add(this.labelTitulo);
            this.panelBusca.Controls.Add(this.label3);
            this.panelBusca.Controls.Add(this.txt_BuscarNome);
            this.panelBusca.Location = new System.Drawing.Point(1, 2);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(1144, 50);
            this.panelBusca.TabIndex = 172;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(6, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(278, 26);
            this.labelTitulo.TabIndex = 72;
            this.labelTitulo.Text = "CADASTRO DE USUÁRIO";
            // 
            // Frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.panelBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cb_Funcionario);
            this.Name = "Frm_Usuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.Frm_Usuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Usuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Funcionario;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Label labelTitulo;
    }
}