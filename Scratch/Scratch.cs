using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Scratchname
{
    class Scratch
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

        static List<long> primefactors(List<long> pfactlist, int target)
        {
            Console.WriteLine();
            Console.Write("Prime factors of {0}: ", target);
            for (int i = 1; i < target; i++)
            {
                if (target % i == 0 & primefunc(i) == true) // check if prime factor
                {
                    pfactlist.Add(i); // add to list
                    target = target / i;
                    i = 1; // reset as we just divided
                }
                if (primefunc(target) == true) // check if target yet prime
                {
                    pfactlist.Add(target); // add to list
                    break; // reached end
                }
            }
            return pfactlist; // return list
        }


        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            List<long> pflist1 = new List<long>(); // make a list of prime factors
            List<long> pflist2 = new List<long>();
            List<long> pflist3 = new List<long>();
            List<long> pflist4 = new List<long>();
            List<long> pflist5 = new List<long>();
            List<long> pflist6 = new List<long>();
            List<long> pflist7 = new List<long>();
            List<long> pflist8 = new List<long>();
            List<long> pflist9 = new List<long>();
            List<long> pflist10 = new List<long>();
            List<long> pflist11 = new List<long>();
            List<long> pflist12 = new List<long>();
            List<long> pflist13 = new List<long>();
            List<long> pflist14 = new List<long>();
            List<long> pflist15 = new List<long>();
            List<long> pflist16 = new List<long>();
            List<long> pflist17 = new List<long>();
            List<long> pflist18 = new List<long>();
            List<long> pflist19 = new List<long>();
            List<long> pflist20 = new List<long>();

            pflist1 = (primefactors(pflist1, 1));
            foreach (var p in pflist1) { Console.Write("{0}, ", p); }

            pflist2 = (primefactors(pflist2, 2));
            foreach (var p in pflist2) { Console.Write("{0}, ", p); }

            pflist3 = (primefactors(pflist3, 3));
            foreach (var p in pflist3) { Console.Write("{0}, ", p); }

            pflist4 = (primefactors(pflist4, 4));
            foreach (var p in pflist4) { Console.Write("{0}, ", p); }

            pflist5 = (primefactors(pflist5, 5));
            foreach (var p in pflist5) { Console.Write("{0}, ", p); }

            pflist6 = (primefactors(pflist6, 6));
            foreach (var p in pflist6) { Console.Write("{0}, ", p); }

            pflist7 = (primefactors(pflist7, 7));
            foreach (var p in pflist7) { Console.Write("{0}, ", p); }

            pflist8 = (primefactors(pflist8, 8));
            foreach (var p in pflist8) { Console.Write("{0}, ", p); }

            pflist9 = (primefactors(pflist9, 9));
            foreach (var p in pflist9) { Console.Write("{0}, ", p); }

            pflist10 = (primefactors(pflist10, 10));
            foreach (var p in pflist10) { Console.Write("{0}, ", p); }

            pflist11 = (primefactors(pflist11, 11));
            foreach (var p in pflist11) { Console.Write("{0}, ", p); }

            pflist12 = (primefactors(pflist12, 12));
            foreach (var p in pflist12) { Console.Write("{0}, ", p); }

            pflist13 = (primefactors(pflist13, 13));
            foreach (var p in pflist13) { Console.Write("{0}, ", p); }

            pflist14 = (primefactors(pflist14, 14));
            foreach (var p in pflist14) { Console.Write("{0}, ", p); }

            pflist15 = (primefactors(pflist15, 15));
            foreach (var p in pflist15) { Console.Write("{0}, ", p); }

            pflist16 = (primefactors(pflist16, 16));
            foreach (var p in pflist16) { Console.Write("{0}, ", p); }

            pflist17 = (primefactors(pflist17, 17));
            foreach (var p in pflist17) { Console.Write("{0}, ", p); }

            pflist18 = (primefactors(pflist18, 18));
            foreach (var p in pflist18) { Console.Write("{0}, ", p); }

            pflist19 = (primefactors(pflist19, 19));
            foreach (var p in pflist19) { Console.Write("{0}, ", p); }

            pflist20 = (primefactors(pflist20, 20));
            foreach (var p in pflist20) { Console.Write("{0}, ", p); }

            watch.Stop();
            Console.WriteLine("\nTook: {0} ticks", watch.ElapsedTicks);
        }
    }
}
