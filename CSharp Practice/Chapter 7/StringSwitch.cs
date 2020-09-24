// A string can control a switch statement.

using System;

class StringSwitch
{
    static void Main()
    {
        string[] strs = { "one", "two", "three", "two", "one" };

        foreach (string str in strs)
        {
            switch (str)
            {
                case "one": Console.Write(1);
                    break;
                case "two": Console.Write(2);
                    break;
                case "three": Console.Write(3);
                    break;
            }
        }
        Console.WriteLine();
    }
}