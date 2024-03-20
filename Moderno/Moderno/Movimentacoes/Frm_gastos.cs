using DAO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Moderno.Movimentacoes
{
    public partial class Frm_gastos : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;
        string id;
        string ultimoIdGasto;
        string favorecido;
        String FormaPagto;
        double Pc = 0;
        double Pp = 0;
        double Pd = 0;
        public Frm_gastos()
        {
            InitializeComponent();
        }

        private void Frm_gastos_Load(object sender, EventArgs e)
        {
            dt_Buscar.Value = DateTime.Today;
            dt_Data.Value = DateTime.Today;
            cb_Pagto.SelectedIndex = 0;
            Listar();
            BuscarData();
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Descrição";
            grid.Columns[2].HeaderText = "Favorecido";
            grid.Columns[3].HeaderText = "Valor";
            grid.Columns[4].HeaderText = "Forma Pagto";
            grid.Columns[5].HeaderText = "Funcionário";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "N.Doc.:";
            grid.Columns[8].HeaderText = "Vencimento";

            grid.Columns[3].DefaultCellStyle.Format = "C2";
            grid.Columns[4].DefaultCellStyle.Format = "C2";
            //grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;

            //como os metodos Listar() e BuscarData() sempre chama o metodo FormatarGD(), ideal colocar o metodo Totalizando() aqui.
            Totalizando();
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM gastos ORDER BY data desc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }
        private void HabilitarCampos()
        {
            txt_Descricao.Enabled = true;
            txt_Favorecido.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Nota.Enabled = true;
            txt_Descricao.Focus();
            cb_Pagto.Enabled = true;
            dt_Data.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txt_Descricao.Enabled = false;
            txt_Favorecido.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Nota.Enabled = false;
            cb_Pagto.Enabled = false;
            dt_Data.Enabled = false;
        }
        private void LimparCampos()
        {
            txt_Descricao.Text = "";
            txt_Favorecido.Text = "";
            txt_Nota.Text = "";
            txt_Valor.Text = "";
            cb_Pagto.SelectedIndex = 0;
            //dt = "";
            dt_Data.Value = DateTime.Today;
        }
        private void BuscarData()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM gastos WHERE data = @data ORDER BY data desc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@data", Convert.ToDateTime(dt_Buscar.Text));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }
        private void listarPeriodo()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM gastos WHERE data>=@dataInicial AND data<=@dataFinal ORDER BY data DESC";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(dt_Inicial.Text));
            conn.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(dt_Final.Text));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                HabilitarCampos();

                //p/ fazer edicao na tabela 'movimentacoes' pq a edicao é baseada no campo id e campo 'movimento' e ambas tem q equivaler
                //favorecido = grid.CurrentRow.Cells[2].Value.ToString(); // era 'Gastos'
                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Descricao.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Favorecido.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Valor.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cb_Pagto.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Nota.Text = grid.CurrentRow.Cells[7].Value.ToString();
                dt_Data.Value = Convert.ToDateTime(grid.CurrentRow.Cells[8].Value.ToString());

            }
            else
            {
                return;
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            HabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher campo descrição !!!", "Cadastro de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Favorecido.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher campo destino !!!", "Cadastro de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher campo valor !!!", "Cadastro de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //dt = Convert.ToString(dtData.Text);

            //botao salvar
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO gastos(descricao, destino, valor, pagto, funcionario, data, nota, vencimento) VALUES(@descricao,  @destino, @valor, @pagto, @funcionario, curDate(), @nota, @vencimento)";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@descricao", txt_Descricao.Text);
                conn.Parameters.AddWithValue("@destino", txt_Favorecido.Text);
                conn.Parameters.AddWithValue("@valor", txt_Valor.Text.Replace(",", "."));
                conn.Parameters.AddWithValue("@pagto", FormaPagto);
                //conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.Parameters.AddWithValue("@nota", txt_Nota.Text);
                conn.Parameters.AddWithValue("@vencimento", Convert.ToDateTime(dt_Data.Text));
                conn.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO", "Cadastro Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //recuperar ultimo id do GASTO
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
            cmdVerificar = new MySqlCommand("SELECT id FROM gastos ORDER BY id DESC LIMIT 1", con.con); //selecionando o ultimo id 
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //extraíndo dados do id
                while (reader.Read())
                {
                    ultimoIdGasto = Convert.ToString(reader["id"]);
                }
            }
            con.FecharConexao();
            //fim recuperar ultimo id do GASTO

            //lançar valor do pedido nas movimentacoes
            con.AbrirConexao();
            sql = "INSERT INTO lancar_movimentacoes(cliente, tipo, movimento, descricao, valor, desconto, taxa, valor_total, cartao, pix, dinheiro, nota, valor_pago, funcionario, id_movimento, data) VALUES(@cliente, @tipo, @movimento, @descricao, @valor, @desconto, @taxa, @valor_total, @cartao, @pix, @dinheiro, @nota, @valor_pago, @funcionario, @id_movimento, @data)";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", txt_Favorecido.Text);
            conn.Parameters.AddWithValue("@tipo", "Saída");
            conn.Parameters.AddWithValue("@movimento", "Gastos");
            conn.Parameters.AddWithValue("@descricao", txt_Descricao.Text);//implementado p/ exibir na mov. 
            conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@desconto", 0);
            conn.Parameters.AddWithValue("@taxa", 0);
            conn.Parameters.AddWithValue("@valor_total", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@cartao", Pc);
            conn.Parameters.AddWithValue("@pix", Pp);
            conn.Parameters.AddWithValue("@dinheiro", Pd);
            conn.Parameters.AddWithValue("@nota", txt_Nota.Text);
            conn.Parameters.AddWithValue("@valor_pago", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@id_movimento", ultimoIdGasto);
            conn.Parameters.AddWithValue("@data", Convert.ToDateTime(dt_Data.Text));
            conn.ExecuteNonQuery();
            con.FecharConexao();

            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo descrição", "Cadastro gatos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Descricao.Text = "";
                txt_Descricao.Focus();
                return;
            }
            if (txt_Favorecido.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo destino", "Cadastro gatos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Descricao.Text = "";
                txt_Descricao.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo valor", "Cadastro gastos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }
            FormaPagto = cb_Pagto.Text;
            if (cb_Pagto.Text == "Dinheiro")
            {
                Pd = Convert.ToDouble(txt_Valor.Text) * -1;
                Pp = 0;
                Pc = 0;
            }
            else if (cb_Pagto.Text == "Pix")
            {
                Pp = Convert.ToDouble(txt_Valor.Text) * -1;
                Pd = 0;
                Pc = 0;
            }
            else if (cb_Pagto.Text == "Cartão")
            {
                Pc = Convert.ToDouble(txt_Valor.Text) * -1;
                Pd = 0;
                Pp = 0;
            }
            //botao editar
            con.AbrirConexao();
            sql = "UPDATE gastos SET descricao=@descricao, destino=@destino, valor=@valor, pagto=@pagto, funcionario=@funcionario, data=curDate(), nota=@nota, vencimento=@vencimento where id=@id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@descricao", txt_Descricao.Text);
            conn.Parameters.AddWithValue("@destino", txt_Favorecido.Text);
            conn.Parameters.AddWithValue("@valor", txt_Valor.Text.Replace(",", "."));
            conn.Parameters.AddWithValue("@pagto", FormaPagto);
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@nota", txt_Nota.Text);
            conn.Parameters.AddWithValue("@vencimento", Convert.ToDateTime(dt_Data.Text));
            conn.Parameters.AddWithValue("@id", id);
            conn.ExecuteNonQuery();
            con.FecharConexao();

            //atualizar valor na movimentaçao
            con.AbrirConexao();
            sql = "UPDATE lancar_movimentacoes SET cliente=@cliente, descricao = @descricao, valor=@valor, valor_total=@valor_total, cartao=@cartao, pix=@pix, dinheiro=@dinheiro, nota=@nota, valor_pago=@valor_pago, funcionario = @funcionario, data = curDate(), nota = @nota WHERE id_movimento = @id";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cliente", txt_Favorecido.Text);
            conn.Parameters.AddWithValue("@descricao", txt_Descricao.Text);
            conn.Parameters.AddWithValue("@valor", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@valor_total", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@cartao", Pc);
            conn.Parameters.AddWithValue("@pix", Pp);
            conn.Parameters.AddWithValue("@dinheiro", Pd);
            conn.Parameters.AddWithValue("@nota", txt_Nota.Text);
            conn.Parameters.AddWithValue("@valor_pago", Convert.ToDouble(txt_Valor.Text) * -1);
            conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
            conn.Parameters.AddWithValue("@data", Convert.ToDateTime(dt_Data.Text));
            conn.Parameters.AddWithValue("@id", id); //where
            conn.ExecuteNonQuery();
            con.FecharConexao();
            //fim atualizar valor no movimentaçao
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            Listar();
            MessageBox.Show("Registro Editado com sucesso!", "Cadastro gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                con.AbrirConexao();
                sql = "DELETE FROM gastos WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();

                //exclusao do movimento do gasto
                con.AbrirConexao();
                sql = "DELETE FROM lancar_movimentacoes WHERE id_movimento = @id AND movimento = @movimento";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.Parameters.AddWithValue("@movimento", "Gastos");
                //cmd.Parameters.AddWithValue("@movimento", movimento);
                conn.ExecuteNonQuery();
                con.FecharConexao();
                //fim exclusao do movimento da venda

                btn_Novo.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                Listar();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dt_Buscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }
        private void Totalizando()
        {
            double total = 0;
            //percorrendo cada linha da grid, p/ pegar e somar cada linha do array 'Valor'.
            foreach (DataGridViewRow row in grid.Rows)
            {
                //pegando a celular e somando
                //total += Convert.ToDouble(row.Cells["valor"].Value); //pode ser pelo indece tb
                total += Convert.ToDouble(row.Cells["valor"].Value); //era ..., agora o campo é...
            }
            lbl_Total.Text = Convert.ToDouble(total).ToString("C2");
        }

        private void formatarTextNumero(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -2)
                {
                    e.Handled = true;
                }


                if (e.KeyChar == ','
                    && (sender as TextBox).Text.IndexOf(',') > -2)
                {
                    e.Handled = true;
                }

                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        //TextBox ao digitar apresenta no formato moeda
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(2, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;

                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
            }
        }

        private void txt_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_Valor);
            Pd = Convert.ToDouble(txt_Valor.Text) * -1;
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void cb_Pagto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //double valor = double.Parse(txt_Valor.Text.Replace(".", ","));
                //Pd = valor * -1;
                FormaPagto = cb_Pagto.Text;
                if (txt_Valor.Text != "")
                {
                    if (cb_Pagto.Text == "Dinheiro")
                    {
                        Pd = Convert.ToDouble(txt_Valor.Text) * -1;
                        Pp = 0;
                        Pc = 0;
                    }
                    else if (cb_Pagto.Text == "Pix")
                    {
                        Pp = Convert.ToDouble(txt_Valor.Text) * -1;
                        Pd = 0;
                        Pc = 0;
                    }
                    else if (cb_Pagto.Text == "Cartão")
                    {
                        Pc = Convert.ToDouble(txt_Valor.Text) * -1;
                        Pd = 0;
                        Pp = 0;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Aqui você pode imprimir detalhes sobre a exceção para depuração, se necessário
                Console.WriteLine(ex.Message);
            }

        }

        private void dt_Inicial_ValueChanged(object sender, EventArgs e)
        {
            listarPeriodo();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            listarPeriodo();
        }
    }
}
