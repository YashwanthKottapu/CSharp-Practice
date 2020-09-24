// Parts of the for can be Empty.

using System;

class Empty
{
    static void Main()
    {
        int i;

        for (i = 0; i <= 10; )
        {
            Console.WriteLine("Pass #" + i);
            i++;
        }
        Console.ReadLine();
    }
}