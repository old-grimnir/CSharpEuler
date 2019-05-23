/* The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143
        ~
Solution (30 - 60 ticks): Divide out all the factors until we are left with highest prime factor
        ~
(Answer = 6857) */
// ~ 50 ticks

using System;

namespace Euler03name
{
    class Euler03
    {
        static void Main(string[] args)
        {
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
