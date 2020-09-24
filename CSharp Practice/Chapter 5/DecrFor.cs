// A negatively running For loop.

using System;

class DecrFor
{
    static void Main()
    {
        for (int i = 100; i > -100; i -= 5)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}