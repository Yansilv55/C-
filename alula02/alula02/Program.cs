using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, word!");

            int i;
            int i2 = i = 10;
            i2--;

            i = i2 == 42 ? 10 : 20;

            Console.WriteLine(i2--);

            Console.ReadLine();
        }
    }
}
