using System;
    class PlayWithVariables
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}",a+1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}",b+1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Result: {0}*",c);
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
        }
    }

