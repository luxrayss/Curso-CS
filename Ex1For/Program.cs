using System;

namespace Ex1For {
    class Program {
        static void Main(string[] args) {
            //Exibir os número ímpares de um número até X;
            Console.WriteLine("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
