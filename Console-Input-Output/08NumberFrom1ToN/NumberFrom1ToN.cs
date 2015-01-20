using System;
    class NumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Input number: ");
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
