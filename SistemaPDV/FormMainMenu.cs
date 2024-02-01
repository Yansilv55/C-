using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Speech.Synthesis; //AI
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FormMainMenu : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;        
        //variaveis para buscar o ultimo ano
        Int32 ano;
        DateTime data = DateTime.Now;
        string dataInicial, dataFinal;
        //
        public string bkpFeito;

        //temporizador
        int Segundos, SegundosOut;

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //tabela reservas
        public int tab;

        //foto
        string foto;

        //apresentacao
        string bomDia, boaTarde, boaNoite, apresentacao;
        //som
        bool marcado = true;

       

        DateTime data1 = DateTime.Now;

        public class OcupaQuartos
        {
            public string nomeQuarto { get; set; }
        }        

        //Constructor
        public FormMainMenu()
        {    
            InitializeComponent();           

            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //mudar cor menu
            menuStrip1.Renderer = new MyRenderer();
            //
        }
        //mudar cor menu- continua
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(45, 66, 91); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.LimeGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(45, 66, 91); }
            }
            public override System.Drawing.Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(45, 66, 91); }
            }
            public override System.Drawing.Color MenuItemPressedGradientEnd
            {
                get { return Color.LimeGreen; }
            }
            public override System.Drawing.Color MenuItemBorder
            {
                get { return Color.LimeGreen; }
            }
        }
        //fim mudar cor menu 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmCaixa(), sender);
        }
        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmMovimentacoes(), sender);
        }
        private void btnLancarDespesas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmGastos(), sender);
        }
        private void btnBkp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RestauraBackup.FrmBackup(), sender);
        }
        
        public void resetar()
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        public void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            AtualizaTela();
            resetar();            
        }

        public void Reset()
        {
            //USADO PARA AO FECHAR OUTRO FORM O QUARDO DO PRINCIPAL ATUALIAZAR O QUADRO DE OCUPAÇÕES
            DiaMesAno();
            AtualizaTela();

            DisableButton();
            lblTitle.Text = "TELA PRINCIPAL";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void FormMainMenu_Activated(object sender, EventArgs e)
        {            
            AtualizaTela();  
        }
        
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            data1 = DateTime.Now;
            VerificarNivelUsuario();
            lblData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss"); // adicionado um Timer_Ticker p/ mostar os segundos em tempo real...
            lblUsuario.Text = Program.NomeUsuario;
            lblCargo.Text = Program.CargoUsuario;
            toollblUsuario.Text = "Tenha uma ótima jornada de trabalho " + Program.NomeUsuario + ".";
            toolStripLabelData.Text = lblData.Text;
            toolLabelAno.Text = data.Year.ToString();
            ano = data.Year - 1;           
            dataInicial = "01/01/" + ano;
            dataFinal = "31/12/" + ano;
            AtualizaTela();
            //IA();                        
        }
       
        private void IA()
        {
            if (marcado==true)
            {
                apresentacao = toollblUsuario.Text;
                if (DateTime.Now.Hour < 12)
                {
                    bomDia = "Bom Dia: ";
                    new SpeechSynthesizer().Speak(bomDia +  ": "+ apresentacao);
                }
                else if (DateTime.Now.Hour < 17)
                {
                    boaTarde = "Boa Tarde: ";
                    new SpeechSynthesizer().Speak(boaTarde + " :" + apresentacao);
                }
                else
                {
                    boaNoite = "Boa noite: ";
                    new SpeechSynthesizer().Speak(boaNoite +  apresentacao);
                }
            }                       
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
                this.Dispose();
                Application.Exit();
            }
            
        }
        //CADASTRO
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmFuncionarios(), sender);
        }

        private void menuFuncionarios_Click(object sender, EventArgs e)
        {
            btnFuncionario.PerformClick();
        }

        private void btnHopede_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmClientes(), sender);
        }

        private void menuHospedes_Click(object sender, EventArgs e)
        {
            AtualizaTela();
            btnHopede.PerformClick();
        }  

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmUsuarios(), sender);
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuario.PerformClick();
        }

        public void btnServico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmServicos(), sender);
        }
        
        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnNovoProduto.PerformClick();
        }
        private void btnCargo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmCargos(), sender);
        }

        private void menuCargos_Click(object sender, EventArgs e)
        {
            btnCargo.PerformClick();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmFornecedores(), sender);
        }

        private void menuFornecedores_Click(object sender, EventArgs e)
        {
            btnFornecedor.PerformClick();
        }
               
        private void btnAno_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastros.FrmAnoVirgente(), sender);
        }
        private void menuAno_Click(object sender, EventArgs e)
        {
            btnAno.PerformClick();
        }
        //PRODUTOS
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Produtos.FrmProdutos(), sender);
        }
        private void NovoProduto_Click(object sender, EventArgs e)
        {
            btnNovoProduto.PerformClick();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Produtos.FrmEstoque(), sender);
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            //btnEstoque.PerformClick();
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://zatec.app.br/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Não foi possivél acessar este site, tente mais tarde.");
            }

        }

        private void btnNivelEstoque_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Produtos.FrmEstoqueBaixo(), sender);
        }       

        private void NívelDeEstoque_Click(object sender, EventArgs e)
        {
            btnNivelEstoque.PerformClick();
        }
        private void EntradaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btnEntradaProduto.PerformClick();
        }
        private void img_Click(object sender, EventArgs e)
        {
            btnNivelEstoque.PerformClick();
        }

        //MOVIMENTAÇÕES
        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFluxoCaixa.PerformClick();
        }
        
        public void NovaVenda_Click(object sender, EventArgs e)
        {
            btnNovaVenda.PerformClick();// usado tb no aactive quando é chamado em Resumo de consumo
        }        
        
        private void EntradaESaídas_Click(object sender, EventArgs e)
        {
            btnMovimentacoes.PerformClick();
        }
        
        private void btnGastos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmGastos(), sender);
        }

        private void Gastos_Click(object sender, EventArgs e)
        {
            btnGastos.PerformClick();
        }
       
        private void históricoDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnHistoricoConsumo.PerformClick();
        }

        private void MovimentacaoGeral_Click(object sender, EventArgs e)
        {
            btnRelatorio.PerformClick();
        }        

        private void Produtos_Click(object sender, EventArgs e)
        {
            btnRelProdutos.PerformClick();
        }
        
        private void Vendas_Click(object sender, EventArgs e)
        {
            btnRelVendas.PerformClick();
        }
               
        private void EntradaSaidas_Click(object sender, EventArgs e)
        {
            btnRelEntradaSaida.PerformClick();
        }

        private void RelGatos_Click(object sender, EventArgs e)
        {
            btnRelGastos.PerformClick();
        }        
        //RELATORIO LISTA DE HOSPEDES        
        private void listarHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnListaHospede.PerformClick();
        }
        
        private void históricoCheckListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnListarLimpeza.PerformClick();
        }
        
        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCaixa.PerformClick();
        }
        
        private void btnVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Vendas.FrmVendas(), sender);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmHistorico(), sender);
        }

        private void btnFluxoCaixa_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender); foi p/ testar 
            OpenChildForm(new Movimentacoes.FrmCaixa(), sender);
        }
        
        private void MenuLimparReservas_Click(object sender, EventArgs e)
        {
            btnLimparReserva.PerformClick();
        }

        private void btnLimparMovimentacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmLimparDadosMovimentacoes(), sender);
        }

        private void MenuLimparTodasMovimentacoes_Click(object sender, EventArgs e)
        {
            btnLimparMovimentacao.PerformClick();
        }

        private void btnLimparDetalheVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmLimparDadosDetalhesVendas(), sender);
        }

        private void MenuLimparDetalhesDasvendas_Click(object sender, EventArgs e)
        {
            btnLimparDetalheVenda.PerformClick();
        }
        private void btnLimparGatos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmLimparDadosGastos(), sender);
        }

        private void MenuLimparGatos_Click(object sender, EventArgs e)
        {
            btnLimparGatos.PerformClick();
        }

        private void btnLimpaNovoServico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmLimparDadosNovoServico(), sender);
        }
                
        private void btnLimparVendas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmLimparDadosVendas(), sender);
        }

        private void MenuLimparVendas_Click(object sender, EventArgs e)
        {
            btnLimparVendas.PerformClick();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RestauraBackup.FrmRestaura(), sender);
        }

        private void MenuRestaurarBackup_Click(object sender, EventArgs e)
        {
            btnRestaurar.PerformClick();
        }
        
        private void fazerBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBkp.PerformClick();
        }
        private void solicitarSuporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSuporte.PerformClick();
        }
        private void btnSuporte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Message.FrmSuporte(), sender);
        }
        private void menuSuporte_Click(object sender, EventArgs e)
        {
            btnSuporte.PerformClick();
        }
        
        private void VerificarNivelUsuario()
        {
            if (Program.CargoUsuario == "Gerente" || Program.CargoUsuario == "Supervisor" || Program.CargoUsuario == "gerente" || Program.CargoUsuario == "supervisor")
            {
                menuFuncionarios.Enabled = true;
                menuUsuarios.Enabled = true;
                menuCargos.Enabled = true;
                EntradaESaídas.Enabled = true;
                //limpar dados
                MenuLimparTodasMovimentacoes.Enabled = true;
                MenuLimparGatos.Enabled = true;
                MenuLimparVendas.Enabled = true;
                MenuLimparDetalhesDasvendas.Enabled = true;                
            }
        }

        //hora no sistema
        private void horaSistema_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            StripLabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblUsuario.Text = Program.NomeUsuario;
            lblCargo.Text = Program.CargoUsuario;         
        }        
        //COMPARA ESTOQUE SE ESTAR ABAIXO DO MINIMO
        private void VerificarEstoque()
        {
            try
            {
                con.AbrirConexao();
                //sql = "SELECT * FROM produtos WHERE estoque < @estoque";
                sql = "SELECT pro.id, pro.cod, pro.nome, pro.descricao, pro.estoque, forn.nome, pro.entrada, pro.total_compra, pro.valor_compra, pro.valor_venda, pro.data, pro.imagem, pro.fornecedor, pro.minimo, pro.nota  FROM produtos as pro INNER JOIN fornecedores as forn  ON pro.fornecedor = forn.id WHERE estoque < pro.minimo ORDER BY pro.nome asc";
                cmd = new MySqlCommand(sql, con.con);
                //cmd.Parameters.AddWithValue("@estoque", 15);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblEstoque.Text = "Estoque baixo";
                    imgEstoque.Image = Properties.Resources.cestaVazia;
                }
                else
                {
                    lblEstoque.Text = "Estoque normal";
                    imgEstoque.Image = Properties.Resources.cestaOK;
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! algo deu errado. Mas não há o que se preocupar! Basta fechar o Sistema e abri-lo. "+ ex);
            }
            
        }
        //atualizar dados na tela
        public void AtualizaTela()
        {            
            VerificarEstoque();
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }        
        private void contador_Tick(object sender, EventArgs e)
        {
            if (Segundos > 0)
            {
                //lblContador.Visible = true;
                //lblContador.Text = Segundos.ToString();
                Segundos--;
            }
            else
            {
                this.contador.Stop();
                //labelConteudoIn.Visible = false;
                //lblContador.Visible = false;
            }
        }
        private void timerContador_Tick(object sender, EventArgs e)
        {
            if (SegundosOut > 0)
            {
                //lblContadorout.Visible = true;
                //lblContadorout.Text = SegundosOut.ToString();
                SegundosOut--;
            }
            else
            {
                this.timerContador.Stop();
                //labelConteudoOut.Visible = false;
                //lblContadorout.Visible = false;
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaTela();
        }         
                
        private void btnHistoricoConsumo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Movimentacoes.FrmHistorico(), sender); 
        }        

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://www.zatec.app.br/");
            }
            catch (Exception )
            {
                MessageBox.Show("Não foi possivél acessar este site, tente mais tarde.");
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Message.FrmHelp frm = new Message.FrmHelp();
            //frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //btnEstoque.PerformClick();
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://zatec.app.br");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivél acessar este site, tente mais tarde.");
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //btnEstoque.PerformClick();
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCG81w04haubRQaJWNl9cWUw");
            }
            catch (Exception )
            {
                MessageBox.Show("Não foi possivél acessar este site, tente mais tarde.");
            }
        }        

        private void DesabilitarMenu()
        {
            btnFluxoDeCaixa.Enabled = false;
            btnMovimentacoes.Enabled = false;            
            btnRelatorio.Enabled = false;

            cadastrosToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            movimentaçõesToolStripMenuItem.Enabled = false;
           
            MenuRelatorios.Enabled = false;
            MenuFerramenta.Enabled = false;
            menuSuporte.Enabled = false;
            MenuSair.Enabled = false;
        }
        public void HabilitarMenu()
        {
            btnFluxoDeCaixa.Enabled = true;
            btnMovimentacoes.Enabled = true;           
            btnRelatorio.Enabled = true;

            cadastrosToolStripMenuItem.Enabled = true;
            produtosToolStripMenuItem.Enabled = true;
            movimentaçõesToolStripMenuItem.Enabled = true;
            
            MenuRelatorios.Enabled = true;
            MenuFerramenta.Enabled = true;
            menuSuporte.Enabled = true;
            MenuSair.Enabled = true;
        }              
        private void emitirComprovanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.stausComprovante = "Quitado";
            btnHistoricoConsumo.PerformClick();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Relatorios.FrmRelMovimentacao(), sender);
        }

        private void ativarLicençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message.FrmRegistrar frm = new Message.FrmRegistrar();
            frm.ShowDialog();
        }

        private void img1_Click(object sender, EventArgs e)
        {
            btnNovaVenda.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnMovimentacoes.PerformClick();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btnGastos.PerformClick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btnFluxoCaixa.PerformClick();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Vendas.FrmVendas(), sender);
        }

        private void gerarLicençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message.FrmGerador frm = new Message.FrmGerador();
            frm.ShowDialog();
        }

        private void informaçõesDeLicençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message.FrmAbout frm = new Message.FrmAbout();
            frm.ShowDialog();
        }

        private void btnAtivarLicenca_Click(object sender, EventArgs e)
        {
            Message.FrmRegistrar frm = new Message.FrmRegistrar();
            frm.ShowDialog();
        }

        private void btnSolicitarAtivacao_Click(object sender, EventArgs e)
        {
            Message.FrmGerador frm = new Message.FrmGerador();
            frm.ShowDialog();
        } 
        private void DiaMesAno()
        {

            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
           // dtEntrada.Text = primeiroDia.ToString();            

            //Ultimo data do mês
            DateTime dtUltimoDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            //dtSaida.Text = dtUltimoDiaMes.ToString();
        }

    }//final
}