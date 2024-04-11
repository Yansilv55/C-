using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class FornecedorMODEL
    {
        public int fornecedor_id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string celular { get; set; }
        public string vendedor { get; set; }
        public string data { get; set; }
        public string buscarNome { get; set; }
        public int buscarCnpj { get; set; }
    }
}
