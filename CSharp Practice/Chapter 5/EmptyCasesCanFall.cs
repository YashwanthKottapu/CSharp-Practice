﻿// Empty cases can fall through.

using System;
class EmptyCasesCanFall
{
    static void Main()
    {
        int i;
        for (i = 1; i < 5; i++)
            switch (i)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("i is 1, 2 or 3");
                    break;
                case 4: Console.WriteLine("i is 4");
                    break;
            }
        Console.Read();
    }
}