using System;
using System.Text;
    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyrightSymbol = '\u00A9';
            byte side = 9;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(copyrightSymbol);
            for (int i = 0; i < side - 1; i++) 
            {
                Console.Write(copyrightSymbol);
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine(copyrightSymbol);
            }
            for (int i = side - 3; i >= 0; i--)
            {
                Console.Write(copyrightSymbol);
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine(copyrightSymbol);
            }
            Console.WriteLine(copyrightSymbol);
        }
    }

