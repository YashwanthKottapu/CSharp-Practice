// Use a class factory.
using System;
class MyClass4
{
    int a, b; // private
    // Create a class factory for MyClass.
    public MyClass4 Factory(int i, int j)
    {
        MyClass4 t = new MyClass4();
        t.a = i;
        t.b = j;
        return t; // return an object
    }
    public void Show()
    {
        Console.WriteLine("a and b: " + a + " " + b);
    }
}
class MakeObjects
{
    static void Main()
    {
        MyClass4 ob = new MyClass4();
        int i, j;
        // Generate objects using the factory.
        for (i = 0, j = 10; i < 10; i++, j--)
        {
            MyClass4 anotherOb = ob.Factory(i, j); // make an object
            anotherOb.Show();
        }
        Console.WriteLine();
    }
}