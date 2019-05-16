using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Scratch2name
{
    class Scratch2
    {
        static Boolean primefunc(int inputNo) // methods before main
        {
            if (inputNo <= 1) return false; // 1 isnt prime
            if (inputNo == 2) return true; // 2 is prime
            if (inputNo % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(inputNo));
            for (int i = 3; i <= boundary; i += 2) // increment thru odds
            {
                if (inputNo % i == 0) return false;
            }
            return true;
        }


        class Coords //
        {
            public int targ;
            public List<long> pflist = new List<long>();
            public SortedSet<long> pset = new SortedSet<long>();
            
            public Coords(int targ) // constructor
            {
                this.targ = targ;
                this.pflist = primefactors();       
            }

            public List<long> primefactors()
            {
                //Console.WriteLine();
                //Console.Write("\nPrime factors of {0} = ", this.targ);
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
                //Console.Write("{0}:", target);
                //foreach (var pf in pflist) { Console.Write("{0}, ", pf); }; // prime factors
                // make set
                //Console.Write("| Set: ");
                foreach (var f in pflist) { this.pset.Add(f); }; // have to wait till list is full before making a set
                //foreach (var v in pset) { Console.Write("{0}, ", v); }; // print set
                return pflist; // return list
            }
        }


        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            SortedSet<long> mainpset = new SortedSet<long>(); // set of primes
            List<int> occlist = new List<int>();  // list of occurences - cross references mainpset
            List<Coords> coordlist = new List<Coords>();  // list of class instances
            for (int i = 1; i < 21; i++)
            {
                coordlist.Add(new Coords(i));
            }
            foreach (var c in coordlist) { foreach (var d in c.pset) { mainpset.Add(d); } };
            //Console.Write("\nPrime Set: ");
            //foreach (var e in mainpset) { Console.Write("{0}, ", e); };
            //Console.Write("\n");
            int counter = 0;
            int highcount = 0;
            foreach (var p in mainpset) // set of primes
            {
                counter = 0;
                highcount = 0;
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
            //Console.Write("Occurences: ");
            //foreach (var h in occlist) { Console.Write(h); };
            int newcount = 0;
            double total = 1;
            long z = 0;
            foreach (var x in mainpset)
            {
                z = occlist[newcount];
                total *= Math.Pow(x, z); // multiply by our number raised to the power of occurences (pow returns a double)
                newcount += 1;
            };
            Console.WriteLine("\nAnswer: {0}", total);
            watch.Stop();
            Console.WriteLine("\nTook: {0} ticks", watch.ElapsedTicks);
        }
    }
}
