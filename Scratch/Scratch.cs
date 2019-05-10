using System;
using System.Collections.Generic;

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

        static List<long> primefactors(List<long> bob, int target)
        {
            for (int i = 2; i < target; i++)
            {
                if (target % i == 0 & primefunc(i) == true) // check if prime factor
                {
                    bob.Add(i); // add to list
                    target = target / i;
                    i = 1; // reset as we just divided
                    if (primefunc(target) == true) // check if target yet prime
                    {
                        bob.Add(target); // add to list
                        break; // reached end
                    }
                }
            }
            return bob; // return list
        }


        static void Main(string[] args)
        {
            List<long> pflist1 = new List<long>(); // make a list of prime factors
            pflist1 = (primefactors(pflist1, 48));
            foreach (var m in pflist1) { Console.Write("{0}, ", m); }
        }
    }
}
