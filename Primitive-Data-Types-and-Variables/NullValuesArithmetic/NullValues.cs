using System;
class NullValues
    {
        static void Main()
        {
            int? integerNum = null;
            double? doubleNum = null;
            Console.WriteLine("Both variables with null literals:");
            Console.WriteLine(integerNum);
            Console.WriteLine(doubleNum);
            integerNum = 15;
            doubleNum = 1;
            Console.WriteLine("Both variables with values assigned to them:");
            Console.WriteLine(integerNum);
            Console.WriteLine(doubleNum);
        }
    }

