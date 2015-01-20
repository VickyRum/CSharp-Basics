using System;

    class FormattingNumbers
    {
        static void Main()
        {
            int firstNumber;
            Console.Write("Insert first number: ");
            while (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber < 0 || firstNumber > 500)
            Console.WriteLine("Invalid input.");

            double secondNumber;
            Console.Write("Insert second number: ");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            Console.WriteLine("Invalid input.");

            double thirdNumber;
            Console.Write("Insert third number: ");
            while (!double.TryParse(Console.ReadLine(), out thirdNumber))
            Console.WriteLine("Invalid input.");
            
            Console.Write("|{0,-10:X}|{1}",firstNumber,Convert.ToString(firstNumber,2).PadLeft(10,'0'));
            bool dotCheckSecondNumber = Convert.ToString(secondNumber).IndexOf(".") > 0;
            Console.Write(dotCheckSecondNumber? "|{0,10:0.00}" : "|{0,10}", secondNumber);
            bool dotCheckThirdNumber = Convert.ToString(thirdNumber).IndexOf(".") > 0;
            Console.WriteLine(dotCheckThirdNumber ? "|{0,-10:0.000}|" : "|{0,10}|", thirdNumber);
        }
        }
    

