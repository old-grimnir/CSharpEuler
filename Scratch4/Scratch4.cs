using System;
using System.Collections.Generic;

namespace Scratch4name
{
    class Scratch4
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int num = 15485863;
            int range = num + 1;
            Dictionary<int, bool> newdic = new Dictionary<int, bool>();
            for (int i = 0; i < range; i++)
            {
                newdic[i] = true;
            }
            newdic[0] = false;
            newdic[1] = false;
            for (int j = 2; j < range; j++)
            {
                if (newdic[j] == true)
                {
                    for (int k = j + j; k < range; k += j)
                    {
                        newdic[k] = false;
                    }
                }
            }
            Console.WriteLine("Is prime: {0}", newdic[num]);
            watch.Stop();
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
