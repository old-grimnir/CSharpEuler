using System;
using System.Linq;

namespace Euler01_linqname
{
    class Euler01_linq
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int[] vals = Enumerable.Range(1, 999).ToArray(); // array comprehension
            int total = 0;

            var lq = from v in vals  // actual linq query
                     where (v % 3 == 0) || (v % 5 == 0)
                     select v;

            foreach (var sv in lq) // use the linq object
            {
                total += sv;
            };

            watch.Stop();
            Console.WriteLine("Answer: {0}", total);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
