using System;
class Sunglasses
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', N * 2), new string(' ', N)); 

        for (int i = 0; i < N - 2; i++) 
        {
            if (i != (N - 2) / 2)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', N * 2 - 2), new string(' ', N));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', N * 2 - 2), new string('|', N));
            }
        }

        Console.WriteLine("{0}{1}{0}", new string('*', N * 2), new string(' ', N));
    }
}

