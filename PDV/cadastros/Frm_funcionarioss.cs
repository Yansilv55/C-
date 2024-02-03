using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PDV.cadastro
{
    public partial class Frm_funcionarioss : Form
    {
        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand conn;
        string id;
        string foto;
        string alterouImagem = "nao";
        string cpfAntigo;

        public Frm_funcionarioss()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void text_Telefone_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Validações dos campos funcionarios
            if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }
            if (lb_Cpf.Text == "   ,   ,   -" || lb_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo Cpf.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Cpf.Focus();
                return;
            }
            if (cb_Cargo.Text == "Selcionar cargo")
            {
                MessageBox.Show("Por favor preencha o Campo.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Cargo.Focus();
                return;
            }

             con.AbrirConexao();
             sql = "SELECT * FROM `funcionarios`";
             conn = new MySqlCommand(sql, con.con);

            sql = "INSERT INTO funcionarios (nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";

            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
            conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
            conn.Parameters.AddWithValue("@telefone", lb_Telefone.Text);
            conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
            conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
            conn.Parameters.AddWithValue("@foto", img());
            conn.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();

            MessageBox.Show("Registro Salvo com sucesso!.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            LimparCampos();
            Listar();

            DesabilitarCamos();

            using (MySqlDataReader reader = conn.ExecuteReader())
             {
                 if (reader.HasRows)
                 {
                     while (reader.Read())
                     {
                         // Inicialize uma variável para armazenar a linha completa
                         string linha = "";

                         // Itere através de cada coluna e concatene os valores
                         for (int i = 0; i < reader.FieldCount; i++)
                         {
                             linha += reader[i].ToString() + "       \t"; // Adiciona um tab entre os valores
                         }

                         // Remova o último tab da string, se necessário
                         if (!string.IsNullOrEmpty(linha))
                         {
                             linha = linha.Substring(0, linha.Length - 1);
                         }

                         Console.WriteLine(linha);
                     }
                 }
             }
        }
         private void btn_foto_Click(object sender, EventArgs e)
         {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
                alterouImagem = "sim";
            }
         }

        private byte[] img()
        {
            byte[] image_byte = null;
            if(foto == "")
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

        private void Frm_funcionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            Listar_Cargos();
            alterouImagem = "nao";
            cb_Cargo.Text = "Selecione o Cargo";
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

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            LimparCampos();
            lb_Nome.Focus();
        }

        private void habilitarCampos()
        {
            btn_Salvar.Enabled = true;
            lb_Nome.Enabled = true;
            lb_Cpf.Enabled = true; 
            lb_Endereco.Enabled = true;
            lb_Telefone.Enabled = true;
            btn_foto.Enabled = true;
            cb_Cargo.Enabled = true;
            btn_Novo.Enabled = false;
        }

        private void LimparCampos()
        {
            lb_Nome.Text = "";
            lb_Cpf.Text = "";
            lb_Endereco.Text = "";
            lb_Telefone.Text = "";
            cb_Cargo.Text = "";
            btn_foto.Text = "";
        }
        private void DesabilitarCamos()
        {
            lb_Nome.Enabled = false;
            lb_Cpf.Enabled = false;
            lb_Endereco.Enabled = false;
            lb_Telefone.Enabled = false;
            cb_Cargo.Enabled = false;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
         {
            if (e.RowIndex > -1)
            {
            habilitarCampos();
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = false;


            id = grid.CurrentRow.Cells[0].Value.ToString();
            lb_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            lb_Cpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
            lb_Telefone.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cb_Cargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
            lb_Endereco.Text = grid.CurrentRow.Cells[5].Value.ToString();

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
                return;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }
            if (lb_Cpf.Text == "   ,   ,   -" || lb_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo Cpf.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Cpf.Focus();
                return;
            }

            con.AbrirConexao();

            if (alterouImagem == "sim")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                conn.Parameters.AddWithValue("@telefone", lb_Telefone.Text);
                conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
                conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                conn.Parameters.AddWithValue("@foto", img());
                conn.Parameters.AddWithValue("@id", id);
            }
            else if (alterouImagem == "nao")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@nome", lb_Nome.Text);
                conn.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                conn.Parameters.AddWithValue("@telefone", lb_Telefone.Text);
                conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
                conn.Parameters.AddWithValue("@endereco", lb_Endereco.Text);
                conn.Parameters.AddWithValue("@id", id);
            }

            if (lb_Cpf.Text != cpfAntigo)
            {
                sql = "SELECT * FROM funcionarios WHERE cpf = @cpf";
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@cpf", lb_Cpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lb_Cpf.Text = "";
                    lb_Cpf.Focus();
                    return;
                }
            }

            try
            {
                conn.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Editado com sucesso!.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCamos();
                LimparCampos();
                LimparFoto();
                alterouImagem = "nao";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;

            DesabilitarCamos();
            LimparCampos();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.ExecuteNonQuery();
                con.FecharConexao();

                Listar();
                MessageBox.Show("Registro Excluído com sucesso!.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                DesabilitarCamos();
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
    }
}
