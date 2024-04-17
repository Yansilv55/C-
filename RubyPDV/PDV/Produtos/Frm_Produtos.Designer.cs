namespace Moderno.Produtos
{
    partial class Frm_Produtos
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
            this.panelBusca = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarCod = new System.Windows.Forms.TextBox();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnAddCargo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_uniMedida = new System.Windows.Forms.ComboBox();
            this.panelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBusca.Controls.Add(this.label11);
            this.panelBusca.Controls.Add(this.txtBuscarCod);
            this.panelBusca.Controls.Add(this.txtBuscarNome);
            this.panelBusca.Controls.Add(this.label8);
            this.panelBusca.Controls.Add(this.label9);
            this.panelBusca.Controls.Add(this.lblTituloProdutos);
            this.panelBusca.Location = new System.Drawing.Point(-1, 0);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(1043, 53);
            this.panelBusca.TabIndex = 148;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(588, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 26);
            this.label11.TabIndex = 73;
            this.label11.Text = "BUSCAR";
            // 
            // txtBuscarCod
            // 
            this.txtBuscarCod.Location = new System.Drawing.Point(711, 23);
            this.txtBuscarCod.MaxLength = 13;
            this.txtBuscarCod.Name = "txtBuscarCod";
            this.txtBuscarCod.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarCod.TabIndex = 20;
            this.txtBuscarCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCod_KeyPress);
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(838, 23);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(197, 20);
            this.txtBuscarNome.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(993, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "NOME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(783, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "CÓDIGO";
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTituloProdutos.Location = new System.Drawing.Point(6, 10);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(373, 26);
            this.lblTituloProdutos.TabIndex = 72;
            this.lblTituloProdutos.Text = "GERENCIAMENTO DE PRODUTOS";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(10, 83);
            this.txtCodBarra.MaxLength = 13;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(203, 20);
            this.txtCodBarra.TabIndex = 149;
            this.txtCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarra_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Código de barra";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 132);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(429, 20);
            this.txtNome.TabIndex = 151;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Nome do Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 153;
            this.label6.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "abrobinha"});
            this.cbFornecedor.Location = new System.Drawing.Point(10, 189);
            this.cbFornecedor.MaxDropDownItems = 15;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(203, 21);
            this.cbFornecedor.TabIndex = 154;
            this.cbFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFornecedor_KeyDown);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(266, 189);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(69, 20);
            this.txtNota.TabIndex = 155;
            this.txtNota.Text = "0";
            this.txtNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNota_KeyDown);
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(263, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 156;
            this.label18.Text = "N.º do Doc.";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(370, 189);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(69, 20);
            this.txtMinimo.TabIndex = 157;
            this.txtMinimo.Text = "0";
            this.txtMinimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinimo_KeyDown);
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(367, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 158;
            this.label10.Text = "Est.mínimo";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(458, 189);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(80, 20);
            this.txtEstoque.TabIndex = 159;
            this.txtEstoque.Text = "0";
            this.txtEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstoque_KeyDown);
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Estoque atual";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(10, 252);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(68, 20);
            this.txtEntrada.TabIndex = 163;
            this.txtEntrada.Text = "0";
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            this.txtEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntrada_KeyDown);
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(133, 252);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(80, 20);
            this.txtCompra.TabIndex = 164;
            this.txtCompra.Text = "0";
            this.txtCompra.TextChanged += new System.EventHandler(this.txtCompra_TextChanged);
            this.txtCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompra_KeyDown);
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(246, 252);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(80, 20);
            this.txtUnitario.TabIndex = 165;
            this.txtUnitario.Text = "0";
            this.txtUnitario.TextChanged += new System.EventHandler(this.txtUnitario_TextChanged);
            this.txtUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitario_KeyDown);
            this.txtUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitario_KeyPress);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(359, 252);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(80, 20);
            this.txtValorVenda.TabIndex = 166;
            this.txtValorVenda.Text = "0";
            this.txtValorVenda.TextChanged += new System.EventHandler(this.txtValorVenda_TextChanged);
            this.txtValorVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorVenda_KeyDown);
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(458, 252);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(80, 20);
            this.txtLucro.TabIndex = 169;
            this.txtLucro.Text = "0";
            this.txtLucro.TextChanged += new System.EventHandler(this.txtLucro_TextChanged);
            this.txtLucro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLucro_KeyDown);
            this.txtLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLucro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Valor do Lucro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(358, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 171;
            this.label7.Text = "Valor Venda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(252, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 172;
            this.label17.Text = "Valor Unitário";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(130, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 173;
            this.label16.Text = "Valor Compra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 174;
            this.label15.Text = "Entrada";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(642, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 20);
            this.label22.TabIndex = 183;
            this.label22.Text = "Últma compa:";
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(755, 289);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(121, 20);
            this.data.TabIndex = 187;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.Location = new System.Drawing.Point(278, 545);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 35);
            this.btnEditar.TabIndex = 195;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Location = new System.Drawing.Point(204, 545);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 35);
            this.btnSalvar.TabIndex = 194;
            this.btnSalvar.Text = "salva";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnExcluir.Location = new System.Drawing.Point(446, 545);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 35);
            this.btnExcluir.TabIndex = 197;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.Location = new System.Drawing.Point(361, 545);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 35);
            this.btnCancelar.TabIndex = 196;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(10, 315);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1032, 222);
            this.grid.TabIndex = 198;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCargo.FlatAppearance.BorderSize = 0;
            this.btnAddCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAddCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCargo.Image = global::Moderno.Properties.Resources.icons8_Plus_30px;
            this.btnAddCargo.Location = new System.Drawing.Point(219, 184);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.Size = new System.Drawing.Size(32, 32);
            this.btnAddCargo.TabIndex = 199;
            this.btnAddCargo.UseVisualStyleBackColor = false;
            this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 162;
            this.label4.Text = "Unidade de Medida";
            // 
            // cb_uniMedida
            // 
            this.cb_uniMedida.FormattingEnabled = true;
            this.cb_uniMedida.Items.AddRange(new object[] {
            "LT",
            "Kg",
            "UN",
            "MT"});
            this.cb_uniMedida.Location = new System.Drawing.Point(460, 132);
            this.cb_uniMedida.Name = "cb_uniMedida";
            this.cb_uniMedida.Size = new System.Drawing.Size(90, 21);
            this.cb_uniMedida.TabIndex = 200;
            // 
            // Frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1042, 592);
            this.Controls.Add(this.cb_uniMedida);
            this.Controls.Add(this.btnAddCargo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.panelBusca);
            this.Name = "Frm_Produtos";
            this.Text = "Frm_Produtos";
            this.Load += new System.EventHandler(this.Frm_Produtos_Load);
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarCod;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnAddCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_uniMedida;
    }
}