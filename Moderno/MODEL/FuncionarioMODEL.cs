using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class FuncionarioMODEL
    {
        public int funcionario_id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string cargo { get; set; }
        public string endereco { get; set; }
        public string data { get; set; }
        public string buscarNome { get; set; }
        public int buscarCpf { get; set; }
    }
}
