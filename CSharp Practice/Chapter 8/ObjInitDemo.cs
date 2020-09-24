// A simple demonstration that uses object initializers.
using System;
class MyClass6
{
    public int Count;
    public string Str;
}
class ObjInitDemo
{
    static void Main()
    {
        // Construct a MyClass object by using object initializers.
        MyClass6 obj = new MyClass6
        {
            Count = 100,
            Str = "Testing"
        };
        Console.WriteLine(obj.Count + " " + obj.Str);
    }
}