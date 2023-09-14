namespace MeuCadastro
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
            this.components = new System.ComponentModel.Container();
            this.pessoasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.anterior = new System.Windows.Forms.Button();
            this.Proxima = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.novoregistro = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.banco_de_dadosDataSet = new MeuCadastro.Banco_de_dadosDataSet();
            this.pessoasBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new MeuCadastro.Banco_de_dadosDataSetTableAdapters.PessoasTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_dadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(27, 38);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.textBox1.Location = new System.Drawing.Point(94, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(27, 64);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbl_sobrenome.TabIndex = 0;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Sobrenome", true));
            this.textBox2.Location = new System.Drawing.Point(94, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(27, 90);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(63, 13);
            this.lbl_nascimento.TabIndex = 0;
            this.lbl_nascimento.Text = "Nascimento";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(27, 116);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Eamail", true));
            this.textBox4.Location = new System.Drawing.Point(94, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 20);
            this.textBox4.TabIndex = 1;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(27, 142);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lbl_cpf);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_nascimento);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_sobrenome);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(23, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "CPF", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(94, 142);
            this.maskedTextBox2.Mask = "000.000.000\\-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(202, 20);
            this.maskedTextBox2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nascimento", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(94, 91);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(202, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // anterior
            // 
            this.anterior.Location = new System.Drawing.Point(27, 168);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(58, 35);
            this.anterior.TabIndex = 2;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proxima
            // 
            this.Proxima.Location = new System.Drawing.Point(108, 168);
            this.Proxima.Name = "Proxima";
            this.Proxima.Size = new System.Drawing.Size(60, 35);
            this.Proxima.TabIndex = 2;
            this.Proxima.Text = "Próxima";
            this.Proxima.UseVisualStyleBackColor = true;
            this.Proxima.Click += new System.EventHandler(this.Proxima_Click);
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(231, 168);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(63, 35);
            this.deletar.TabIndex = 2;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // novoregistro
            // 
            this.novoregistro.Location = new System.Drawing.Point(347, 168);
            this.novoregistro.Name = "novoregistro";
            this.novoregistro.Size = new System.Drawing.Size(121, 35);
            this.novoregistro.TabIndex = 2;
            this.novoregistro.Text = "Novo Registro";
            this.novoregistro.UseVisualStyleBackColor = true;
            this.novoregistro.Click += new System.EventHandler(this.novoregistro_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(518, 168);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(65, 35);
            this.salvar.TabIndex = 2;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sobrenomeDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // banco_de_dadosDataSet
            // 
            this.banco_de_dadosDataSet.DataSetName = "Banco_de_dadosDataSet";
            this.banco_de_dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasBindingSource5
            // 
            this.pessoasBindingSource5.DataMember = "Pessoas";
            this.pessoasBindingSource5.DataSource = this.banco_de_dadosDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.novoregistro);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.Proxima);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_dadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button Proxima;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button novoregistro;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.BindingSource pessoasBindingSource1;
        private System.Windows.Forms.BindingSource pessoasBindingSource2;
        private System.Windows.Forms.BindingSource pessoasBindingSource3;
        private System.Windows.Forms.BindingSource pessoasBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eamailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Banco_de_dadosDataSet banco_de_dadosDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource5;
        private Banco_de_dadosDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

