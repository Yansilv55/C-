using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_de_dadosDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.banco_de_dadosDataSet.Pessoas);




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MovePrevious();
        }

        private void Proxima_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MoveNext();
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.RemoveCurrent();
        }

        private void novoregistro_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.AddNew();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.EndEdit();
            //pessoasTableAdapter.Update(pessoasDataSet);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
