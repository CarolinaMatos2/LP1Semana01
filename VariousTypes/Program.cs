using System;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            // Integer variables
            int i = 42;                         
            uint c = 126178;
            ushort c2 = 65034;
            ulong c3 = 76543210;
            short neg = -1637;
            long l = 9876543210;

            // Char variables
            char poison = '\u2697';
            char head = '\u2620';

            // Displaying variable values
            Console.WriteLine(i);
            Console.WriteLine(c);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(neg);
            Console.WriteLine(l);

            // Displaying char values
            Console.WriteLine(poison);
            Console.WriteLine(head);

        }    
    }
}
