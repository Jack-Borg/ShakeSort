using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
    public class Heap : Util
    {
        private static String[] _arr;

        public static String[] Sort(String[] input)
        {
            _arr = input;
            ToHeap();

            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                _arr = Switch(_arr, 0, i);
                Heapify(0, i);
            }

            return _arr;
        }

        private static void ToHeap()
        {
            for (int i = _arr.Length / 2 - 1; i >= 0; i--)
                Heapify(i, _arr.Length);
        }

        private static void Heapify(int i, int limiter)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < limiter && Less(_arr[largest], _arr[left]))
                largest = left;
            if (right < limiter && Less(_arr[largest], _arr[right]))
                largest = right;
            if (largest != i)
            {
                _arr = Switch(_arr, i, largest);
                Heapify(largest, limiter);
            }
        }
    }
}