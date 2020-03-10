using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            String[] shake = Util.GetText("../../../../Data/fullShake.txt");

            int count = 5;
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                stopWatch.Start();
                Trie.Sort(shake);
                stopWatch.Stop();
                total += stopWatch.Elapsed.TotalMilliseconds;
                stopWatch.Restart();
            }

            Console.WriteLine(total);
            Console.WriteLine(total/count);
        }
    }
}