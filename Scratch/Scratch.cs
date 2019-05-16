using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Scratchname
{
    class Scratch
    {
        private static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }



        static void Main(string[] args)
        {

            //Console.WriteLine(GCD(270, 192));
            // try prob 5 using Euclid's algorithm

            Console.WriteLine(GCD(270, 192));
        }
    }
}
