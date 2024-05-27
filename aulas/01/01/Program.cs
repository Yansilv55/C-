using System;

namespace _01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome = "Yan";
            string sobreNome = "Silva";
            string propriedade = "Usuario";


            Console.WriteLine( "Meu nome é " + primeiroNome + " " + sobreNome);
            Console.WriteLine(propriedade + ": " + primeiroNome + " " +  sobreNome);
            Console.ReadLine();
        }

        static void teste(string[] args)
        {
            int idade = 18;

            if(idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            } 
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
            Console.ReadLine();
        }


    }
}
