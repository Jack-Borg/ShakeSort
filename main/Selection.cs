using System;
using System.Collections.Generic;

namespace main
{
    public class Selection : Util
    {
        public static String[] Sort(String[] arr)
        {
            String lowest;
            int index;
            for (int pointer = 0; pointer < arr.Length; pointer++)
            {
                lowest = arr[pointer];
                index = pointer;
                for (int i = pointer + 1; i < arr.Length; i++)
                {
                    if (Less(arr[i], lowest))
                    {
                        lowest = arr[i];
                        index = i;
                    }
                }

                arr[index] = arr[pointer];
                arr[pointer] = lowest;
            }

            return arr;
        }
    }
}