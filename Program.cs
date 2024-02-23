using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter an integer
            Console.WriteLine("Por favor, insira um número inteiro:");
            string enter = Console.ReadLine();
            int num = Convert.ToInt32(enter);
            Console.WriteLine($"Inseriste um número inteiro: {num}!");

            // Ask the user to enter a real number
            Console.Write("Insira um número real: ");
            string numreal = Console.ReadLine();
            float.Parse(numreal);
            Console.WriteLine($"Inseriste um número real: {numreal}!");

            float soma = num + numreal;
            Console.WriteLine($"A soma dos números é: {soma}!");


        }
    }
}
