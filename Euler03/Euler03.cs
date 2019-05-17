/* The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143
        ~
Quick solution: count from 1 to target, checking for factors which are prime, add each prime factor to a list,
find product of list, if product = target, last prime added is highest 
        ~
(Answer = 6857) */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler03name
{
    class Euler03
    {
        //static Boolean primefunc(int target) // methods before main
        //{
        //    if (target <= 1) return false; // 1 isnt prime
        //    if (target == 2) return true; // 2 is prime
        //    if (target % 2 == 0) return false; // evens arent prime
        //    var boundary = (int)Math.Floor(Math.Sqrt(target)); // only need to check upto sq root
        //    for (int i = 3; i <= boundary; i += 2) // increment thru odds
        //    {
        //        if (target % i == 0) return false;
        //    }
        //    return true;
        //}

        static void Main(string[] args)
        {
            //// 50 - 120 thousand ticks
            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            //long num = 600851475143;
            //List<long> pflist = new List<long>(); // list to store prime factors
            //long prod = 1; // store product of prime factors
            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i == 0 & primefunc(i) == true) // check if prime factor
            //    {
            //        pflist.Add(i); // add to list
            //        prod = 1; // reset product (must be at least 1)
            //        foreach (var m in pflist) { prod *= m; } // multiply list contents   
            //    }
            //    if (prod == num) // if product = target, prime factor is highest
            //    {
            //        Console.WriteLine("Answer: {0}", i);
            //        break; // stop the for loop early
            //    }
            //}
            //watch.Stop();
            //Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            //Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);


            // 30 - 60 ticks using sqroot of maxfactor
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            //long n = 600851475143;
            long n = 13195;
            int lastfactor = 0; // store last factor
            int factor = 3; // 2 is treated seperately
            double maxfactor = Math.Sqrt(n); // boundary wont exceed sq root
            long answer = 0; // store answer

            if (n % 2 == 0) // if target even
            {
                n = n / 2; // divide it
                lastfactor = 2; // store factor
                while (n % 2 == 0)  // while you cant divide by 2 evenly
                {
                    n = n / 2; // DIVIDE BY TWO?!
                }
            }
            else { lastfactor = 1; } // otherwise last factor was 1

            while (n > 1 && factor <= maxfactor)
            {
                if (n % factor == 0)
                {
                    n = n / factor;
                    lastfactor = factor;
                    while (n % factor == 0) { n = n / factor; }
                    maxfactor = Math.Sqrt(n);
                }
                factor += 2;
            }

            if (n == 1) { answer = lastfactor; }
            else { answer = n; }

            watch.Stop();
            Console.WriteLine("Answer: {0}", answer);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
