﻿/* Each new term in the Fibonacci sequence is generated by 
adding the previous two terms. 
By starting with 1 and 2, the first 10 terms will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
By considering the terms in the Fibonacci sequence whose 
values do not exceed four million,
 find the sum of the even-valued terms.
(Answer = 4613732) */
// ~ 9 ticks

using System;
using System.Diagnostics;

namespace Euler2name
{
    class Euler2
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int n1 = 1;
            int n2 = 2;
            int n3 = 0;
            int total = 2;
            while (n3 < 4000000)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if (n3 % 2 == 0)
                {
                    total += n3;
                }
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", total);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
