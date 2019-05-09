/* 2520 is the smallest number that can be divided by 
each of the numbers from 1 to 10 without any remainder.
what is the smallest positive number that is evenly 
divisible by all of the numbers from 1 to 20?
(Answer: 232792560) */

// this is bad (2760227 ticks) 
// a better approach would be LCM of a set
// find prime factors  of 1-20
// ???
// profit
// http://www.math.com/school/subject1/lessons/S1U3L3DP.html
//
// go through list of numbers
// create list of prime factors & list of greatest occurences
// multiply each number according to its greatest number of occurences
// i.e 
// 30 = 2 * 3 * 5
// 45 = 3 * 3 * 5
// LCM = 2 * 3 * 3 * 5 = 90
// do magic
// get answer

// create prime checker
// look for prime factors
// use a list
// index of list is number being checked
// content at index is a list of prime factors
// ( 0 would be empty)
// make another list of occurences
// might need a dict for this
// prime fact : occurences
// find most occurences
// multiply em all
// find answer




using System;
using System.Diagnostics;

namespace Euler5name
{
    class Euler5
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int i = 1;
            watch.Start();
            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 || i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 || i % 10 != 0 || i % 11 != 0 ||
            i % 12 != 0 || i % 13 != 0 || i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 || i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i++;
            }
            watch.Stop();
            Console.WriteLine("Answer: {0}", i);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
        }
    }
}
