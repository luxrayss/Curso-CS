using System;

namespace Switch_e_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;

            Console.WriteLine("Belo Horizonte/MG e Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a]Avião | [b]Carro | [c]Ônibus");

            escolha = char.Parse(Console.ReadLine());

            switch(escolha){
                case 'a':
                    tempo = 50;
                    break;

                case 'b':
                    tempo = 480;
                    break;

                case 'c':
                    tempo = 660;
                    break;

                default:
                    tempo = -1;
                    break;

            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível");

            }else {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }

        }
    }
}
