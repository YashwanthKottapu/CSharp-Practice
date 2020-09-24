// The body of a loop can be empty.
using System;
class Empty3
{
    static void Main()
    {
        int i;
        int sum = 0;
        // Sum the numbers through 5.
        for (i = 1; i <= 5; sum += i++) ;
        Console.WriteLine("Sum is " + sum);
        Console.ReadLine();
    }
}