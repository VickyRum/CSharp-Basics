using System;
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Input the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
             Console.Write("Input the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
             Console.Write("Input the third number: ");
             double thirdNumber = double.Parse(Console.ReadLine());
             Console.WriteLine("Their sum is equal to: {0}", firstNumber+secondNumber+thirdNumber);

        }
    }

