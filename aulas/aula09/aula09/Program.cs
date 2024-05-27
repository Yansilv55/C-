using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            string nome;

            Console.Write("Digite seu primeiro valor nome:");
            if (Console.ReadLine().Length >= 10)
            {
                Console.WriteLine("Quantidade de caracteres invalida!");
            } else
            {
                v1 = int.Parse(Console.ReadLine());
            }
            
            
            Console.Write("Digite seu segundo valor nome:");
            v2 =int.Parse(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);


            Console.ReadLine();        
         }
    }
}
