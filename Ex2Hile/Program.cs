using System;

namespace Ex2Hile {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número do pedido: ");

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            int num = int.Parse(Console.ReadLine());
           

            while (num != 4) {
                Console.WriteLine("Digite o número do pedido: ");
                num = int.Parse(Console.ReadLine());

                switch (num) {
                    case 1:
                        gasolina++;
                        break;

                    case 2:
                        alcool++;
                        break;

                    case 3:
                        diesel++;
                        break;

                    case 4:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Número inválido.");
                        break;
                }
            }

            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Álcool: {0}", alcool);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
