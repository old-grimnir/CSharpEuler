using System;
using System.Linq;

namespace Euler04_linqname
{
    class Euler04_linq
    {
        static bool IsReversable(int target)
        {
            var digits = target.ToString().ToCharArray();
            return digits.SequenceEqual(digits.Reverse());
        }


        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int temp = 0;
            int sol = 0;

            for (int i = 1000; i > 900; i--)
            {
                for (int j = 1000; j > 900; j--)
                {
                    temp = i * j;
                    if (IsReversable(temp) == true && temp > sol)
                    {
                        sol = temp;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", sol);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
