using System;

class Gravitation
{

    static void Main()
    {
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());

        double weightOnTheMoon = (weight * 0.17);

        Console.WriteLine(weightOnTheMoon);
    }
}