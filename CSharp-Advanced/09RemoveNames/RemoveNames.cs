﻿using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of names on a single line, separated by space:");
        string initial = Console.ReadLine();
        Console.WriteLine("\nPlease enter the names you'd like to remove from the first list:");
        string toRemove = Console.ReadLine();

        string[] initialArray = initial.Split();
        string[] toRemoveArray = toRemove.Split();

        List<string> initialList = new List<string>();

        for (int i = 0; i < initialArray.Length; i++)
        {
            initialList.Add(initialArray[i]);
        }

        for (int i = 0; i < toRemoveArray.Length; i++)
        {
            initialList.RemoveAll(name => name == toRemoveArray[i]);
        }

        Console.WriteLine("\nResult:");

        for (int i = 0; i < initialList.Count; i++)
        {
            Console.Write("{0} ", initialList[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}