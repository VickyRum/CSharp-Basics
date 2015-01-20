using System;
using Nakov.IO;
class SumOf5Numbers
{
    static void Main()
    {
        double firstNumber = Cin.NextDouble();
        double secondNumber = Cin.NextDouble();
        double thirdNumber = Cin.NextDouble();
        double fourthNumber = Cin.NextDouble();
        double fifthNumber = Cin.NextDouble();

        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        Console.WriteLine("Sum= {0}", sum);
    }
}

