/* If we list all the natural numbers below 10 that are multiples of 3 or 5, 
we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
This version uses set theory to reduce calculations, but due
to c#'s short circuit 'OR' (||) this is mostly slower 
(Answer = 233168) */

using System;
using System.Diagnostics;

namespace Euler1settheoryname
{
    class Euler1settheory
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            double sumofthrees = 0;
            double sumoffives = 0;
            double sumoffifteens = 0;
            double finalanswer = 0;
            watch.Start();
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0) { sumofthrees += i; }
                if (i % 5 == 0) { sumoffives += i; }
                if (i % 15 == 0) { sumoffifteens += i; }
                finalanswer = (sumofthrees + sumoffives) - sumoffifteens;
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", finalanswer);
            Console.WriteLine("Took: {0}", watch.ElapsedTicks);
        }
    }
}