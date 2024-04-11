namespace Moderno
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Maxmizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureErro = new System.Windows.Forms.PictureBox();
            this.lbl_textoErro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureErro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(362, 58);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(222, 20);
            this.txt_Usuario.TabIndex = 2;
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Usuario_KeyDown);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(362, 122);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(222, 20);
            this.txt_Senha.TabIndex = 3;
            this.txt_Senha.Enter += new System.EventHandler(this.txt_Senha_Enter);
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            this.txt_Senha.Leave += new System.EventHandler(this.txt_Senha_Leave);
            // 
            // btn_Entar
            // 
            this.btn_Entar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entar.ForeColor = System.Drawing.Color.White;
            this.btn_Entar.Location = new System.Drawing.Point(481, 208);
            this.btn_Entar.Name = "btn_Entar";
            this.btn_Entar.Size = new System.Drawing.Size(75, 32);
            this.btn_Entar.TabIndex = 4;
            this.btn_Entar.Text = "Entar";
            this.btn_Entar.UseVisualStyleBackColor = true;
            this.btn_Entar.Click += new System.EventHandler(this.btn_Entar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(362, 208);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimizar.Location = new System.Drawing.Point(547, 1);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(25, 28);
            this.btn_Minimizar.TabIndex = 6;
            this.btn_Minimizar.Text = "-";
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Maxmizar
            // 
            this.btn_Maxmizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maxmizar.FlatAppearance.BorderSize = 0;
            this.btn_Maxmizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maxmizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maxmizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Maxmizar.Location = new System.Drawing.Point(578, 1);
            this.btn_Maxmizar.Name = "btn_Maxmizar";
            this.btn_Maxmizar.Size = new System.Drawing.Size(24, 28);
            this.btn_Maxmizar.TabIndex = 7;
            this.btn_Maxmizar.Text = "=";
            this.btn_Maxmizar.UseVisualStyleBackColor = true;
            this.btn_Maxmizar.Click += new System.EventHandler(this.btn_Maxmizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(608, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(19, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureErro
            // 
            this.pictureErro.Image = ((System.Drawing.Image)(resources.GetObject("pictureErro.Image")));
            this.pictureErro.Location = new System.Drawing.Point(362, 164);
            this.pictureErro.Name = "pictureErro";
            this.pictureErro.Size = new System.Drawing.Size(29, 27);
            this.pictureErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureErro.TabIndex = 10;
            this.pictureErro.TabStop = false;
            this.pictureErro.Visible = false;
            // 
            // lbl_textoErro
            // 
            this.lbl_textoErro.AutoSize = true;
            this.lbl_textoErro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_textoErro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_textoErro.Location = new System.Drawing.Point(408, 178);
            this.lbl_textoErro.Name = "lbl_textoErro";
            this.lbl_textoErro.Size = new System.Drawing.Size(94, 13);
            this.lbl_textoErro.TabIndex = 11;
            this.lbl_textoErro.Text = "Messagem de erro";
            this.lbl_textoErro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 252);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(628, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_textoErro);
            this.Controls.Add(this.pictureErro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_Maxmizar);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Entar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureErro)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Maxmizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureErro;
        private System.Windows.Forms.Label lbl_textoErro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}