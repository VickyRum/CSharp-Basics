using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            var max = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is: {0}",max);
            
        }
    }

