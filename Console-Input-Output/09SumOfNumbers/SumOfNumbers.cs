using System;
    class SumOfNumbers
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("Sum = {0}",sum);
            
        }
    }

