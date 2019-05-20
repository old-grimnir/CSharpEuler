/* The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143
        ~
Quick solution (50-120,000 ticks): count from 1 to target, checking for factors which are prime, add each prime factor to a list,
find product of list, if product = target, last prime added is highest 
        ~
Quicker solution (30 - 60 ticks): Divide out all the factors until we are left with highest prime factor
        ~
(Answer = 6857) */
// ~ 50 ticks

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


            // 30 - 60 ticks using sqroot maxfactor boundary
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            long n = 600851475143;
            //long n = 13195;
            int lastfactor = 0; // store last factor
            int factor = 3; // 2 is treated seperately
            double maxfactor = Math.Sqrt(n); // boundary wont exceed sq root
            long answer = 0; // store answer
            if (n % 2 == 0) // if target even (treat 2's seperately for speed)
            {
                n = n / 2; // divide it
                lastfactor = 2; // store factor
                while (n % 2 == 0)  // while you can divide by 2 evenly
                {
                    n = n / 2; // divide by 2
                }
            }
            else
            {
                lastfactor = 1; // otherwise last factor was 1 (gonna overwrite anyway)
            } 
            while (n > 1 && factor <= maxfactor) // using sqroot as boundary (maxfactor)
            {
                if (n % factor == 0)  // its a factor
                {
                    n = n / factor;  // divide it
                    lastfactor = factor;  // record it
                    while (n % factor == 0) { n = n / factor; } // keep dividing
                    maxfactor = Math.Sqrt(n); // record new boundary
                }
                factor += 2; // increment by 2 (only dealing with odds)
            }
            if (n == 1)
            {
                answer = lastfactor; // if we've divided out everything lastfactor is winner
            } 
            else
            {
                answer = n; // otherwise its n
            } 
            watch.Stop();
            Console.WriteLine("Answer: {0}", answer);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
