using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 11, 22, 33, 44, 55 };

            //Laço FOR
            for(int i=0, i < num.Length; i++)
            {
                num[i] = 0; //é possível atribuir valores ao array num FOR mas em um FOREACH não
                Console .WriteLine(num[i]);

            }
            //FOREACH
            //contador "n" recebendo os números do array "num"
            foreach(int n in num ){
                Console.WriteLine(n);
            }
        }
    }
}
