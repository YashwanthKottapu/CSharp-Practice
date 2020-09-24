// Using break to exit a loop.

using System;

class BreakDemo
{
    static void Main()
    {
        // Use break to exit this Loop.
        for (int i = -10; i <= 10; i++)
        {
            if (i > 0)
            {
                break;
            }
            Console.Write(i + " ");
        }
        Console.WriteLine("Done");
    }
}