using System;

    class NumbersInInterval
    {
        static void Main()
        {
            uint start = uint.Parse(Console.ReadLine());
            uint end = uint.Parse(Console.ReadLine());
            uint p = 0;
            for (uint i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p=p+1;
                }
            }
            Console.WriteLine(p);
        }
    }

