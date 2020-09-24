// Find the smallest factor of a value.

using System;

class FindSmallestFactor
{
    static void Main()
    {
        int factor = 1;
        int num = 1000;

        for (int i = 2; i <= (num / i); i++)
        {
            if ((num % i) == 0)
            {
                factor = i;
                break; // Stop loop when factor is found.
            }
        }
        Console.WriteLine("The smallest factor is: " + factor);
    }
}