using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class VendaModel
    {
        public int venda_id { get; set; }
        public int item { get; set; }
        public int nota { get; set; }
        public int estoqueProduto { get; set; }
        public String idExcluirProduto { get; set; }
        public String nomeProduto { get; set; }
        public String qtdProduto { get; set; }
        public String unitario { get; set; }
        public String ultimoIdVenda { get; set; }
        public Double valorUnitario { get; set; }
        public Double subTotal { get; set; }
        public Double valorVenda { get; set; }
        public Double dinheiro { get; set; }
        public Double pix { get; set; }
        public Double cartao { get; set; }
        public Double valorDescontado { get; set; }
        public Double troco { get; set; }
        public Double dinheirox { get; set; }
        public Double taxa { get; set; }
        public Double valor_totaly { get; set; }
        public Double valor_totalx { get; set; }
        public Double valor_totalz { get; set; }
        public Double valor_total { get; set; }
        public Double valor_pago { get; set; }
        public Double totalPagar { get; set; }
        public Double cartaoDinheiroPix { get; set; }
        public string idProduto { get; set; }
        public string entrada { get; set; }
        public string codigoProduto { get; set; }
        public string atualizarEstoque { get; set; }
        public string ultimoIdGrid { get; set; }
        public string numeroNota { get; set; }
        public string idDetalheVenda { get; set; }
        public string status { get; set; }
    }
}
