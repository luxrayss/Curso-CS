using System;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, res;
            res=n1 = n2 = n3 = n4 = 0;
            string resultado;

            //capturando dados
            Console.Write("Digite a nota 1:");      
            n1=int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2:");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3:");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 4:");
            n4 = int.Parse(Console.ReadLine());

            res = n1 + n2 + n3 + n4;

            if (res >= 60){
                if (res >= 90){                
                    resultado = "Aprovado com louvor";

                }else{
                    resultado = "Aprovado";

                }
            }else{

                if (res >= 40)
                {
                    resultado = "Recurperação";
                }else{
                    resultado = "Reprovado";
                }
            }

            //os índices dentro {} é a posição da concatenação
            Console.WriteLine("Nota: {0} - Resultado:{1}", res, resultado);
        }
    }
}
