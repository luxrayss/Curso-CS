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
            x.a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda medida do triângulo X");
            x.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira medida do triângulo X");
            x.c = double.Parse(Console.ReadLine());           

            //Triângulo Y
            Console.WriteLine("\nEntre com as medidas do triângulo Y");

            Console.WriteLine("\nDigite a primeira medida do triângulo Y");
            y.a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda medida do triângulo Y");
            y.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira medida do triângulo Y");
            y.c = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("\nÁrea do triângulo X: " + areaX);
            Console.WriteLine("\nÁrea do triângulo Y: " + areaY);

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
