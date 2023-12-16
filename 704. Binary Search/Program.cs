using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _704.Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target1 = 9;
            int target2 = 2;

            Console.WriteLine(OwnCreatedSearch(nums, target1));
            Console.WriteLine(OwnCreatedSearch(nums, target2));

            Console.ReadLine();
        }

        public static int OwnCreatedSearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] nums, int target)
        {
            int i =  Array.BinarySearch(nums, target);
            return (i < 0) ? -1 : i;
        }
    }
}
