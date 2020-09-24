// Use format commands.
using System;
class DisplayOptions
{
    static void Main()
    {
        int i;
        Console.WriteLine("Value\tSquared\tCubed");
        for (i = 1; i < 10; i++)
            Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
    }
}