using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Scratchname
{
    class Scratch
    {
        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //Console.Write("Input nmber:");
            //string input = Console.ReadLine();
            //int num = Convert.ToInt32(input);
            int num = 15485863;
            int range = num + 1;
            bool[] sievearray = new bool[range]; // empty array
            for (int i = 0; i < range; i++)
            {
                sievearray[i] = true;  // initialise to true
            }
            sievearray[0] = false;  // zero not prime
            sievearray[1] = false;  // one not prime
            for (int j = 2; j < range; j++)
            {
                if (sievearray[j] == true)  // if a number is still marked prime
                {   
                    for (int k = j + j; k < range; k += j ) // mark its multiples as non prime
                    {
                        sievearray[k] = false;
                    }
                }
            }
            Console.WriteLine("Is prime: {0}", sievearray[num]);
            watch.Stop();
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }

    }
}
