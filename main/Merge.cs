using System;

namespace main
{
    public class Merge : Util
    {
        private static String[] _tmp;
        
        public static String[] Sort(String[] arr)
        {
            _tmp = new String[arr.Length];
            Sort(arr, 0 , arr.Length-1);
            return arr;
        }

        private static void Sort(String[] arr, int low, int high)
        {
            if (high <= low) return;
            int mid = low + (high - low) / 2;
            Sort(arr, low, mid);
            Sort(arr, mid + 1, high);
            merge(arr, low, mid, high);
        }
        
        private static void merge(String[] arr, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;
            
            for (int k = low; k <= high; k++)
                _tmp[k] = arr[k];
            
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                    arr[k] = _tmp[j++];
                else if (j > high)
                    arr[k] = _tmp[i++];
                else if (Less(_tmp[j], _tmp[i]))
                    arr[k] = _tmp[j++];
                else
                    arr[k] = _tmp[i++];
            }
        }
    }
}