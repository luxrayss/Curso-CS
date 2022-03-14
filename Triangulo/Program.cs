using System;
using System.Globalization;

namespace Triangulo {
    class Program {
        static void Main(string[] args) {
            //Calculando a área do triângulo
            double xA, xB, xC, yA, yB, yC = 0;


            Console.WriteLine("Entre com as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;

        }
    }
}
