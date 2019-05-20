/* The sum of the squares of the first ten natural numbers is,
 1*1 + 2*2 + ... + 10*10 = 385
The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)*(1 + 2 + ... + 10) = 55*55 = 3025
Hence the difference between the sum of the squares of the 
first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the 
first one hundred natural numbers and the square of the sum.
(Answer: 25164150) */
// ~ 10 ticks

using System;
using System.Diagnostics;

namespace Euler06name
{
    class Euler06
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int sumsq = 0;
            int sqsum = 0;
            int answerdif = 0;
            watch.Start();
            for (int i = 1; i < 101; i++)
            {
                sumsq += (i * i);
                sqsum += i;
            }
            sqsum = sqsum * sqsum;
            answerdif = (sqsum - sumsq);
            watch.Stop();
            Console.WriteLine("Answer: {0}", answerdif);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
