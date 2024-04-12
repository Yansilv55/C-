using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DAO;
using MODEL;
using MySql.Data.MySqlClient;

namespace Moderno.cadastross
{
    public partial class Frm_Clinte : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        private string cliente_id;
        private string cpfAntigo;
        private string celAntigo;
        private string cliente;
        string alterouImagem = "nao";
        string radButton = "";
        private String desbloqueado, inadiplente;
        bool emailAdress = false;
        private bool campoClicado = false;

        int idcliente, IdAnterior;
        public Frm_Clinte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Clinte_Load(object sender, EventArgs e)
        {
            Listar();
            rb_Nome.Checked = true;
            cb_Inadiplente.SelectedItem = 0;
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "Cliente_ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Cpf";
            grid.Columns[3].HeaderText = "Em Aberto";
            grid.Columns[4].HeaderText = "Telefone";
            grid.Columns[5].HeaderText = "Email";
            grid.Columns[6].HeaderText = "Desbloqueado";
            grid.Columns[7].HeaderText = "Status";
            grid.Columns[8].HeaderText = "Endereço";
            grid.Columns[9].HeaderText = "Fucionário";
            grid.Columns[10].HeaderText = "igm";
            grid.Columns[11].HeaderText = "Data";
            grid.Columns[10].Visible = false;
            grid.Columns[4].DefaultCellStyle.Format = "c2";
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

            FormatarGD();
        }

        private void BuscarNome()
        {

            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE nome LEKE @nome ORDER BY nome asc"; 
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", lb_BuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

            con.FecharConexao();
            FormatarGD();
        }

        private void BuscarCpf()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE cpf=@cpf ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cpf", lb_BuscarCpf.Text);
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
            txt_Nome.Enabled = true;
            txt_Cpf.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Celular.Enabled = true;
            txt_Email.Enabled = true;
            cb_Inadiplente.Enabled = true;
            txt_ValorAberto.Enabled = true;
            txt_Nome.Focus();
        }
       
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Cpf.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Celular.Enabled = false;
            txt_Email.Enabled = false;
            cb_Inadiplente.Enabled = false;
            txt_ValorAberto.Enabled = false;
        }
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Cpf.Text = "";
            txt_Endereco.Text = "";
            txt_Celular.Text = "";
            txt_Email.Text = "";
            if (cb_Inadiplente.Items.Count > 0)
            {
                cb_Inadiplente.SelectedIndex = 0;
            }
        }
        private void Status()
        {
            radButton = rbAtivado.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked)?.Text;
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void verificarEmail()
        {
            string email = txt_Email.Text;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (rg.IsMatch(email))
            {
                emailAdress = true;
                btn_Salvar.Enabled = true;
                img_Email.Image = Properties.Resources.icons8_ok_24px;
            }
            else
            {
                emailAdress = false;
                btn_Salvar.Enabled = false;
                img_Email.Image = Properties.Resources.icons8_multiply_26px;
            }
        }
        private void ultimoIdCliente()
        {
            con.AbrirConexao();
            MySqlCommand connVerificar;
            MySqlDataReader reader;
            sql = "SELECT cliente_id FROM clientes ORDER BY cliente_id DESC LIMIT 1";
            connVerificar = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdAnterior = Convert.ToInt32(reader["cliente_id"]);
                    idcliente = IdAnterior + 1;
                }
            }
        }
        private bool VerificarCampo()
        {
            string cpf = txt_Cpf.Text;
            string numeroCpf = new string(cpf.Where(char.IsDigit).ToArray());
            string celular = txt_Celular.Text;
            string numerocel = new string(celular.Where(char.IsDigit).ToArray());

            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return false;
            }
            if (!CPFValidator.ValidateCPF(numeroCpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return false;
            }
            if (numerocel.Length != 11)
            {
                MessageBox.Show("preencha o Campo Telefone.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Celular.Focus();
                return false;
            }
            if (emailAdress)
            {
                MessageBox.Show("Email invalido", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }
            return true;
        }
        private bool VerificarDuplicidade()
        {
            ClienteDAO ClienteDAO = new ClienteDAO();
            ClienteMODEL cliente = new ClienteMODEL();
            cliente.cpf = txt_Cpf.Text;
            cliente.celular = txt_Celular.Text;
            if (txt_Cpf.Text != cpfAntigo)
            {
                if (ClienteDAO.VerificarDuplicidadeFuncionario(cliente.cliente_id, "cpf", cliente.cpf.ToString()))
                {
                    MessageBox.Show("CPF já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Cpf.Text = "";
                    txt_Cpf.Focus();
                    return true;
                }
            }
            if (txt_Celular.Text != celAntigo)
            {
                if (ClienteDAO.VerificarDuplicidadeFuncionario(cliente.cliente_id, "telefone", cliente.celular.ToString()))
                {
                    MessageBox.Show("Celular já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Celular.Text = "";
                    txt_Celular.Focus();
                    return true;
                }
            }
            return false;
        }
        private void SalvarRegistro()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteMODEL cliente = new ClienteMODEL();
            cliente.nome = txt_Nome.Text;
            cliente.cpf = txt_Cpf.Text;
            cliente.celular = txt_Celular.Text;
            cliente.email = txt_Email.Text;
            cliente.endereco = txt_Endereco.Text;
            if (VerificarCampo())
            {
                return;
            }
            if (VerificarDuplicidade())
            {
                return;
            }
            if (rb_Ativado.Checked == true)
            {
                //botao salvar
                clienteDAO.Salvar_registro_ativado(cliente);     
            }
            else if (rb_Ativado.Checked == false)
            {
                //botao salvar
                clienteDAO.Salvar_registro_desativado(cliente);
            }
            Status();
            MessageBox.Show("Clientes " + txt_Nome.Text + " estar " + radButton + " e salvo com sucesso!", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarRegistro();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            lb_BuscarNome.Visible = false;
            lb_BuscarCpf.Visible = true;
            lb_BuscarCpf.Text = "";
            lb_BuscarNome.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void EditarRegistro()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteMODEL cliente = new ClienteMODEL();
            cliente.nome = txt_Nome.Text;
            cliente.cpf = txt_Cpf.Text;
            cliente.celular = txt_Celular.Text;
            cliente.email = txt_Email.Text;
            cliente.Inadiplente = cb_Inadiplente.Text;
            cliente.endereco = txt_Endereco.Text;
            con.AbrirConexao();
            
            if (VerificarCampo())
            {
                return;
            }
            if (VerificarDuplicidade())
            {
                return;
            }
            if (rb_Ativado.Checked == true)
            {
                    clienteDAO.Editar_cliente_ativado(cliente);
            }
            else if (rb_Ativado.Checked == false)
            {
                   clienteDAO.Editar_cliente_desativado(cliente);
            }
            Status();
            MessageBox.Show("Registro Editado com sucesso: Clientes " + txt_Nome.Text + " " + radButton, "Cadastro Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            Listar();
            DesabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarRegistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ExcluirRegistro()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteMODEL clienteMODEL = new ClienteMODEL();
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                clienteDAO.Excluir_cliente(clienteMODEL);
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                ExcluirRegistro();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            grid.ClearSelection();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                HabilitarCampos();
                cliente_id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Cpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txt_ValorAberto.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txt_Celular.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Email.Text = grid.CurrentRow.Cells[5].Value.ToString();
                desbloqueado = grid.CurrentRow.Cells[6].Value.ToString();
                cb_Inadiplente.Text = grid.CurrentRow.Cells[7].Value.ToString();
                txt_Endereco.Text = grid.CurrentRow.Cells[8].Value.ToString();

                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = false;
            }
            else
            {
                campoClicado = false;
            }

        }
        
        private void lb_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            if (lb_BuscarNome.TextLength > 0)
            {
                BuscarNome();
            }
            else if (lb_BuscarNome.TextLength == 0)
            {
                Listar();
            }
        }

        private void lb_BuscarCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (lb_BuscarCpf.Text == "   .   .   -")
            {
                Listar();
            }
            else
            {
                BuscarCpf();
            }
        }
        private void rb_Nome_Click(object sender, EventArgs e)
        {
            rb_Nome.Focus();
            LimparCampos();
        }

        private void rb_Cpf_Click(object sender, EventArgs e)
        {
            rb_Cpf.Focus();
            LimparCampos();
        }

        private void lb_Email_TextChanged(object sender, EventArgs e)
        {
           verificarEmail();
        }
        public class CPFValidator
        {
            public static bool ValidateCPF(string cpf)
            {
                cpf = cpf.Trim().Replace(".", "").Replace("-", "");

                if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                    return false;

                // Obtém os dígitos verificadores
                string digitosVerificadores = cpf.Substring(9, 2);

                // Calcula o primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (10 - i);
                }
                int resto = soma % 11;
                int primeiroDigito = resto < 2 ? 0 : 11 - resto;

                // Verifica se o primeiro dígito verificador está correto
                if (primeiroDigito != int.Parse(digitosVerificadores[0].ToString()))
                    return false;

                // Calcula o segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (11 - i);
                }
                resto = soma % 11;
                int segundoDigito = resto < 2 ? 0 : 11 - resto;

                // Verifica se o segundo dígito verificador está correto
                if (segundoDigito != int.Parse(digitosVerificadores[1].ToString()))
                    return false;

                return true;
            }
        }
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
        private void formatarTextNumero(object sender, KeyPressEventArgs e)
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

        private void cb_Inadiplente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lb_ValorAberto_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatarTextNumero(sender, e);
        }

        private void rb_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            lb_BuscarNome.Visible = false;
            lb_BuscarCpf.Visible = true;
            lb_BuscarCpf.Focus();
            lb_BuscarCpf.Enabled = true;
        }

        private void rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            lb_BuscarCpf.Visible = false;
            lb_BuscarNome.Visible = true;
        }

        private void lb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Cpf.Focus();
            }
        }

        private void lb_Cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ValorAberto.Focus();
            }
        }

        private void lb_ValorAberto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Endereco.Focus();
            }
        }

        private void lb_Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Celular.Focus();
            }
        }

        private void lb_Telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_Inadiplente.Focus();
            }
        }

        private void cb_Inadiplente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Email.Focus();
            }
        }
        private void lb_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (campoClicado)
                {
                    btn_Editar.PerformClick();
                }
                else
                {
                    btn_Salvar.PerformClick();
                }
            }
        }
    }
 };
