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
            Int32 vals = Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            watch.Stop();
            Console.WriteLine("Answer: {0}", vals);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
