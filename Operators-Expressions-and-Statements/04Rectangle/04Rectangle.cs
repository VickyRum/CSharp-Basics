using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;

        Console.WriteLine("Perimeter of rectangle is " + perimeter);
        Console.WriteLine("Area of rectangle is " + area);
    }
}