using DAO;
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

namespace Moderno.cadastross
{
    public partial class Frm_Cargo : Form
    {
        string id;
        string nomeAntigo;
        private bool campoClicado = false;

        public Frm_Cargo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Cargo_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID_Cargo";
            grid.Columns[1].HeaderText = "Cargo";
            grid.Columns[2].HeaderText = "Data";
            grid.Columns[0].Visible = false;
        }
        private void Listar()
        {
            CargoDAO cargoDAO = new CargoDAO();
            MySqlDataAdapter my = cargoDAO.Listar_Grid();
            DataTable dt = new DataTable();
            my.Fill(dt);
            grid.DataSource = dt;

            FormatarGD();
        }

        private bool ValidarCampos_Cargo()
        {
            if (lb_Nome.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void salvar_Registro()
        {
            try
            {
                if (ValidarCampos_Cargo())
                {
                    string nomecargo = lb_Nome.Text;
                    CargoDAO cargoDAO = new CargoDAO();

                    if (cargoDAO.buscar_Registro_Cargo(nomecargo))
                    {
                        MessageBox.Show("Cargo já registrado.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (cargoDAO.buscar_Registro_Cargo(nomecargo))
                        {
                            MessageBox.Show($"Cargo: {nomecargo} já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Inserir_Nome(nomecargo);
                           // Atualizar_Grade();
                            MessageBox.Show("Registro inserido com sucesso!", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o Cargo.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lb_Nome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar registro", ex);
            }
        }



        private bool Inserir_Nome(string nome)
        {
            try
            {
                CargoDAO cargoDAO = new CargoDAO();
                cargoDAO.Inserir_Nome_Cargo(nome);

                Listar();

                btn_Novo.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                lb_Nome.Text = "";
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       /* private void Atualizar_Grade()
        {
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
        }*/

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campoClicado = true;
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Novo.Enabled = false;
                lb_Nome.Enabled = true;
                id = grid.CurrentRow.Cells[0].Value.ToString();
                lb_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                campoClicado = false;
            }
        }

        private void lb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (campoClicado)
                        {
                            btn_Editar.PerformClick();
                        }
                        else
                        {
                            salvar_Registro();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Erro ao inserir o registro: {Ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lb_Nome.Focus();
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!.", "A T E N Ç Ã O ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                CargoDAO cargoDAO = new CargoDAO();

                cargoDAO.Excluir_Cargo();

                Listar();
                MessageBox.Show("Registro Excluído com sucesso!.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Novo.Enabled = true;
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Salvar.Enabled = false;
                lb_Nome.Text = "";
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                salvar_Registro();
                Listar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Erro ao inserir o registro: {Ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_Nome.Focus();
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
            CargoDAO cargoDAO = new CargoDAO();

            cargoDAO.Editar_Cargo(lb_Nome.Text);

            if (lb_Nome.Text != nomeAntigo)
            {
                bool existeRegistro = cargoDAO.buscar_Registro_Cargo(lb_Nome.Text);
                if (existeRegistro == true)
                {
                    MessageBox.Show("O Cargo " + lb_Nome.Text + " já registrado.", "A T E N Ç Ã O ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lb_Nome.Text = "";
                    lb_Nome.Focus();
                    return;
                }
            }

            try
            {
                Listar();
                FormatarGD();
 

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
            lb_Nome.Text = "";
            lb_Nome.Focus();
        }
    }
}
