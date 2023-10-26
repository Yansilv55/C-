using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("Yan, seu programador");
                i++;
            }
            Console.WriteLine("End");

         
        }

        static void body(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite sua senha:");
                senhauser = Console.ReadLine();

            }while(senha != senhauser);

            Console.WriteLine("Senha correta, tentativas:{0}", tentativas);

            Console.ReadLine();

        }
    }
}
