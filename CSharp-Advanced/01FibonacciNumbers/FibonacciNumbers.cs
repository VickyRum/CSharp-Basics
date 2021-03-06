﻿using System;
using System.Numerics;

 class FibonacciNumbers
{
    static void Main()
    {
        uint n;

        Console.Write("n = ");
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("\nInvalid input! Please re-enter.");
            Console.Write("n = ");
        }

        BigInteger member = Fib(n);
        Console.WriteLine("\nThe n-th member is: {0}\n", member);
    }

    public static BigInteger Fib(uint n)
    {
        BigInteger firstMember = 1;
        BigInteger secondMember = 1;
        BigInteger nextMember = firstMember + secondMember;

        if (n == 0)
	    {
            return firstMember;
	    }

        else if (n == 1)
        {
            return secondMember;
        }

        else
        {
            for (int i = 2; i < n; i++)
            {
                nextMember += secondMember;
                secondMember = nextMember - secondMember;
            }

            return nextMember;
        }
    }
}

