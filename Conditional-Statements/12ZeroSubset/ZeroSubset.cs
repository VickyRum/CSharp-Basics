using System;
using System.Text;
using System.Linq;

class ZeroSubset
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        bool subsetFounded = false;
        for (int i = (1 << numbers.Length) - 1; i > 0; i--)
        {
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < numbers.Length; a++)
            {
                int maskNum = i >> a;
                if (maskNum % 2 != 0)
                {
                    sum += numbers[a];
                    sb.Append(string.Format("{0} + ", numbers[a]));
                }
            }

            if (sum == 0 && sb.Length != 0)
            {
                subsetFounded = true;
                Console.WriteLine("{0} = 0", sb.Remove(sb.Length - 2, 2));
            }
        }

        if (!subsetFounded)
        {
            Console.WriteLine("no zero subset");
        }
    }
}