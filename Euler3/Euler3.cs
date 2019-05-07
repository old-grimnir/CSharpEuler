/* The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143
        ~
Quick solution: count from 1 to target, checking for factors which are prime, add each prime factor to a list,
find product of list, if product = target, last prime added is highest 
        ~
(Answer = 6857) */

using System;
using System.Collections.Generic;

namespace Euler3name
{
    class Euler3
    {
        static Boolean primefunc(int target) // methods before main
        {
            if (target <= 1) return false; // 1 isnt prime
            if (target <= 3) return true; // 2 and 3 are prime
            if (target % 2 == 0) return false; // evens arent prime
            var boundary = (int)Math.Floor(Math.Sqrt(target));
            for (int i = 5; i <= boundary; i += 2) // 5 is next odd value, increment thru odds
            {
                if (target % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            long num = 600851475143;
            List<long> pflist = new List<long>(); // list to store prime factors
            long prod = 1; // store product of prime factors
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 & primefunc(i) == true) // check if current no is a factor
                {   
                    pflist.Add(i); // add to list
                    prod = 1; // reset product (must be at least 1)
                    foreach (var m in pflist) { prod *= m; } // multiply list contents   
                }
                if (prod == num) // if product = target, prime factor is highest
                {
                    Console.WriteLine("Done");
                    Console.WriteLine(i);
                    return; // stop the for loop
                }
            }
        }
    }
}
