//  Determine if a value is positive or negative.

using System;

class PosNeg
{
    static void Main()
    {
        int i;

        for (i = -5; i <= 5; i++)
        {
            Console.Write("Testing " + i + " : ");

            if (i > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        Console.ReadLine();
    }
}