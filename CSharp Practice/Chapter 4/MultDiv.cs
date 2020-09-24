// Use the shift operators to multiply and divide by 2.
using System;
class MultDiv
{
    static void Main()
    {
        int n;
        n = 10;
        Console.WriteLine("Value of n: " + n);
        // Multiply by 2.
        n = n << 1;
        Console.WriteLine("Value of n after n = n * 2: " + n);
        // Multiply by 4.
        n = n << 2;
        Console.WriteLine("Value of n after n = n * 4: " + n);
        // Divide by 2.
        n = n >> 1;
        Console.WriteLine("Value of n after n = n / 2: " + n);
        // Divide by 4.
        n = n >> 2;
        Console.WriteLine("Value of n after n = n / 4: " + n);
        Console.WriteLine();
        // Reset n.
        n = 10;
        Console.WriteLine("Value of n: " + n);
        // Multiply by 2, 30 times.
        n = n << 30; // data is lost
        Console.WriteLine("Value of n after left-shifting 30 places: " + n);

        Console.ReadLine();
    }
}