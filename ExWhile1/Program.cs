using System;

namespace ExWhile1 {
    class Program {
        static void Main(string[] args) {

            int x = 0;

            while (x != 2002) {
                Console.WriteLine("Digite uma senha: ");                
                x = int.Parse(Console.ReadLine());
                //Verificando se a senha é igual à 2002                

            }
            Console.WriteLine("Senha Correta!");  
            
        }
    }
}
