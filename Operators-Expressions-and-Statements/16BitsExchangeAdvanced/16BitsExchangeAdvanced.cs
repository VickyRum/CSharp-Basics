using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        Console.Write("n = ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("Start position of first sequence: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Start position of second sequence: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Lenght of sequences: ");
        int k = int.Parse(Console.ReadLine());

        bool isOutOfRangeP = p < 0 || p + k - 1 > 31;
        bool isOutOfRangeQ = q < 0 || q + k - 1 > 31;

        if (isOutOfRangeP || isOutOfRangeQ)
        {
            Console.WriteLine("out of range");
            return;
        }

        if ((p <= q && q <= p + k - 1) || (q <= p && p <= q + k - 1))
        {
            Console.WriteLine("overlapping");
            return;
        }

        uint result = number;

        for (byte i = 0; i < k; i++, p++, q++)
        {
            uint bit1 = GetABit(result, p);
            uint bit2 = GetABit(result, q);
            result = ModifyABit(result, p, bit2);
            result = ModifyABit(result, q, bit1);
        }
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(number, 2));
        Console.WriteLine(Convert.ToString(result, 2));
        Console.WriteLine("result: " + result);
    }


    static uint GetABit(uint number, int position)
    {
        return (number >> position) % 2;
    }


    static uint ModifyABit(uint number, int ModifyPosition, uint newBitValue)
    {
        uint modifyNumber = number;

        if (newBitValue == 0)
        {
            uint mask = ~(1u << ModifyPosition);
            modifyNumber = number & mask;
        }
        else if (newBitValue == 1)
        {
            uint mask = 1u << ModifyPosition;
            modifyNumber = number | mask;
        }

        return modifyNumber;
    }
}