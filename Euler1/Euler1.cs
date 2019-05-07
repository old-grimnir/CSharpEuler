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