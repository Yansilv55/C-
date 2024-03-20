using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moderno.cadastross
{
    public partial class Frm_Funcionario : Form
    {
        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand conn;
        string id;
        string foto;
        string alterouImagem = "nao";
        string cpfAntigo;
        string celAntigo;
        private bool campoClicado = false;
        public Frm_Funcionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Funcionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            Listar_Cargos();
            alterouImagem = "nao";
            cb_Cargo.Text = "Selecione o Cargo";
            txt_Celular.Text = "(00) 0 0000-0000";
        }

        private void BuscarNome()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios WHERE nome LIKE @nome ORDER BY nome asc"; 
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", txt_BuscarNome.Text + "%");  
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
            sql = "SELECT * FROM funcionarios WHERE cpf = @cpf ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cpf", txt_BuscarCpf.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
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
                return;
            }
            if (!CPFValidator.ValidateCPF(numeroCpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
            if (numerocel.Length != 11)
            {
                MessageBox.Show("preencha o Campo Telefone.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Celular.Focus();
                return;
            }
            if (cb_Cargo.Text == "Selcionar cargo")
            {
                MessageBox.Show("Por favor preencha o Campo.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Cargo.Focus();
                return;
            }
            if (txt_Endereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Endereço.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Endereco.Text = "";
                txt_Endereco.Focus();
                return;
            }
            con.AbrirConexao();
            sql = "SELECT * FROM `funcionarios`";
            conn = new MySqlCommand(sql, con.con);

            sql = "INSERT INTO funcionarios (nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";

            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
            conn.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
            conn.Parameters.AddWithValue("@telefone", txt_Celular.Text);
            conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
            conn.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
            conn.Parameters.AddWithValue("@foto", img());

            MySqlCommand connVerificar;
            connVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE cpf = @cpf", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = connVerificar;
            connVerificar.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("CPF já registrado", "Cadastro de Funiconários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_Cpf.Text = "";
                txt_Cpf.Focus();
                return;
            }
            try
            {
            conn.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();

            MessageBox.Show("Registro Salvo com sucesso!.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            LimparCampos();
            Listar();
            using (MySqlDataReader reader = conn.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                      
                        string linha = "";

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            linha += reader[i].ToString() + "       \t"; 
                        }
                        if (!string.IsNullOrEmpty(linha))
                        {
                            linha = linha.Substring(0, linha.Length - 1);
                        }
                        Console.WriteLine(linha);
                    }
                }
            }

            DesabilitarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool CelularJaCadastrado(string celular)
        {
            con.AbrirConexao();
            sql = "SELECT COUNT(*) FROM funcionarios WHERE telefone = @telefone";
            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@telefone", celular);
            int count = Convert.ToInt32(conn.ExecuteScalar());
            con.FecharConexao();

            return count > 0;
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
      

        private void LimparFoto()
        {
            image.Image = Properties.Resources.icons8_person_32px;
            foto = "img/icons8_person_32px.png";
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Tel. :";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Imagem";

            //grid.Columns[0].Width = 50;
            //grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            LimparCampos();
            txt_Nome.Focus();
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }
        private void habilitarCampos()
        {
            btn_Salvar.Enabled = true;
            txt_Nome.Enabled = true;
            txt_Cpf.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Celular.Enabled = true;
            btn_foto.Enabled = true;
            cb_Cargo.Enabled = true;
            btn_Novo.Enabled = false;
        }

        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Cpf.Text = "";
            txt_Endereco.Text = "";
            txt_Celular.Text = "";
            cb_Cargo.Text = "";
            btn_foto.Text = "";
        }
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Cpf.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Celular.Enabled = false;
            cb_Cargo.Enabled = false;
        }

        private void CarregarCampos()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Cargo.DataSource = dt;
            //cbCargo.ValueMember = "id";
            cb_Cargo.DisplayMember = "cargo";
            con.FecharConexao();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
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
                return;
            }
            if (!CPFValidator.ValidateCPF(numeroCpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
            if (numerocel.Length != 11)
            {
                MessageBox.Show("preencha o Campo Telefone.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Celular.Focus();
                return;
            }
            if (cb_Cargo.Text == "Selcionar cargo")
            {
                MessageBox.Show("Por favor preencha o cargo.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Cargo.Focus();
                return;
            }
            if (txt_Endereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Endereço.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Endereco.Text = "";
                txt_Endereco.Focus();
                return;
            }
            con.AbrirConexao();

            if (alterouImagem == "sim")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                conn.Parameters.AddWithValue("@telefone", txt_Celular.Text);
                conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
                conn.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
                conn.Parameters.AddWithValue("@foto", img());
                conn.Parameters.AddWithValue("@id", id);
            }
            else if (alterouImagem == "nao")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", txt_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                conn.Parameters.AddWithValue("@telefone", txt_Celular.Text);
                conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
                conn.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
                conn.Parameters.AddWithValue("@id", id);
            }
            if (txt_Cpf.Text != cpfAntigo)
            {
                sql = "SELECT * FROM funcionarios WHERE cpf = @cpf";
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Cpf.Text = "";
                    txt_Cpf.Focus();
                    return;
                }
            }
            if (txt_Celular.Text != celAntigo)
            {
                sql = "SELECT * FROM funcionarios WHERE telefone = @telefone";
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@telefone", txt_Celular.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Celular já registrado.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Celular.Text = "";
                    txt_Celular.Focus();
                    return;
                }
            }

            try
            {
                conn.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Editado com sucesso!.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                LimparFoto();
                alterouImagem = "nao";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;

            DesabilitarCampos();
            LimparCampos();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "Cadastro Funciónario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro Excluído com sucesso!.", "Cadastro Funciónario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                LimparFoto();
            }
        }
        private void Listar_Cargos()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Cargo.DataSource = dt;
            cb_Cargo.DisplayMember = "cargo";
            con.FecharConexao();
        }

        private void grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                habilitarCampos();
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = false;
                txt_Nome.Focus();


                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Cpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Celular.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cb_Cargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Endereco.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if (grid.CurrentRow.Cells[7].Value != DBNull.Value)
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imagem);

                    image.Image = Image.FromStream(ms);
                }
                else
                {
                    image.Image = Properties.Resources.icons8_person_32px;
                }
            }
            else
            {
                campoClicado = false;
            }
        }

        private void cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Cargo.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = true;
            txt_BuscarCpf.Visible = false;
            txt_BuscarCpf.Text = "";
            txt_BuscarNome.Text = "";
            LimparFoto();
        }

        private void rb_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
            txt_BuscarCpf.Visible = true;
            txt_BuscarCpf.Text = "";
            txt_BuscarNome.Text = "";
            txt_BuscarNome.Focus();
            LimparFoto();
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            cadastross.Frm_Cargo frm = new Frm_Cargo();
            this.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            CarregarCampos();
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
                txt_Celular.Focus();
            }
        }

        private void lb_Celular_KeyDown(object sender, KeyEventArgs e)
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
               cb_Cargo.Focus();
            }
        }

        private void cb_Cargo_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_foto_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
