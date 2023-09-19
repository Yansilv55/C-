using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converções inplicidas e Esplicidas

            int i = 10;

            long l = 10;

            //Isso pode

            l = i;

            //Isso não pode

            i = l;

            //Metodosque podem

            i = (int)l;

            Console.ReadLine();
        }
    }
}
