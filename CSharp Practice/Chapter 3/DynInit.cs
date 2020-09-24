// Demonstrate Dynamic Initialization

using System;

class DynInit
{
    static void Main()
    {
        //Length of sides.
        double s1 = 4.0;
        double s2 = 5.0;

        //Dynamically initialize hypot.
        double hypot=Math.Sqrt((s1*s1)+(s2*s2));

        Console.WriteLine("Hypotenuse of triangle with sides " + s1 + " by " + s2 + " is ");
        Console.WriteLine("{0:#.###}", hypot);
    }
}