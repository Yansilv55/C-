using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Moderno.cadastross
{
    public partial class Frm_Clinte : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        string cpfAntigo;
        string cliente;
        string foto;
        string alterouImagem = "nao";
        string radButton = "";
        String desbloqueado, inadiplente;
        bool emailAdress = false;

        int codCliente, IdAnterior;
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
            LimparFoto();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Código";
            grid.Columns[2].HeaderText = "Nome";
            grid.Columns[3].HeaderText = "Cpf";
            grid.Columns[4].HeaderText = "Em Aberto";
            grid.Columns[5].HeaderText = "Telefone";
            grid.Columns[6].HeaderText = "Email";
            grid.Columns[7].HeaderText = "Desbloqueado";
            grid.Columns[8].HeaderText = "Status";
            grid.Columns[9].HeaderText = "Endereço";
            grid.Columns[10].HeaderText = "Fucionário";
            grid.Columns[11].HeaderText = "igm";
            grid.Columns[12].HeaderText = "Data";
            //grid.Columns[0].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[11].Visible = false;
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
            lb_Nome.Enabled = true;
            lb_Cpf.Enabled = true;
            lb_Endereco.Enabled = true;
            lb_Telefone.Enabled = true;
            lb_Email.Enabled = true;
            cb_Inadiplente.Enabled = true;
            lb_ValorAberto.Enabled = true;
            lb_codigo.Enabled = true;
            lb_Nome.Focus();
        }
       
        private void DesabilitarCampos()
        {
            lb_Nome.Enabled = false;
            lb_Cpf.Enabled = false;
            lb_Endereco.Enabled = false;
            lb_Telefone.Enabled = false;
            lb_Email.Enabled = false;
            cb_Inadiplente.Enabled = false;
            lb_ValorAberto.Enabled = false;
        }

        private void LimparCampos()
        {
            lb_Nome.Text = "";
            lb_Cpf.Text = "";
            lb_Endereco.Text = "";
            lb_Telefone.Text = "";
            lb_Email.Text = "";
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
            LimparFotos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = true;
        }

        private void verificarEmail()
        {
            string email = lb_Email.Text;

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
            sql = "SELECT id FROM clientes ORDER BY id DESC LIMIT 1";
            connVerificar = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            reader = connVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdAnterior = Convert.ToInt32(reader["id"]);
                    codCliente = IdAnterior + 1;
                }
            }
        }
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
          /*  if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }
            if (lb_Cpf.Text == "   .   .   -" || lb_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Cpf.Focus();
                return;
            }
            if (emailAdress)
            {
                MessageBox.Show("Email invalido", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Email.Focus();
                return;
            }*/
            if (rb_Ativado.Checked == true)
            {
                //botao salvar
                con.AbrirConexao();
                sql = "INSERT INTO clientes(codigo, nome, cpf, valorAberto, tel, email, desbloqueado, Inadiplente, endereco, imagem, data) VALUES(@codigo, @nome, @cpf, @valorAberto, @tel, @email, @desbloqueado, @Inadiplente, @endereco, @imagem, curDate())";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@codigo", codCliente);
                conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                conn.Parameters.AddWithValue("@valorAberto", 0);
                conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                conn.Parameters.AddWithValue("@email", lb_Email.Text);
                conn.Parameters.AddWithValue("@desbloqueado", "Sim");
                conn.Parameters.AddWithValue("@Inadiplente", "Não");
                conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
               // conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.Parameters.AddWithValue("@imagem", img());            
            }
            else if (rb_Ativado.Checked == false)
            {
                //botao salvar
                con.AbrirConexao();
                sql = "INSERT INTO clientes(codigo, nome, cpf, valorAberto, tel, email, desbloqueado, Inadiplente, endereco, imagem, data) VALUES(@codigo, @nome, @cpf, @valorAberto, @tel, @email, @desbloqueado, @Inadiplente, @endereco, @imagem, curDate())";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@codigo", codCliente);
                conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                conn.Parameters.AddWithValue("@valorAberto", 0);
                conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                conn.Parameters.AddWithValue("@email", lb_Email.Text);
                conn.Parameters.AddWithValue("@desbloqueado", "Não");
                conn.Parameters.AddWithValue("@Inadiplente", "Não");
                conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                //conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                conn.Parameters.AddWithValue("@imagem", img()); 
            }
            //Verificar se cpf ja existe  


            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand("SELECT * FROM clientes WHERE cpf = @cpf", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("CPF já registrado", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lb_Cpf.Text = "";
                lb_Cpf.Focus();
                return;
            }
            conn.Connection = con.con;
            conn.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();
            Status();
            MessageBox.Show("Clientes " + lb_Nome.Text + " estar " + radButton + " e salvo com sucesso!", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = false;

        }
        private void LimparFoto()
        {
            image.Image = Properties.Resources.icons8_person_32px;
            foto = "img/icons8_person_32px.png";
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
            LimparFoto();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }
            if (lb_Cpf.Text == "   .   .   -" || lb_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Cpf.Focus();
                return;
            }
            if (emailAdress == false)
            {
                MessageBox.Show("email inválido!");
                lb_Email.Focus();
                return;
            }

            //botao editar
            con.AbrirConexao();

            if (alterouImagem == "sim")
            {
               if (rb_Ativado.Checked == true)
                {
                    sql = "UPDATE clientes SET codigo=@codigo, nome=@nome, cpf=@cpf, valorAberto=@valorAberto, tel=@tel, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario, imagem=@imagem WHERE id=@id";
                    conn = new MySqlCommand(sql, con.con);
                    conn.Parameters.AddWithValue("@id", id); //where
                    conn.Parameters.AddWithValue("@codigo", lb_codigo.Text);
                    conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                    conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                    conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(lb_ValorAberto.Text));
                    conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                    conn.Parameters.AddWithValue("@email", lb_Email.Text);
                    conn.Parameters.AddWithValue("@desbloqueado", "Sim");
                    conn.Parameters.AddWithValue("@Inadiplente", cb_Inadiplente.Text);
                    conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                    conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                    conn.Parameters.AddWithValue("@imagem", img());

                }
                else if (rb_Ativado.Checked == false)
                {
                    sql = "UPDATE clientes SET codigo=@codigo, nome=@nome, cpf=@cpf, valorAberto=@valorAberto, tel=@tel, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario, imagem=@imagem WHERE id=@id";
                    conn = new MySqlCommand(sql, con.con);
                    conn.Parameters.AddWithValue("@id", id); //where
                    conn.Parameters.AddWithValue("@codigo", lb_codigo.Text);
                    conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                    conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                    conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(lb_ValorAberto.Text));
                    conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                    conn.Parameters.AddWithValue("@email", lb_Email.Text);
                    conn.Parameters.AddWithValue("@desbloqueado", "Não");
                    conn.Parameters.AddWithValue("@Inadiplente", cb_Inadiplente.Text);
                    conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                    conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                    conn.Parameters.AddWithValue("@imagem", img());

                }
            }
            else if (alterouImagem == "nao")
            {
                if (rb_Ativado.Checked == true)
                {
                    sql = "UPDATE clientes SET codigo=@codigo, nome=@nome, cpf=@cpf, valorAberto=@valorAberto, tel=@tel, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario WHERE id=@id";
                    conn = new MySqlCommand(sql, con.con);
                    conn.Parameters.AddWithValue("@id", id); //where
                    conn.Parameters.AddWithValue("@codigo", lb_codigo.Text);
                    conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                    conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                    conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(lb_ValorAberto.Text));
                    conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                    conn.Parameters.AddWithValue("@email", lb_Email.Text);
                    conn.Parameters.AddWithValue("@desbloqueado", "Sim");
                    conn.Parameters.AddWithValue("@Inadiplente", cb_Inadiplente.Text);
                    conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                    conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);

                }
                else if (rb_Ativado.Checked == false)
                {
                    sql = "UPDATE clientes SET codigo=@codigo, nome=@nome, cpf=@cpf, valorAberto=@valorAberto, tel=@tel, email=@email, desbloqueado=@desbloqueado, Inadiplente=@Inadiplente, endereco=@endereco, funcionario=@funcionario WHERE id=@id";
                    conn = new MySqlCommand(sql, con.con);
                    conn.Parameters.AddWithValue("@id", id); //where
                    conn.Parameters.AddWithValue("@codigo", lb_codigo.Text);
                    conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                    conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                    conn.Parameters.AddWithValue("@valorAberto", Convert.ToDouble(lb_ValorAberto.Text));
                    conn.Parameters.AddWithValue("@tel", lb_Telefone.Text);
                    conn.Parameters.AddWithValue("@email", lb_Email.Text);
                    conn.Parameters.AddWithValue("@desbloqueado", "Não");
                    conn.Parameters.AddWithValue("@Inadiplente", cb_Inadiplente.Text);
                    conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                    conn.Parameters.AddWithValue("@funcionario", Program.NomeUsuario);
                }
            }

            //Verificar se cpf ja existe
            if (lb_Cpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM clientes WHERE cpf = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lb_Cpf.Text = "";
                    lb_Cpf.Focus();
                    return;
                }

            }
            conn.ExecuteNonQuery();
            con.FecharConexao();
            Status();
            MessageBox.Show("Registro Editado com sucesso: Clientes " + lb_Nome.Text + " " + radButton, "Cadastro Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            Listar();
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = false;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //botao excluir
                con.AbrirConexao();
                sql = "DELETE FROM clientes WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();

                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_foto.Enabled = false;

                DesabilitarCampos();
                LimparCampos();
                LimparFoto();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparFoto();
            DesabilitarCampos();
            grid.ClearSelection();
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_foto.Enabled = false;

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               // LimparFoto();
                HabilitarCampos();
                id = grid.CurrentRow.Cells[0].Value.ToString();
                lb_codigo.Text = grid.CurrentRow.Cells[1].Value.ToString();
                lb_Nome.Text = grid.CurrentRow.Cells[2].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[3].Value.ToString();
                lb_Cpf.Text = grid.CurrentRow.Cells[3].Value.ToString();
                lb_ValorAberto.Text = grid.CurrentRow.Cells[4].Value.ToString();
                lb_Telefone.Text = grid.CurrentRow.Cells[5].Value.ToString();
                lb_Email.Text = grid.CurrentRow.Cells[6].Value.ToString();
                desbloqueado = grid.CurrentRow.Cells[7].Value.ToString();
                cb_Inadiplente.Text = grid.CurrentRow.Cells[8].Value.ToString();
                lb_Endereco.Text = grid.CurrentRow.Cells[9].Value.ToString();

                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_foto.Enabled = true;
                btn_Novo.Enabled = false;
                if (desbloqueado == "Sim")
                {
                    rb_Ativado.Checked = true;
                    rb_Inativado.Checked = false;
                }
                else if (desbloqueado == "Não")
                {
                    rb_Ativado.Checked = false;
                    rb_Inativado.Checked = true;
                }
                if (grid.CurrentRow.Cells[11].Value != DBNull.Value) 
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[11].Value; 
                    MemoryStream ms = new MemoryStream(imagem); 

                    
                    image.Image = System.Drawing.Image.FromStream(ms); 
                }
                else
                {
                    image.Image = Properties.Resources.icons8_person_32px;
                }
            }
            else
            {
                return;
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

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png"; 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString(); 
                image.ImageLocation = foto; 
                alterouImagem = "sim";
            }
        }

        private void rb_Nome_Click(object sender, EventArgs e)
        {
            rb_Nome.Focus();
            LimparFoto();
            LimparCampos();
        }

        private void rb_Cpf_Click(object sender, EventArgs e)
        {
            rb_Cpf.Focus();
            LimparFoto();
            LimparCampos();
        }

        private void lb_Email_TextChanged(object sender, EventArgs e)
        {
           verificarEmail();
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
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        private byte[] img()
        {
            byte[] image_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image_byte = br.ReadBytes((int)fs.Length);
            return image_byte;
        }

        private void LimparFotos()
        {
            image.Image = Properties.Resources.icons8_person_32px;
            foto = "img/icons8_person_32px.png";
        }

        

    }
 };
