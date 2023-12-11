using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128.Longest_Consecutive_Sequence
{
    internal class Program
    {
        static void Main()
        {
            int[] nums1 = { 100, 4, 200, 1, 3, 2 };
            int result1 = LongestConsecutive(nums1);
            Console.WriteLine("Output 1: " + result1);

            int[] nums2 = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int result2 = LongestConsecutive(nums2);
            Console.WriteLine("Output 2: " + result2);

            Console.ReadLine();
        }
        public static int LongestConsecutive(int[] nums)
        {

            HashSet<int> hashTable = new HashSet<int>(nums);
            int longestConsecutive = 0;

            foreach (int num in nums)
            {
                if (hashTable.Contains(num - 1))
                {
                    continue;
                }

                int count = 0;
                while (hashTable.Contains(num + count))
                {
                    count++;
                }

                longestConsecutive = Math.Max(longestConsecutive, count);
            }

            return longestConsecutive;
        }
    }
}
