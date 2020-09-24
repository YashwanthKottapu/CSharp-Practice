// Demonstrate an overloaded constructor.
using System;
class MyClass5
{
    public int x;
    public MyClass5()
    {
        Console.WriteLine("Inside MyClass().");
        x = 0;
    }
    public MyClass5(int i)
    {
        Console.WriteLine("Inside MyClass(int).");
        x = i;
    }
    public MyClass5(double d)
    {
        Console.WriteLine("Inside MyClass(double).");
        x = (int)d;
    }
    public MyClass5(int i, int j)
    {
        Console.WriteLine("Inside MyClass(int, int).");
        x = i * j;
    }
}
class OverloadConsDemo
{
    static void Main()
    {
        MyClass5 t1 = new MyClass5();
        MyClass5 t2 = new MyClass5(88);
        MyClass5 t3 = new MyClass5(17.23);
        MyClass5 t4 = new MyClass5(2, 4);
        Console.WriteLine("t1.x: " + t1.x);
        Console.WriteLine("t2.x: " + t2.x);
        Console.WriteLine("t3.x: " + t3.x);
        Console.WriteLine("t4.x: " + t4.x);
    }
}