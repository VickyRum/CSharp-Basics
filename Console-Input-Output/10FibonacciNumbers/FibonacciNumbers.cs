using System;
class FibonacciNumbers
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}