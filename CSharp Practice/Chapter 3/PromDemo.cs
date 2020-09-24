// A promotion surprise!
using System;
class PromDemo
{
    static void Main()
    {
        byte b;
        b = 10;
        b = (byte)(b * b); // cast needed!!
        Console.WriteLine("b: " + b);
    }
}