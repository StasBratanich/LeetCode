using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347___Top_K_Frequent_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] nums1 = { 1, 1, 1, 2, 2, 3 };
            int k1 = 2;
            int[] result1 = TopKFrequent(nums1, k1);
            DisplayArray(result1);

            int[] nums2 = { 1 };
            int k2 = 1;
            int[] result2 = TopKFrequent(nums2, k2);
            DisplayArray(result2);

            Console.ReadLine();
        }
        public static int[] TopKFrequent(int[] nums, int k)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            var sortedDict = dict.OrderByDescending(x => x.Value);
            var maxKValues = sortedDict.Take(k).Select(x => x.Key).ToArray();

            return maxKValues;
        }
        static void DisplayArray(int[] arr)
        {
            Console.Write("[");
            foreach (int num in arr)
            {
                Console.Write(num + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
