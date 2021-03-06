﻿using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        Console.WriteLine("Enter a list of integers on a single line separated by a space:");
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

        int mask = (1 << numbers.Length) - 1;
        int maxLength = 0;
        List<int> longestSubsequence = new List<int>();

        for (int i = mask; i >= 1; i--)
        {
            char[] indexesToTake = Convert.ToString(i, 2).PadLeft(numbers.Length, '0').ToCharArray();

            List<int> currentSubsequence = new List<int>();

            for (int j = 0; j < numbers.Length; j++)
            {
                if (indexesToTake[j] == '1')
                {
                    currentSubsequence.Add(numbers[j]);
                }
            }

            if (NonDecreasing(currentSubsequence) && currentSubsequence.Count > maxLength)
            {
                maxLength = currentSubsequence.Count;
                longestSubsequence.Clear();
                longestSubsequence = currentSubsequence.ToList();
            }
        }

        PrintList(longestSubsequence);
    }

    static bool NonDecreasing(List<int> subsequence)
    {
        bool nondecreasing = true;

        for (int i = 1; i < subsequence.Count; i++)
        {
            if (subsequence[i] < subsequence[i - 1])
            {
                nondecreasing = false;
                break;
            }
        }

        return nondecreasing;
    }

    static void PrintList(List<int> sequence)
    {
        Console.WriteLine();
        Console.WriteLine("The longest non-decreasing subsequence is:");
        foreach (var number in sequence)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}