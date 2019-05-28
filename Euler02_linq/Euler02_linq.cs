using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler02_linqname
{
    class Euler02_linq
    {
        static void Main(string[] args)
        {
            
            
            // Using long just to avoid having to change if we want a higher limit :)
            IEnumerable<long> Fibonacci()
            {
                long current = 0;
                long next = 1;
                long temp;
                while (true)
                {
                    yield return current; // returns current no.
                    temp = next; // temporaily store next no.
                    next = current + next; // prepare next no.
                    current = temp; // assign next no.
                }
            }


            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            long evenSum = Fibonacci().TakeWhile(x => x < 4000000L)  // 'x =>' seems to be iterator
                          .Where(y => y % 2 == 0)  // second iterator declared here
                          .Sum();

            //Console.WriteLine(evenSum);
            watch.Stop();
            Console.WriteLine("Answer: {0}", evenSum);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
