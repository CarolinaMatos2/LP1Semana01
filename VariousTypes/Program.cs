using System;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            // Integer variables
            int idade = 42;                         
            uint codigo = 0x126178u;
            ushort codigo2 = 0xBEE;
            ulong codigo3 = 0xABCD4567890UL;
            short neg = -1337;
            long longo = 9876543210L;

            // Char variables
            char cora = '\u1F338';

            // Displaying variable values
            Console.WriteLine(idade);
            Console.WriteLine(codigo);
            Console.WriteLine(codigo2);
            Console.WriteLine(codigo3);
            Console.WriteLine(neg);
            Console.WriteLine(longo);

            // Displaying char values
            Console.WriteLine(cora);

        }    
    }
}
