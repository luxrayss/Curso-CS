using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] {{11,22,00,44,55}, {66,77,88,44,44}};

            Random random = new Random();
            for(int i = 0; i <vetor1.Length; i++)
            {
                //Next com apenas o valor máximo de 50 posições, corre de 0 a 49
                vetor1[i] = random.Next(50);
            }


            Console.WriteLine("Elementos do vetor1");
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }

            //public satic int BinarySearch(array, valor); //retorna a posição do elemento procurado, caso o elemento não seja encontrado, retorna -1
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            //Passando o array onde será realizado a procura, e o elemento que está sendo procurado
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
            Console.WriteLine("----------------------------------------------");

            //public static void Copy(Ar_origem, Ar_destino, qtde_elementos); //copia elementos de um array para outro
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach(int n in vetor2){
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            //public void CopyTo(Ar_destino, a_ártir_desta_pos);
            Console.WriteLine("CopyTo");

        }
    }
}
