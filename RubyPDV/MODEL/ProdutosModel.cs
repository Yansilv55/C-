using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ProdutosModel
    {
        public string codAntigo { get; set; }
        public string Nome { get; set; }
        public string Nota { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
        public double valor_compra { get; set; }
        public double valor_venda { get; set; }
        public double total_compra { get; set; }
        public double lucroT { get; set; }
        public double eCompra { get; set; }
        public double eVenda { get; set; }
        public double eLucro { get; set; }
        public bool calcLucro { get; set; }
        public int produto_id {  get; set; }
        public int Entrada { get; set; }
        public int Entrada_estoque { get; set; }
        public int Unitario { get; set; }
        public int Minimo { get; set; }
        public String CodBarra { get; set; }
    }
}
