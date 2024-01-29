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
    public partial class Frm_Cliente : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand conn;

        string id;
        string cpfAntigo;
        string foto;
        string alterouImagem = "nao";
        string radButton = "";
        String desbloqueado, inadiplente;
        bool emailAddress = false;
        int codCliente, IdAnterior;

        private void lb_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        public Frm_Cliente()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FRM_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
