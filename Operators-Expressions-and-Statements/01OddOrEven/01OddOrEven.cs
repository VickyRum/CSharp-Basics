using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;

        Console.WriteLine("This number is even: " + isEven);
    }
}