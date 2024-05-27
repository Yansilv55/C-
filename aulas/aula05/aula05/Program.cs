using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            //array----------------------------------------------
            string[] names =
                {
                "Yan",
                "Joel",
                };

            //----------------------------------------------------

            Console.WriteLine(name.Length);

            Console.WriteLine(name.EndsWith("di"));

            Console.WriteLine(name.StartsWith("F"));

            Console.WriteLine(name.Contains("ed"));

            Console.WriteLine(name.IndexOf("ed"));

            //-----------------------------------------------------

            // Cerve para fazer validações
                    
            Console.WriteLine(string.IsNullOrEmpty(name));
            Console.WriteLine(string.IsNullOrWhiteSpace(name));

            // Esse recebe array

            Console.WriteLine(string.Join(" ", names));

            //--------------------------------------------------------


            Console.ReadLine();
        }
    }
}
