using System;
class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.WriteLine("Input first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        double secondNum = double.Parse(Console.ReadLine());
        if (firstNum > secondNum)
        {
            if (firstNum - secondNum > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
        else
        {
            if (secondNum - firstNum > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }


    }
}

