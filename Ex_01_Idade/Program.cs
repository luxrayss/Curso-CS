using System;

namespace Ex_01_Idade {
    class Program {
        static void Main(string[] args) {
            //Vars
            Pessoa a, b;

            //Intancia do objeto
            a = new Pessoa();
            b = new Pessoa();

            //Pessoa A
            Console.WriteLine("Digite os dados da primeira pessoa: \nNome: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite os dados da primeira pessoa: \nIdade: ");
            a.Idade = int.Parse(Console.ReadLine());

            //Pessoa B
            Console.WriteLine("\nNome: ");
            b.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite os dados da primeira pessoa: \nIdade: ");
            b.Idade =  int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade) {
                Console.WriteLine("\nPessoa mais velha: " +a.Idade);

            } else if (b.Idade > a.Idade) {
                Console.WriteLine("\nPessoa mais velha: " + b.Idade);
            } else {
                Console.WriteLine("\nAmbas as pessoas tem a mesma idade");
            }

        }
    }
}
