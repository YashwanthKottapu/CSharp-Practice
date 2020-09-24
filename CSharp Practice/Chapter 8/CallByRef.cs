// Objects are passed by reference.
using System;
class Test2
{
    public int a, b;
    public Test2(int i, int j)
    {
        a = i;
        b = j;
    }
    /* Pass an object. Now, ob.a and ob.b in object
    used in the call will be changed. */
    public void Change(Test2 oba)
    {
        oba.a = oba.a + oba.b;
        oba.b = -oba.b;
    }
}

class CallByRef
{
    static void Main()
    {
        Test2 ob = new Test2(15, 20);
        Console.WriteLine("ob.a and ob.b before call: " +
        ob.a + " " + ob.b);
        ob.Change(ob);
        Console.WriteLine("ob.a and ob.b after call: " +
        ob.a + " " + ob.b);
    }
}
