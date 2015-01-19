using System;
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if ((firstNumber>secondNumber)&&(firstNumber>thirdNumber))
            {
                Console.WriteLine("The biggest number is: {0}",firstNumber);
            }
            else
                if ((thirdNumber > secondNumber) && (thirdNumber > firstNumber))     
                {
                    Console.WriteLine("The biggest number is: {0}", thirdNumber);
                }
                else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
                {
                    Console.WriteLine("The biggest number is: {0}", secondNumber);
                }
        }
    }

