// Use commas in a for statement.
using System;
class Comma
{
    static void Main()
    {
        //int i, j;
        //for (i = 0, j = 10; i < j; i++, j--)
        //    Console.WriteLine("i and j: " + i + " " + j);
        //Console.Read();

        int i, j;
        int smallest, largest;
        int num;
        num = 100;
        smallest = largest = 1;
        for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
        {
            if ((smallest == 1) & ((num % i) == 0))
                smallest = i;
            if ((largest == 1) & ((num % j) == 0))
                largest = j;
        }
        Console.WriteLine("Largest factor: " + largest);
        Console.WriteLine("Smallest factor: " + smallest);
        Console.Read();
    }
}