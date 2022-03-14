using System;

namespace _36_Problema_Matematica {
    class Program {
        static void Main(string[] args) {
            /*Fazer um programa para ler as medidas dos lados de dois triângulos e mostrar o valor da área deles e dizer qual possui a maior.*/

            //Variáveis
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            //Triângulo X
            Console.WriteLine("Entre com as medidas do triângulo X");

            Console.WriteLine("\nDigite a primeira medida do triângulo X");
            x.A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda medida do triângulo X");
            x.B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira medida do triângulo X");
            x.C = double.Parse(Console.ReadLine());

            double xP = x.A + x.B + x.C / 2;

            //Triângulo Y
            Console.WriteLine("\nEntre com as medidas do triângulo Y");

            Console.WriteLine("\nDigite a primeira medida do triângulo Y");
            y.A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda medida do triângulo Y");
            y.B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira medida do triângulo Y");
            y.C = double.Parse(Console.ReadLine());
           
            double yP = (y.A + y.B + y.C) / 2;

            //Raiz triangulo x
            double areaX = Math.Round(Math.Sqrt(xP * (xP - x.A) * (xP - x.B) * (xP - x.C)), 2);
            //Raiz triangulo y
            double areaY = Math.Round(Math.Sqrt(yP * (yP - y.A) * (yP - y.B) * (yP - y.C)), 2);

            Console.WriteLine("\nÁrea do triângulo X: " + areaX);
            Console.WriteLine("Área do triângulo Y: " + areaY);

            if (areaX > areaY) {
                Console.WriteLine("\nA área do triângulo X é maior");
                  
            } else if (areaY > areaX) {
                Console.WriteLine("\nA área do triângulo Y é maior");

            } else {
                Console.WriteLine("\nA área dos dois triângulos são iguais");
            }

        }
    }
}
