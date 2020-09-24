// An example that uses an implicit conversion operator.
using System;
// A three-dimensional coordinate class.
class ThreeDclass
{
    int x, y, z; // 3-D coordinates
    public ThreeDclass() { x = y = z = 0; }
    public ThreeDclass(int i, int j, int k) { x = i; y = j; z = k; }
    // Overload binary +.
    public static ThreeDclass operator +(ThreeDclass op1, ThreeDclass op2)
    {
        ThreeDclass result = new ThreeDclass();
        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;
        return result;
    }
    // An implicit conversion from ThreeD to int.
    public static implicit operator int(ThreeDclass op1)
    {
        return op1.x * op1.y * op1.z;
    }
    // Show X, Y, Z coordinates.
    public void Show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}

class ConversionOperator
{
    static void Main()
    {
        ThreeDclass a = new ThreeDclass(1, 2, 3);
        ThreeDclass b = new ThreeDclass(10, 10, 10);
        ThreeDclass c = new ThreeDclass();
        int i;
        Console.Write("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Here is b: ");
        b.Show();
        Console.WriteLine();
        c = a + b; // add a and b together
        Console.Write("Result of a + b: ");
        c.Show();
        Console.WriteLine();
        i = a; // convert to int
        Console.WriteLine("Result of i = a: " + i);
        Console.WriteLine();
        i = a * 2 - b; // convert to int
        Console.WriteLine("result of a * 2 - b: " + i);
    }
}