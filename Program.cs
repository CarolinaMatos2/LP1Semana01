using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args):
        {
            //Ex6
            double xx = 1.23456;
            int ii = 19;

            // Double
            string a1 = $"Número real com duas casas decimais: {xx:f2}";
            string a2 = $"Percentagem com uma casa decimal: {xx:p1}";
            // Int
            string b1 = $"Hexadecimal: {ii:x}";
            string b2 = $"Moeda: {ii:c}";

            Console.WriteLine(a1);
            Console.WriteLine(a2);


           // Strings
           string message = "Hi \u26A1";
           string message2 = "I am a star \u2B50";
           string message3 = "Happy Day for you \u2666 \u2600";
           
           Console.WriteLine(message);
           Console.WriteLine(message2);
           Console.WriteLine(message3);

           // String type variables
           int xis = 1
           string um = "ab" + 6;
           string two = "c" * x;
           string tree = "mn" - 4;

           Console.WriteLine(um);
           Console.WriteLine(two);
           Console.WriteLine(tree);

           // By interpolation
           string text1 = "Hi"; 
           string text2 = "Carolina"; 
           string result = $"{text1} {text2}!";

           int x = 26;
           string result2 = $"O valor de x é {x}?";

           int a = 10, b = 7;
           string result3 = $"{a} e {b} é igual a {a + b}.";

           Console.WriteLine(result);
           Console.WriteLine(result2);
           Console.WriteLine(result3);

        }
    }
}
