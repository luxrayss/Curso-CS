using System;
//usando a separação de número com vírgula ao invés de ponto
using System.Globalization;

namespace While_com_Raiz {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                //raiz quadrada de um número/SquareRoot 
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um número");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número Negativo!");
        }
    }
}
