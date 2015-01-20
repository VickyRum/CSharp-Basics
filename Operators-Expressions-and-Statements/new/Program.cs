using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberDivision = number / 100;
        int oneMoreNumber = (numberDivision % 10);
        bool isThirdDigit7 = numberDivision == 7;
        Console.WriteLine(isThirdDigit7);


    }
}