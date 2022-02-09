using System;

namespace Estruturas_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i = 0;
            int con = 5;

            string senha = "123";
            string senhauser;            

            //Do while garante que a ação será executada pelomenos uma vez por executar primeiro e depois checar a condição

            do {
                Console.WriteLine("Digite a senha: ");
                senhauser = Console.ReadLine();

            } while (senha != senhauser);

            Console.WriteLine("Senha correta.");


            
            //laço while           
            while (i <= num.Length){  //lenght para pegar o tamanho do array
                Console.WriteLine("Posição do array {0}", i) ;
                i++;
            }

            //laço for
            for (int i = 0; i< 10; i++){
                //inserindo valor no array na posição 'i'
                num[i] = 0;

                Console.WriteLine(num[i]);
            }
        }
    }
}
