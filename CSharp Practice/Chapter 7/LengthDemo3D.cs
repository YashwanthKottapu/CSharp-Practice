// Use the Length array property on a 3D array.
using System;
class LengthDemo3D
{
    static void Main()
    {
        int[, ,] nums = new int[10, 5, 6];
        Console.WriteLine("Length of nums is " + nums.Length);
    }
}