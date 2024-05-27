using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names =
                {
                "Yan",
                "Joel",
                "Josa",
                };

            for (int i = 0; i < names.Length ; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();

            // também pode ser usado o foreach

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
