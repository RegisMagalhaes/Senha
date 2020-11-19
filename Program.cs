using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string resposta = Console.ReadLine();
            Console.WriteLine("Digite uma nova senha");
            string resposta1 = Console.ReadLine();
            while(resposta==resposta1){
                Console.WriteLine("Tente novamente!A senha deve ser diferente do nome");
                Console.WriteLine("Digite uma nova senha");
                resposta = Console.ReadLine();
            }

            Console.WriteLine("Sua senha foi cadastrada com sucesso!");
        }
    }
}
