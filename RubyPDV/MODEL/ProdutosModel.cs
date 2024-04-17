using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ProdutosModel
    {
        public int produto_id {  get; set; }
        public string codigo_barra { get; set; }
        public string Nome { get; set; }
        public string uni_medida { get; set; }
        public string Entrada_estoque { get; set; }
        public string Fornecedor { get; set; }
        public string Entrada { get; set; }
        public double total_compra { get; set; }
        public double Unitario { get; set; }
        public double valor_venda { get; set; }
        public string data { get; set; }
        public int Minimo { get; set; }
        public int Nota { get; set; }
        public double lucro { get; set; }
        public double valor_compra { get; set; }
        public double eCompra { get; set; }
        public double eVenda { get; set; }
        public double eLucro { get; set; }
        public bool calcLucro { get; set; }
    }
}
