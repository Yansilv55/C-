using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(num);
            Console.WriteLine(num);

            Console.ReadLine();
        }
        static void dobrar(int valor)
        {
            valor*= 2;

            Console.ReadLine();
        }
    }
}
