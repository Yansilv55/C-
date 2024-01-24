using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class Frm_Cargo : Form
    {

        Conexao con = new Conexao();
        string sql = string.Empty;
        MySqlCommand conn;
        string id;
        string nomeAntigo;
        public Frm_Cargo()
        {
            InitializeComponent();
        }

        private void Frm_Cargo_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";
            grid.Columns[2].HeaderText = "Data";
            grid.Columns[0].Visible = false;
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            conn = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cargos WHERE id = @id";
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
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Validações dos campos funcionários
            if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }

            con.AbrirConexao();

             sql = "SELECT * FROM `cargos`";
             conn = new MySqlCommand(sql, con.con);

            sql = "INSERT INTO cargos (cargo, data) VALUES (@cargo, curDate())";

            conn = new MySqlCommand(sql, con.con);
            conn.Parameters.AddWithValue("@cargo", lb_Nome.Text);

            conn.ExecuteNonQuery();
            con.FecharConexao();
            Listar();
            MessageBox.Show("Registro Salvo com sucesso!.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;

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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Novo.Enabled = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lb_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_Nome.Text = "";
                lb_Nome.Focus();
                return;
            }
            con.AbrirConexao();

                sql = "UPDATE cargos SET cargo = @cargo WHERE id = @id";
                conn = new MySqlCommand(sql, con.con);
                conn.Parameters.AddWithValue("@id", id);
                conn.Parameters.AddWithValue("@nome", lb_Nome.Text);

            if (lb_Nome.Text != nomeAntigo)
            {
                sql = "SELECT * FROM cargos WHERE cargo = @cargo";
                MySqlCommand connVerificar;
                connVerificar = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = connVerificar;
                connVerificar.Parameters.AddWithValue("@cargo", lb_Nome.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lb_Nome.Text = "";
                    lb_Nome.Focus();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            lb_Nome.Enabled = true;
            btn_Salvar.Enabled = true;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = false;
                lb_Nome.Enabled = true;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                lb_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
