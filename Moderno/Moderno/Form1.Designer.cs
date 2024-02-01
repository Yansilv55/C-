namespace Moderno
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.btn_Fluxo_Caixa = new System.Windows.Forms.Button();
            this.btn_Lancar_Despesas = new System.Windows.Forms.Button();
            this.btn_Movimentacoes = new System.Windows.Forms.Button();
            this.button_Receber = new System.Windows.Forms.Button();
            this.btn_Venda_PDV = new System.Windows.Forms.Button();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.lb_Home = new System.Windows.Forms.Label();
            this.lb_pdv = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Panel_Desktop = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Logo.SuspendLayout();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Menu.Controls.Add(this.btn_Relatorio);
            this.Panel_Menu.Controls.Add(this.btn_Fluxo_Caixa);
            this.Panel_Menu.Controls.Add(this.btn_Lancar_Despesas);
            this.Panel_Menu.Controls.Add(this.btn_Movimentacoes);
            this.Panel_Menu.Controls.Add(this.button_Receber);
            this.Panel_Menu.Controls.Add(this.btn_Venda_PDV);
            this.Panel_Menu.Controls.Add(this.Panel_Logo);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(220, 577);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Panel_Logo.Controls.Add(this.lb_pdv);
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.ForeColor = System.Drawing.Color.White;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(220, 80);
            this.Panel_Logo.TabIndex = 0;
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Relatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Relatorio.FlatAppearance.BorderSize = 0;
            this.btn_Relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Relatorio.Image = global::Moderno.Properties.Resources.icons8_Folder_Listing_32px;
            this.btn_Relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Relatorio.Location = new System.Drawing.Point(0, 489);
            this.btn_Relatorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Relatorio.Size = new System.Drawing.Size(220, 88);
            this.btn_Relatorio.TabIndex = 6;
            this.btn_Relatorio.Text = "Relatório";
            this.btn_Relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Relatorio.UseVisualStyleBackColor = false;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // btn_Fluxo_Caixa
            // 
            this.btn_Fluxo_Caixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Fluxo_Caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Fluxo_Caixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fluxo_Caixa.FlatAppearance.BorderSize = 0;
            this.btn_Fluxo_Caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fluxo_Caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fluxo_Caixa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Fluxo_Caixa.Image = global::Moderno.Properties.Resources.icons8_money_bill_wave_32px;
            this.btn_Fluxo_Caixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fluxo_Caixa.Location = new System.Drawing.Point(0, 408);
            this.btn_Fluxo_Caixa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Fluxo_Caixa.Name = "btn_Fluxo_Caixa";
            this.btn_Fluxo_Caixa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Fluxo_Caixa.Size = new System.Drawing.Size(220, 81);
            this.btn_Fluxo_Caixa.TabIndex = 5;
            this.btn_Fluxo_Caixa.Text = "Fluxo de Caixa";
            this.btn_Fluxo_Caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Fluxo_Caixa.UseVisualStyleBackColor = false;
            this.btn_Fluxo_Caixa.Click += new System.EventHandler(this.btn_Fluxo_Caixa_Click);
            // 
            // btn_Lancar_Despesas
            // 
            this.btn_Lancar_Despesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Lancar_Despesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Lancar_Despesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Lancar_Despesas.FlatAppearance.BorderSize = 0;
            this.btn_Lancar_Despesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lancar_Despesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lancar_Despesas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Lancar_Despesas.Image = global::Moderno.Properties.Resources.icons8_Folder_Listing_32px;
            this.btn_Lancar_Despesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lancar_Despesas.Location = new System.Drawing.Point(0, 322);
            this.btn_Lancar_Despesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Lancar_Despesas.Name = "btn_Lancar_Despesas";
            this.btn_Lancar_Despesas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Lancar_Despesas.Size = new System.Drawing.Size(220, 86);
            this.btn_Lancar_Despesas.TabIndex = 4;
            this.btn_Lancar_Despesas.Text = "Lançar Despesas";
            this.btn_Lancar_Despesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lancar_Despesas.UseVisualStyleBackColor = false;
            this.btn_Lancar_Despesas.Click += new System.EventHandler(this.btn_Lancar_Despesas_Click);
            // 
            // btn_Movimentacoes
            // 
            this.btn_Movimentacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Movimentacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Movimentacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Movimentacoes.FlatAppearance.BorderSize = 0;
            this.btn_Movimentacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Movimentacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Movimentacoes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Movimentacoes.Image = global::Moderno.Properties.Resources.icons8_folded_booklet_24px;
            this.btn_Movimentacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Movimentacoes.Location = new System.Drawing.Point(0, 236);
            this.btn_Movimentacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Movimentacoes.Name = "btn_Movimentacoes";
            this.btn_Movimentacoes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Movimentacoes.Size = new System.Drawing.Size(220, 86);
            this.btn_Movimentacoes.TabIndex = 3;
            this.btn_Movimentacoes.Text = "Movimentações";
            this.btn_Movimentacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Movimentacoes.UseVisualStyleBackColor = false;
            this.btn_Movimentacoes.Click += new System.EventHandler(this.btn_Movimentacoes_Click);
            // 
            // button_Receber
            // 
            this.button_Receber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_Receber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Receber.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Receber.FlatAppearance.BorderSize = 0;
            this.button_Receber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Receber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Receber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Receber.Image = global::Moderno.Properties.Resources.icons8_money_bill_wave_32px;
            this.button_Receber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Receber.Location = new System.Drawing.Point(0, 156);
            this.button_Receber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Receber.Name = "button_Receber";
            this.button_Receber.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Receber.Size = new System.Drawing.Size(220, 80);
            this.button_Receber.TabIndex = 2;
            this.button_Receber.Text = "Receber";
            this.button_Receber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Receber.UseVisualStyleBackColor = false;
            this.button_Receber.Click += new System.EventHandler(this.button_Receber_Click);
            // 
            // btn_Venda_PDV
            // 
            this.btn_Venda_PDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Venda_PDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Venda_PDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Venda_PDV.FlatAppearance.BorderSize = 0;
            this.btn_Venda_PDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Venda_PDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venda_PDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Venda_PDV.Image = global::Moderno.Properties.Resources.icons8_food_32px;
            this.btn_Venda_PDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Venda_PDV.Location = new System.Drawing.Point(0, 80);
            this.btn_Venda_PDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Venda_PDV.Name = "btn_Venda_PDV";
            this.btn_Venda_PDV.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Venda_PDV.Size = new System.Drawing.Size(220, 76);
            this.btn_Venda_PDV.TabIndex = 1;
            this.btn_Venda_PDV.Text = "Venda PDV";
            this.btn_Venda_PDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Venda_PDV.UseVisualStyleBackColor = false;
            this.btn_Venda_PDV.Click += new System.EventHandler(this.btn_Venda_PDV_Click);
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Panel_Title.Controls.Add(this.lb_Home);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(220, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1060, 80);
            this.Panel_Title.TabIndex = 1;
            // 
            // lb_Home
            // 
            this.lb_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Home.AutoSize = true;
            this.lb_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Home.Location = new System.Drawing.Point(504, 27);
            this.lb_Home.Name = "lb_Home";
            this.lb_Home.Size = new System.Drawing.Size(71, 26);
            this.lb_Home.TabIndex = 0;
            this.lb_Home.Text = "Home";
            // 
            // lb_pdv
            // 
            this.lb_pdv.AutoSize = true;
            this.lb_pdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pdv.Location = new System.Drawing.Point(26, 27);
            this.lb_pdv.Name = "lb_pdv";
            this.lb_pdv.Size = new System.Drawing.Size(160, 26);
            this.lb_pdv.TabIndex = 0;
            this.lb_pdv.Text = "Ruby Sistemas";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Panel_Desktop
            // 
            this.Panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Desktop.Location = new System.Drawing.Point(220, 80);
            this.Panel_Desktop.Name = "Panel_Desktop";
            this.Panel_Desktop.Size = new System.Drawing.Size(1060, 497);
            this.Panel_Desktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 577);
            this.Controls.Add(this.Panel_Desktop);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.Panel_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Logo.ResumeLayout(false);
            this.Panel_Logo.PerformLayout();
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Button btn_Venda_PDV;
        private System.Windows.Forms.Button btn_Relatorio;
        private System.Windows.Forms.Button btn_Fluxo_Caixa;
        private System.Windows.Forms.Button btn_Lancar_Despesas;
        private System.Windows.Forms.Button btn_Movimentacoes;
        private System.Windows.Forms.Button button_Receber;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label lb_Home;
        private System.Windows.Forms.Label lb_pdv;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel Panel_Desktop;
    }
}

