using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
           // Strings
           string message = "Hi \u26A1";
           string message2 = "I am a star \u2B50";
           string message3 = "Happy Day for you \u2666 \u2600";
           
           Console.WriteLine(message);
           Console.WriteLine(message2);
           Console.WriteLine(message3);
        }
    }
}
