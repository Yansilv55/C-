using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite sua senha:");
                senhauser = Console.ReadLine();
                tentativas++;

            } while (senha != senhauser);

            Console.Clear();
            Console.WriteLine("Senha correta, tentativas:{0}", tentativas);

            Console.ReadLine();
        }
    }
}
