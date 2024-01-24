namespace PDV
{
    partial class Frm_Principal
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
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.Menu_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_afiliados = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_movimentaçao = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_flx_caixa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Laçar_vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_despesas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_movimento = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Img_03 = new System.Windows.Forms.PictureBox();
            this.Img_04 = new System.Windows.Forms.PictureBox();
            this.Img_02 = new System.Windows.Forms.PictureBox();
            this.Img_01 = new System.Windows.Forms.PictureBox();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_01)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.BackColor = System.Drawing.SystemColors.Info;
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_cadastro,
            this.Menu_produto,
            this.Menu_movimentaçao,
            this.Menu_relatorio,
            this.Menu_sair});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(1394, 24);
            this.Menu_Principal.TabIndex = 0;
            this.Menu_Principal.Text = "menuStrip1";
            // 
            // Menu_cadastro
            // 
            this.Menu_cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_afiliados,
            this.Menu_clientes,
            this.Menu_fornecedor,
            this.Menu_funcionarios,
            this.cargoToolStripMenuItem});
            this.Menu_cadastro.Name = "Menu_cadastro";
            this.Menu_cadastro.Size = new System.Drawing.Size(71, 20);
            this.Menu_cadastro.Text = "Cadastros";
            // 
            // Menu_afiliados
            // 
            this.Menu_afiliados.Name = "Menu_afiliados";
            this.Menu_afiliados.Size = new System.Drawing.Size(180, 22);
            this.Menu_afiliados.Text = "Afiliados";
            // 
            // Menu_clientes
            // 
            this.Menu_clientes.Name = "Menu_clientes";
            this.Menu_clientes.Size = new System.Drawing.Size(180, 22);
            this.Menu_clientes.Text = "Clientes";
            // 
            // Menu_fornecedor
            // 
            this.Menu_fornecedor.Name = "Menu_fornecedor";
            this.Menu_fornecedor.Size = new System.Drawing.Size(180, 22);
            this.Menu_fornecedor.Text = "Fornecedor";
            // 
            // Menu_funcionarios
            // 
            this.Menu_funcionarios.Name = "Menu_funcionarios";
            this.Menu_funcionarios.Size = new System.Drawing.Size(180, 22);
            this.Menu_funcionarios.Text = "Funcionários";
            this.Menu_funcionarios.Click += new System.EventHandler(this.Menu_funcionarios_Click);
            // 
            // Menu_produto
            // 
            this.Menu_produto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_produtos,
            this.Menu_estoque});
            this.Menu_produto.Name = "Menu_produto";
            this.Menu_produto.Size = new System.Drawing.Size(67, 20);
            this.Menu_produto.Text = "Produtos";
            // 
            // Menu_produtos
            // 
            this.Menu_produtos.Name = "Menu_produtos";
            this.Menu_produtos.Size = new System.Drawing.Size(122, 22);
            this.Menu_produtos.Text = "Produtos";
            // 
            // Menu_estoque
            // 
            this.Menu_estoque.Name = "Menu_estoque";
            this.Menu_estoque.Size = new System.Drawing.Size(122, 22);
            this.Menu_estoque.Text = "Estoque";
            // 
            // Menu_movimentaçao
            // 
            this.Menu_movimentaçao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_flx_caixa,
            this.Menu_Laçar_vendas,
            this.Menu_despesas});
            this.Menu_movimentaçao.Name = "Menu_movimentaçao";
            this.Menu_movimentaçao.Size = new System.Drawing.Size(104, 20);
            this.Menu_movimentaçao.Text = "Movimentações";
            // 
            // Menu_flx_caixa
            // 
            this.Menu_flx_caixa.Name = "Menu_flx_caixa";
            this.Menu_flx_caixa.Size = new System.Drawing.Size(149, 22);
            this.Menu_flx_caixa.Text = "Fluxo de caixa";
            // 
            // Menu_Laçar_vendas
            // 
            this.Menu_Laçar_vendas.Name = "Menu_Laçar_vendas";
            this.Menu_Laçar_vendas.Size = new System.Drawing.Size(149, 22);
            this.Menu_Laçar_vendas.Text = "Lançar vendas";
            // 
            // Menu_despesas
            // 
            this.Menu_despesas.Name = "Menu_despesas";
            this.Menu_despesas.Size = new System.Drawing.Size(149, 22);
            this.Menu_despesas.Text = "Despesas";
            // 
            // Menu_relatorio
            // 
            this.Menu_relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_vendas,
            this.Menu_movimento,
            this.retiradaToolStripMenuItem});
            this.Menu_relatorio.Name = "Menu_relatorio";
            this.Menu_relatorio.Size = new System.Drawing.Size(66, 20);
            this.Menu_relatorio.Text = "Relatório";
            // 
            // Menu_vendas
            // 
            this.Menu_vendas.Name = "Menu_vendas";
            this.Menu_vendas.Size = new System.Drawing.Size(165, 22);
            this.Menu_vendas.Text = "Vendas";
            // 
            // Menu_movimento
            // 
            this.Menu_movimento.Name = "Menu_movimento";
            this.Menu_movimento.Size = new System.Drawing.Size(165, 22);
            this.Menu_movimento.Text = "Movimentos";
            // 
            // retiradaToolStripMenuItem
            // 
            this.retiradaToolStripMenuItem.Name = "retiradaToolStripMenuItem";
            this.retiradaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.retiradaToolStripMenuItem.Text = "Acesso / Retirada";
            // 
            // Menu_sair
            // 
            this.Menu_sair.Name = "Menu_sair";
            this.Menu_sair.Size = new System.Drawing.Size(38, 20);
            this.Menu_sair.Text = "Sair";
            this.Menu_sair.Click += new System.EventHandler(this.Menu_sair_Click);
            // 
            // Img_03
            // 
            this.Img_03.Image = global::PDV.Properties.Resources.icons8_shopping_bag_64px;
            this.Img_03.Location = new System.Drawing.Point(177, 305);
            this.Img_03.Name = "Img_03";
            this.Img_03.Size = new System.Drawing.Size(314, 222);
            this.Img_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_03.TabIndex = 4;
            this.Img_03.TabStop = false;
            // 
            // Img_04
            // 
            this.Img_04.Image = global::PDV.Properties.Resources.icons8_airport_arrow_baggage_direction_luggage_move_62_64px;
            this.Img_04.Location = new System.Drawing.Point(525, 305);
            this.Img_04.Name = "Img_04";
            this.Img_04.Size = new System.Drawing.Size(336, 222);
            this.Img_04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_04.TabIndex = 3;
            this.Img_04.TabStop = false;
            // 
            // Img_02
            // 
            this.Img_02.Image = global::PDV.Properties.Resources.icons8_checked_baggage_64px;
            this.Img_02.Location = new System.Drawing.Point(539, 66);
            this.Img_02.Name = "Img_02";
            this.Img_02.Size = new System.Drawing.Size(322, 219);
            this.Img_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_02.TabIndex = 2;
            this.Img_02.TabStop = false;
            // 
            // Img_01
            // 
            this.Img_01.Image = global::PDV.Properties.Resources.icons8_shopping_cart_64px;
            this.Img_01.Location = new System.Drawing.Point(177, 66);
            this.Img_01.Name = "Img_01";
            this.Img_01.Size = new System.Drawing.Size(314, 219);
            this.Img_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_01.TabIndex = 1;
            this.Img_01.TabStop = false;
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 585);
            this.Controls.Add(this.Img_03);
            this.Controls.Add(this.Img_04);
            this.Controls.Add(this.Img_02);
            this.Controls.Add(this.Img_01);
            this.Controls.Add(this.Menu_Principal);
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "Frm_Principal";
            this.Text = "FRM_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_cadastro;
        private System.Windows.Forms.ToolStripMenuItem Menu_produto;
        private System.Windows.Forms.ToolStripMenuItem Menu_movimentaçao;
        private System.Windows.Forms.ToolStripMenuItem Menu_relatorio;
        private System.Windows.Forms.ToolStripMenuItem Menu_sair;
        private System.Windows.Forms.PictureBox Img_01;
        private System.Windows.Forms.PictureBox Img_02;
        private System.Windows.Forms.PictureBox Img_04;
        private System.Windows.Forms.PictureBox Img_03;
        private System.Windows.Forms.ToolStripMenuItem Menu_afiliados;
        private System.Windows.Forms.ToolStripMenuItem Menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem Menu_fornecedor;
        private System.Windows.Forms.ToolStripMenuItem Menu_produtos;
        private System.Windows.Forms.ToolStripMenuItem Menu_estoque;
        private System.Windows.Forms.ToolStripMenuItem Menu_flx_caixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_Laçar_vendas;
        private System.Windows.Forms.ToolStripMenuItem Menu_despesas;
        private System.Windows.Forms.ToolStripMenuItem Menu_vendas;
        private System.Windows.Forms.ToolStripMenuItem Menu_movimento;
        private System.Windows.Forms.ToolStripMenuItem retiradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
    }
}

