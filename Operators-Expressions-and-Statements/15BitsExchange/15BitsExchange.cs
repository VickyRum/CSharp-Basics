    using System;
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            int mask1 = 7 << 3;
            int mask2 = 7 << 24;
            int gettingFirstBits = (mask1 & n) << 21;
            int gettingSecondBits = (mask2 & n) >> 21;
            int mask3 = ~mask1 & n;
            int mask4 = ~mask2 & n;
            n = (gettingFirstBits | gettingSecondBits) | (mask3 & mask4);
            Console.WriteLine(n);
        }
    }
