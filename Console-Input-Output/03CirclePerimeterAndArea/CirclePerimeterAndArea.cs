using System;
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Input circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = Math.PI * radius * radius;
            //perimeter = Math.Round(perimeter, 2);
            //area = Math.Round(area, 2);
            Console.WriteLine("Circle perimeter is: {0}.\nCircle area is: {1}.",perimeter.ToString("#.##"),area.ToString("#.##"));
            
        }
    }

