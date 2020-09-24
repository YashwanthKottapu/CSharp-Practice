// Find the radius of a circle given its area.
using System;
class FindRadius
{
    static void Main()
    {
        Double r;
        Double area;
        area = 10.0;
        r = Math.Sqrt(area / 3.1416);
        Console.WriteLine("Radius is " + r);
    }
}