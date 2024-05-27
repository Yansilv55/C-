using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("Belo Horizonte/MG a Porto Seguro/BA");
            Console.WriteLine("Escolha o transporte:[a]Avião | [c]carro | [o]ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Transorte indisponivel");
            }
            else
            {
                Console.WriteLine($"Para o transporte escolhido o tempo é: {tempo} minutos");
            }

            Console.WriteLine("Calcular outro transpote?[s/n]");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S'){
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }


            Console.ReadLine();
        }
    }
}
