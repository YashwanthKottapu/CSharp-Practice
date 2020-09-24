// Use the C format specifier to output dollars and cents.
using System;
class FormatSpecifier
{
    static void Main()
    {
        decimal price;
        decimal discount;
        decimal discounted_price;
        // Compute discounted price.
        price = 19.95m;
        discount = 0.15m; // discount rate is 15%
        discounted_price = price - (price * discount);
        Console.WriteLine("Discounted price: {0:C}", discounted_price);
    }
}