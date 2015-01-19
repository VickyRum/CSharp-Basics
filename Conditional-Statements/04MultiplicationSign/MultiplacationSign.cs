using System;
class MultiplacationSign
{
    static void Main()
    {
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a == 0 && b < 0 && c > 0)
            {
                Console.WriteLine("0");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
