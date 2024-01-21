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
    public partial class Frm_funcionario : Form
    {
        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand conn;

        string foto;
        public Frm_funcionario()
        {
            InitializeComponent();
        }

        private void text_Telefone_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

             con.AbrirConexao();
             sql = "SELECT * FROM `funcionarios`";
             conn = new MySqlCommand(sql, con.con);

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

            // Validações dos campos funcionarios
            if (btn_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_Nome.Text = "";
                btn_Nome.Focus();
                return;
            }
            if (btn_Cpf.Text == "   ,   ,   -" || btn_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo Cpf.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_Cpf.Focus();
                return;
            }


            sql = "INSERT INTO funcionarios (nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";

            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@nome", btn_Nome.Text);
            conn.Parameters.AddWithValue("@cpf", btn_Cpf.Text);
            conn.Parameters.AddWithValue("@telefone", btn_Telefone.Text);
            conn.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
            conn.Parameters.AddWithValue("@endereco", btn_Endereco.Text);
            conn.Parameters.AddWithValue("@foto", img());

            conn.ExecuteNonQuery(); 
            con.FecharConexao();
        }

         private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
               // alterouImagem = "sim";
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

        private void Frm_funcionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }
    }
}
