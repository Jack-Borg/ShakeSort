using System;
using System.Collections.Generic;

namespace main
{
    public class Insertion : Util
    {
        public static String[] Sort(String[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                for (int j = i; j > 0 && Less(list[j], list[j-1]); j--)
                {
                    list = Switch(list, j, j - 1);
                }
            }
            return list;
        }
    }
}