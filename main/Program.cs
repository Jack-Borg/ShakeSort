using System;
using System.Collections.Generic;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] shake = Util.GetText("../../../../Data/fullShake.txt");

            /*Console.WriteLine(Util.IsSorted(list));
            list = Insertion.Sort(list);

            Util.Show(list);
            
            Console.WriteLine(Util.IsSorted(list));*/

            /*String[] a = new String[3];

            Console.WriteLine(a[1]==null);

            Console.WriteLine(Util.Less("n","a"));*/

            //String[] b = {"e", "t", "b", "a", "g", "s", "w", "a", "y", "q"};

            foreach (string s in Merge.Sort(shake))
            {
                Console.WriteLine(s);
            }
        }
    }
}