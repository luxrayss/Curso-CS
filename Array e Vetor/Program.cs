using System;

namespace Array_e_Vetor
{
    class Program
    {
        private const int V = 11;

        static void Main(string[] args)
        {
            //int n1, n2, n3, n4, n5;
            //declarando um array
            //int[] n = new int[5];
            int[] num = new int[3] {33, 42, 52};
            int[] ar = { 55, 22, 54 };
            //matriz
            int[,] n = new int[3, 5];

            /* modelo da matriz
                10 20 30 40 50
                11 21 31 41 51
                12 22 33 44 55            
            */


            //Coluna / Linha
            //Coluna 1
            n[0, 0] = 10;
            n[0, 1] = 20;
            n[0, 2] = 30;
            n[0, 3] = 40;
            n[0, 4] = 50;

            //Coluna 2
            n[1, 0] = 11;
            n[1, 1] = 21;
            n[1, 2] = 31;
            n[1, 3] = 41;
            n[1, 4] = 51;

            //Coluna 3 
            n[2, 0] = 12;
            n[2, 1] = 22;
            n[2, 2] = 32;
            n[2, 3] = 42;
            n[2, 4] = 52;



            Console.WriteLine(n[2, 1]);

        }
    }
}

