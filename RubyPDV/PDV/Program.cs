using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moderno
{
    public class Program
    {
        public static string ChamadaProdutos;
        public static string NomeProduto;
        public static string EstoqueProduto;
        public static string EstoqueMinimo;
        public static string ValorProduto;
        public static string modLucro;
        public static bool DesabilitarTxt;

        public static string IdProduto;
        public static string idVenda;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new Frm_Pdv_Moderno());
        }
    }
}
