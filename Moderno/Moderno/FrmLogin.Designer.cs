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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.TextBox();
            this.lb_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Maxmizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.Location = new System.Drawing.Point(157, 48);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(180, 20);
            this.lb_Usuario.TabIndex = 2;
            // 
            // lb_Senha
            // 
            this.lb_Senha.Location = new System.Drawing.Point(157, 126);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.PasswordChar = '*';
            this.lb_Senha.Size = new System.Drawing.Size(180, 20);
            this.lb_Senha.TabIndex = 3;
            // 
            // btn_Entar
            // 
            this.btn_Entar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entar.ForeColor = System.Drawing.Color.White;
            this.btn_Entar.Location = new System.Drawing.Point(385, 208);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 208);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimizar.Location = new System.Drawing.Point(391, 1);
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
            this.btn_Maxmizar.Location = new System.Drawing.Point(422, 1);
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
            this.btnFechar.Location = new System.Drawing.Point(452, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(19, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 252);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_Maxmizar);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Entar);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lb_Usuario;
        private System.Windows.Forms.TextBox lb_Senha;
        private System.Windows.Forms.Button btn_Entar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Maxmizar;
        private System.Windows.Forms.Button btnFechar;
    }
}