using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float n1 = 10.5f;
            int n2 = (int)n1;//type cast

            Console.WriteLine(n2);

            int vInt = 10;
            short vShort = (short)vInt;

            Console.WriteLine(vShort);

            Console.ReadLine();
        }
    }
}
