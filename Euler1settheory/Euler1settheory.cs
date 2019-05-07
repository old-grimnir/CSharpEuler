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