// Display the digits of a number in reverse order.

using System;

class DoWhileDemo
{
    static void Main()
    {
        int num, nextdigit;

        num = 198;

        Console.WriteLine("The Number is: " + num);

        Console.Write("The Number in reverse order is: ");

        do
        {
            nextdigit = num % 10;
            Console.Write(nextdigit);
            num = num / 10;
        } while (num > 0);

        Console.WriteLine();
    }
}