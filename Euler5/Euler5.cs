/* 2520 is the smallest number that can be divided by 
each of the numbers from 1 to 10 without any remainder.
what is the smallest positive number that is evenly 
divisible by all of the numbers from 1 to 20?
(Answer: 232792560) */
// this is not ideal ( 210107 ticks) 
// option A: prime factors to find LCM
// option B: find GCD to find LCM

using System;
using System.Diagnostics;

namespace Euler5name
{
    class Euler5
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int i = 20;
            watch.Start();
            while (i % 3 != 0 || i % 4 != 0 || i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 || i % 11 != 0 ||
            i % 12 != 0 || i % 13 != 0 || i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 || i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i += 20; // increments of 20, highest number we need divisable. removed 2, 5, and 10. 
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", i);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
        }
    }
}
