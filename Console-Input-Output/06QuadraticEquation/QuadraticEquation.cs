using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double firstRoot;
            double secondRoot;
            double discriminant = (secondNumber * secondNumber - 4 * firstNumber * thirdNumber);
            if (discriminant<0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (discriminant==0)
            {
                firstRoot = secondRoot = (-secondNumber + Math.Sqrt(discriminant)) / (2 * firstNumber);
                Console.WriteLine("x1=x2={0}", firstRoot);
            }
            else if (discriminant > 0)
            {
                firstRoot = (-secondNumber + Math.Sqrt(discriminant)) / (2 * firstNumber);
                secondRoot = (-secondNumber - Math.Sqrt(discriminant)) / (2 * firstNumber);
                Console.WriteLine("x1={0}",firstRoot);
                Console.WriteLine("x2={0}",secondRoot);
            }
        }
    }

