using System;
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenation = hello + " " + world;
            object result = (object)concatenation;
            Console.WriteLine(concatenation);
        }
    }

