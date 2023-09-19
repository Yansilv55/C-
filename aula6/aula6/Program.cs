using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            if (int.TryParse("10", out int x))
            {
                Console.WriteLine("Sucesso!");
            }
            else
            {
                Console.WriteLine("Erro");
            }
                Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
