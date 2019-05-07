/* If we list all the natural numbers below 10 that are multiples of 3 or 5, 
we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000. */

using System;
using System.Diagnostics;

namespace Euler1name
{
    class Euler1
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))  // short circuited 'OR' outperforms set theory
                {
                    total += i;
                }
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", total);
            Console.WriteLine("Took: {0}", watch.ElapsedTicks);
        }
    }
}