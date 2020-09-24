// Determine if a number is prime. If it is not, then
// display its largest factor.
using System;
class FindPrimes
{
    static void Main()
    {
        int num;
        int i;
        int factor;
        bool isprime;
        for (num = 2; num < 20; num++)
        {
            isprime = true;
            factor = 0;
            // See if num is evenly divisible.
            for (i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                {
                    // num is evenly divisible. Thus, it is not prime.
                    isprime = false;
                    factor = i;
                }
            }
            if (isprime)
                Console.WriteLine(num + " is prime.");
            else
                Console.WriteLine("Largest factor of " + num +
                " is " + factor);
        }
        Console.ReadLine();

        // Tried it on my own.

        //for (num = 2; num <= 20; num++)
        //{
        //    for (i = 2; i <= num; i++)
        //    {
        //        if ((num % i) == 0)
        //        {
        //            if (num == i)
        //            {
        //                Console.WriteLine(num + " is Prime.");
        //            }
        //            else
        //            {
        //                Console.WriteLine(num + " is not Prime.");
        //            }
        //        }
        //    }
        //}
        //Console.ReadLine();
    }
}