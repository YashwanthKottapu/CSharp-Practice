﻿// Demonstrate a one-dimensional array.

using System;

class ArrayDemo
{
    static void Main()
    {
        int[] sample = new int[10];

        for (int i = 0; i < 10; i++)
        {
            sample[i] = i;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("sample[" + i + "] is: " + sample[i]);
        }
    }
}