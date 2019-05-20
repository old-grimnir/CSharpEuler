/* If we list all the natural numbers below 10 that are multiples of 3 or 5, 
we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000. 
(Answer = 233168) */
// this version uses inclusion exclusion principle
// ~ 40 ticks

using System;
using System.Diagnostics;

namespace Euler01name
{
    class Euler01
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            double sumofthrees = 0;
            double sumoffives = 0;
            double sumoffifteens = 0;
            double finalanswer = 0;
            for (int i = 3; i < 1000; i += 3)
            {
                sumofthrees += i;
            }
            for (int j = 5; j < 1000; j += 5)
            {
                sumoffives += j;
            }
            for (int k = 15; k < 1000; k += 15)
            {
                sumoffifteens += k;
            }
            finalanswer = (sumofthrees + sumoffives) - sumoffifteens;
            watch.Stop();
            Console.WriteLine("Answer: {0}", finalanswer);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}