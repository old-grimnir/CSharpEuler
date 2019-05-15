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
                Console.WriteLine();
                Console.Write("\nPrime factors of {0} = ", this.targ);
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
                foreach (var pf in pflist) { Console.Write("{0}, ", pf); }; // prime factors
                // make set
                Console.Write("| Set: ");
                foreach (var f in pflist) { this.pset.Add(f); }; // have to wait till list is full before making a set
                foreach (var v in pset) { Console.Write("{0}, ", v); }; // print set
                return pflist; // return list
            }
        }

        //TODO
            // iterate lists and make a set
            // count occurences in set
            // multiply max occurences
            // fin


        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            SortedSet<long> mainpset = new SortedSet<long>();
            List<Coords> coordlist = new List<Coords>();
            for (int i = 1; i < 21; i++)
            {
                coordlist.Add(new Coords(i));
            }
            foreach (var c in coordlist) { foreach (var d in c.pset) { mainpset.Add(d); } };
            //coordlist.Add(new Coords(456));
            //foreach (var p in coordlist) { Console.Write("\n{0} , {1}", p.x, p.y); }
            //foreach (var p in coordlist) { foreach (var x in p.pflist) { Console.Write("{0}, ", x); }; }
            watch.Stop();
            Console.WriteLine("\nTook: {0} ticks", watch.ElapsedTicks);
            Console.Write("\nPrime Set: ");
            foreach (var e in mainpset) { Console.Write("{0}, ", e); };
            Console.Write("\n");

            // make a list, 0 is first in set, 1 is second in set, 2 so on...
            // in this case, index 0 is 2, index 1 is 3, index 2 is 5

        }
    }
}
