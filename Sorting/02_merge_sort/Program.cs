using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>()
            {
                2, 4, 1, 6, 8 , 5, 3, 7, 6, 6, 2, 1, 6, 4, 2, 0
            };
            Console.WriteLine("Original");
            foreach (var number in prices)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Sorted");
            List<int> sorted = MergeSort(prices);
            
            foreach (var number in sorted)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }

    }
}
