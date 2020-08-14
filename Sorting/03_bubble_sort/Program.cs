using System;
using System.Collections.Generic;

namespace _03_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>()
            {
                2, 4, 1, 6, 8 , 5, 3, 7, 6, 6, 2, 1, 6, 4, 2, 0
            };
            Console.WriteLine("Old list");
            foreach (var number in prices)
            {
                Console.Write(number + " ");
            } 

            for (int i = 0; i < prices.Count - 1; i++)
            {
                for (int j = 0; j < prices.Count - 1; j++)
                {
                    if (prices[j] > prices[j + 1])
                    {
                        var temp = prices[j + 1];
                        prices[j + 1] = prices[j];
                        prices[j] = temp;
                    };
                }
            }
            Console.WriteLine("\nNew list");
            foreach (var number in prices)
            {
                Console.Write(number + " ");
            }
        }
    }
}
