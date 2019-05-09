using System;
using System.Collections.Generic;

namespace Scratchname
{
    class Scratch
    {
        static Boolean primefunc(int target) // methods before main
        {
            if (target <= 1) return false; // 1 isnt prime
            if (target == 2) return true; // 2 is prime
            if (target % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(target));
            for (int i = 3; i <= boundary; i += 2) // increment thru odds
            {
                if (target % i == 0) return false;
            }
            return true;
        }

        static List<long> primefactors(List<long> bob, int target)
        {
            for (int i = 1; i < target; i++)
            {
                if (target % i == 0 & primefunc(i) == true) // check if prime factor
                {
                    bob.Add(i); // add to list
                }
            }
            return bob;
        }


        static void Main(string[] args)
        {
            List<long> pflist20 = new List<long>(); // make a list of prime factors
            pflist20 = (primefactors(pflist20, 12));
            foreach (var m in pflist20) { Console.WriteLine(m); }

        }
    }
}
