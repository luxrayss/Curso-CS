using System;

namespace Ex_Salario_Medio {
    class Program {
        static void Main(string[] args) {
            //Vars
            Pessoa a, b;

            //Intancia do objeto
            a = new Pessoa();
            b = new Pessoa();

            //Pessoa A
            Console.WriteLine("Digite os dados do primeiro funcionário: \nNome: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite os dados do primeiro funcionário: \nSalário: ");
            a.Salario = double.Parse(Console.ReadLine());

            //Pessoa B
            Console.WriteLine("\nDigite os dados do segundo funcionário \nNome: ");
            b.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite os dados do segundo funcionário: \nSalário: ");
            b.Salario = double.Parse(Console.ReadLine());

            double res = (a.Salario + b.Salario) / 2;

            //Resultado
            //1°
            Console.WriteLine("\nDados do primeiro funcionário: \nNome: " + a.Nome);
            Console.WriteLine("\nSalário: \n" + a.Salario);

            //2°
            Console.WriteLine("\nDados do segundo funcionário: \n" + b.Nome);
            Console.WriteLine("\nSalário: \n" + b.Salario);

            Console.WriteLine("\nSalário médio: " + res);

        }
    }
}
