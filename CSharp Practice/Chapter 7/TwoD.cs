// Demonstrate a two-dimensional array.
using System;
class TwoD
{
    static void Main()
    {
        int row, column;
        int count = 0;
        int[,] table = new int[3, 4];

        for (row = 0; row < 3; row++)
        {
            for (column = 0; column < 4; column++)
            {
                count++;
                table[row, column] = count;
                Console.Write(table[row, column] + "\t");
            }
            Console.WriteLine();
        }
    }
}