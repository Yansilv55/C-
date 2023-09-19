using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1};
            string s = null;
            try
            {
                Console.WriteLine(s.Length);

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro IndexOutOfRangerExceotion");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro:{exception.StackTrace}");
            }

            Console.ReadLine();
        }
    }
}
