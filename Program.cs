using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir ao utilizador para inserir um número inteiro
            Console.WriteLine("Por favor, insira um número inteiro:");
            string enter = Console.ReadLine();
            int num = Convert.ToInt32(enter);
            Console.WriteLine($"Inseris-te o número inteiro: {num}!");
        }
    }
}
