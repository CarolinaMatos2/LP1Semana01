using System;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            // Integer variables
            int i = 42;                         
            uint c = 0x126178u;
            ushort c2 = 0x65635;
            ulong c3 = 0x9876543210UL;
            short neg = -1637;
            long l = 9876543210L;

            // Char variables
            char cora = '\u1F338';
            char cav = '\u2620';

            // Displaying variable values
            Console.WriteLine(i);
            Console.WriteLine(c);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(neg);
            Console.WriteLine(l);

            // Displaying char values
            Console.WriteLine(cora);
            Console.WriteLine(cav);

        }    
    }
}
