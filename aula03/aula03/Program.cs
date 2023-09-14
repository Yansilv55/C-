using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Olá  {name}, seja bem vindo!");

            Console.Write("Digite o ano do seu nascimento: ");
            int year = int.Parse( Console.ReadLine() );
            int age = 2023 - year;
            Console.WriteLine($"Você tem {age} anos. ");

            if ( age >= 18 ) 
            {
                Console.WriteLine(" Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }

            Console.ReadLine();
        }
    }
}
