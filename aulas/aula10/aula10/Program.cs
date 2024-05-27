using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10
{
    internal class Program
    {
        enum DiasSemana {Domingo,Segunda,terça,Quarta,Quinta,Sexta,Sábado};
        static void Main(string[] args)
        {

            int ds = (int)DiasSemana.Quinta;

            Console.WriteLine(ds);

            Console.ReadLine();
        }
    }
}
