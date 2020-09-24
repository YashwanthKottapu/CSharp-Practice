using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class pyramid
{
    static void Main()
    {
        //for (int lineNo = 1; lineNo <= 4; lineNo++)
        //{
        //    for (int digit = 1; digit <= lineNo; digit++)
        //    {
        //        Console.Write(digit + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        //for (int lineNo = 1; lineNo <= 4; lineNo++)

        //{
        //    for (int star = 1; star <= lineNo; star++)
        //    {
        //        Console.Write("*" + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        char[] str = { '9', '9', '9' };

        int i = 0, sum = 0;
        for (i = 0; i < str.Length; i++)
        {
            var ch = str[i];
            var minus = str[i] - 48;
            sum = sum * 10 + minus;
        }
        Console.WriteLine(sum);
        Console.ReadLine();
    }
}
