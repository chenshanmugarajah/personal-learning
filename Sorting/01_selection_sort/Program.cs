using System;
using System.Collections.Generic;

namespace _01_selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>()
            {
                314, 454, 656, 123, 454, 676, 342, 767, 111, 11123
            };

            Console.WriteLine("old list");
            foreach (var number in prices)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");

            int smallest, temp;

            for (int i = 0; i < prices.Count; i++)
            {
                smallest = i;

                for (int j = i+1; j < prices.Count; j++)
                {
                    if (prices[j] < prices[smallest]) smallest = j;
                }
                temp = prices[smallest];
                prices[smallest] = prices[i];
                prices[i] = temp;
            }

            Console.WriteLine("new list");
            foreach (var number in prices)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}
