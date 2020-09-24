// Use continue.

using System;

class ContDemo
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if ((i % 2) != 0) continue;
            Console.WriteLine(i + " ");
        }
    }
}