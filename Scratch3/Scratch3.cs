using System;
using System.Collections;

namespace Scratch3name
{
    class Scratch3
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Hashtable ht = new Hashtable();
            int num = 15485863;
            int range = num + 1;
            for (int i = 0; i < range; i++)
            {
                ht.Add(i, true);
            }
            ht[0] = false;
            ht[1] = false;
            for (int j = 2; j < range; j++)
            {
                if (ht[j].Equals(true))
                {
                    for (int k = j + j; k < range; k += j )
                    {
                        ht[k] = false;
                    }
                }
            }
            Console.WriteLine("Is prime: {0}", ht[num]);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
