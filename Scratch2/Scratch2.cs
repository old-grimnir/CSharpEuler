﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Scratch2name
{
    class Scratch2
    {
        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int num = 15485863;
            int range = num + 1;
            List<bool> pl = new List<bool>(); // empty list
            for (int i = 0; i < range; i++)
            {
                pl.Add(true); // initialise it
            }
            pl[0] = false; // 0 not prime
            pl[1] = false; // 1 not prime
            for (int j = 2; j < range; j++) // start at 2
            {
                if (pl[j] == true) // look for 'true'
                {
                    for (int k = j + j; k < range; k += j)
                    {
                        pl[k] = false; // mark out all multiples
                    }
                }
            }
            Console.WriteLine("Is prime: {0}", pl[num]);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
