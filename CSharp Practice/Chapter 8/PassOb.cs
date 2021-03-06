﻿// References can be passed to methods.
using System;

class MyClass2
{
    int alpha, beta;

    public MyClass2(int i, int j)
    {
        alpha = i;
        beta = j;
    }
    // Return true if ob contains the same values as the invoking object.
    public bool SameAs(MyClass2 ob)
    {
        if ((ob.alpha == alpha) & (ob.beta == beta))
            return true;
        else return false;
    }
    // Make a copy of ob.
    public void Copy(MyClass2 ob)
    {
        alpha = ob.alpha;
        beta = ob.beta;
    }
    public void Show()
    {
        Console.WriteLine("alpha: {0}, beta: {1}",
        alpha, beta);
    }
}

class PassOb
{
    static void Main()
    {
        MyClass2 ob1 = new MyClass2(4, 5);
        MyClass2 ob2 = new MyClass2(6, 7);
        Console.Write("ob1: ");
        ob1.Show();
        Console.Write("ob2: ");
        ob2.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 and ob2 have the same values.");
        else
            Console.WriteLine("ob1 and ob2 have different values.");
        Console.WriteLine();
        // Now, make ob1 a copy of ob2.
        ob1.Copy(ob2);
        Console.Write("ob1 after copy: ");
        ob1.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 and ob2 have the same values.");
        else
            Console.WriteLine("ob1 and ob2 have different values.");
    }
}