using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linguagens = new string[4];
            int[] anoslinguagem = new int[4];

            linguagens[0] = "JavaScript";
            linguagens[1] = "Cshap";
            linguagens[2] = "Java";
            linguagens[3] = "PHP";

            anoslinguagem[0] = 1990;
            anoslinguagem[1] = 1984;
            anoslinguagem[2] = 1994;
            anoslinguagem[3] = 1964;

            Console.WriteLine($"Linguagens de programação 1: {linguagens[2]} foi criada no ano de {anoslinguagem[2]}");

            Console.ReadLine();
        }
    }
}
