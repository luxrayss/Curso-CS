using System;

namespace _42_Ex_Produtos {
    class Program {
        static void Main(string[] args) {
            //Obj
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: \nNome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("\nPreço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantidade: ");
            p.Qtd = int.Parse(Console.ReadLine());

            double TotalP = p.Total();

            Console.WriteLine("\nDados do Produto: " + p);

                        
        }
    }
}
