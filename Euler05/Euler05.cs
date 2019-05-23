/* 2520 is the smallest number that can be divided by 
each of the numbers from 1 to 10 without any remainder.
what is the smallest positive number that is evenly 
divisible by all of the numbers from 1 to 20?
(Answer: 232792560) */
// this version uses multiplication of prime factors to find LCM
// > 70,000 ticks

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler05name
{
    class Euler05
    {
        static Boolean primefunc(int inputNo)
        {
            if (inputNo <= 1) return false; // 1 isnt prime
            if (inputNo == 2) return true; // 2 is prime
            if (inputNo % 2 == 0) return false; // evens arent prime
            var boundary = (int)Math.Floor(Math.Sqrt(inputNo)); // set boundary
            for (int i = 3; i <= boundary; i += 2) // increment thru odds
            {
                if (inputNo % i == 0) return false;
            }
            return true;
        }


        class Nmbr
        {
            public int targ; // number in question
            public List<long> pflist = new List<long>(); // list for prime factors
            public SortedSet<long> pset = new SortedSet<long>(); // set for unique prime factors

            public Nmbr(int targ) // constructor
            {
                this.targ = targ; // supplied target
                this.pflist = primefactors(); // populate list via method
            }

            public List<long> primefactors()
            {
                for (int i = 1; i < targ; i++)
                {
                    if (targ % i == 0 & primefunc(i) == true) // check if prime factor
                    {
                        pflist.Add(i); // add to list
                        targ = targ / i;
                        i = 1; // reset as we just divided
                    }
                    if (primefunc(targ) == true) // check if target yet prime
                    {
                        pflist.Add(targ); // add to list
                        break; // reached end
                    }
                }
                foreach (var f in pflist) { this.pset.Add(f); }; // have to wait till list is full before making a set
                return pflist; // return list
            }
        }

        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            SortedSet<long> mainpset = new SortedSet<long>(); // main set of primes
            List<int> occlist = new List<int>();  // list of occurences - cross references mainpset
            List<Nmbr> coordlist = new List<Nmbr>();  // list for class instances
            for (int i = 1; i < 21; i++)
            {
                coordlist.Add(new Nmbr(i)); // add instances with target from 1 to 20
            }
            foreach (var c in coordlist) { foreach (var d in c.pset) { mainpset.Add(d); } }; // populate main set
            int counter = 0; // counter for occurences
            int highcount = 0; // track highest occurences
            foreach (var p in mainpset) // set of primes
            {
                highcount = 0; // reset counter
                foreach (var c in coordlist) // list of instances
                {
                    counter = 0;  // reset the counter at start of each instance
                    foreach (var n in c.pflist) // each instances list of prime factors
                    {
                        if (n == p) // is this the prime we are looking for
                        {
                            counter += 1;
                            if (counter > highcount)
                            {
                                highcount = counter;
                            }
                        }
                    };
                };
                occlist.Add(highcount);  // track highest number of occurences
            };
            int newcount = 0; // track position in occurence list
            double total = 1; // total so far (product needs to start as 1)
            long z = 0;
            foreach (var x in mainpset)
            {
                total *= Math.Pow(x, occlist[newcount]); // multiply by our number raised to the power of occurences (pow returns a double)
                newcount += 1; // increment occuence count
            };
            Console.WriteLine("\nAnswer: {0}", total);
            watch.Stop();
            Console.WriteLine("\nTook: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
