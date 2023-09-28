using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;



            Console.WriteLine("Belo Horizonte/MG a Porto Seguro/BA");
            Console.WriteLine("Escolha o transporte:[a]Avião | [c]carro | [o]ônibus");
            escolha =char.Parse(Console.ReadLine());

          switch (escolha) {
                case 'a':
                    tempo = 50;
                    break;
                case 'c':
                    tempo = 480;
                    break;
                case 'o':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if(tempo < 0)
            {
                Console.WriteLine("Transorte indisponivel");
            }
            else
            {
                Console.WriteLine($"Para o transporte escolhido o tempo é: {tempo} minutos");
            }

            Console.ReadLine();
        }
    }
}
