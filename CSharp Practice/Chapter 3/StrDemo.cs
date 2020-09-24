// Demonstrate escape sequences in strings.
using System;
class StrDemo
{
    static void Main()
    {
        Console.WriteLine("Line One\nLine Two\nLine Three");
        Console.WriteLine("One\tTwo\tThree");
        Console.WriteLine("Four\tFive\tSix");
        // Embed quotes.
        Console.WriteLine("\"Why?\", he asked.");
    }
}