// Demonstrate implicit conversion from long to double.
using System;
class LtoD
{
    static void Main()
    {
        long L;
        double D;
        L = 100123285L;
        D = L;

        //D = 100123285.0;
        //L = D; // Illegal!!!
        Console.WriteLine("L and D: " + L + " " + D);
    }
}