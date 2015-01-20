using System;
    class AsciiTable
    {
        static void Main()
        {
            int i;
            for (i = 0; i < 250; i++)
                Console.Write((char)i + "\t");
            Console.WriteLine();
        }
    }

