/*A palindromic number reads the same both ways. 
The largest palindrome made from the product of 
two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product 
of two 3-digit numbers. 
(Answer = 906609) */
// ~ 3000 ticks

using System;
using System.Diagnostics;

namespace Euler04name
{
    class Euler04
    {
        static int revnum(int target) // math method to reverse a number (beware it ditches leading zeroes)
        {
            int sum = 0;
            int result = 0;
            while (target > 0)
            {
                result = target % 10;
                sum = (sum * 10) + result;
                target = target / 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int temp = 0;
            int temp2 = 0;
            int sol = 0;
            int prod1 = 0;
            int prod2 = 0;
            watch.Start();
            for (int i = 1000; i > 900; i--)
            {
                for (int j = 1000; j > 900; j--)
                {
                    temp = i * j;  // multiply nums
                    temp2 = revnum(temp); // check if palindrome
                    if (temp == temp2 & temp > sol) // if so and largest seen
                    {
                        sol = temp; // store it
                        prod1 = i; // along with numbers multiplied
                        prod2 = j; // to reach target
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", sol);
            Console.WriteLine("Product of {0} & {1}", prod1, prod2);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
