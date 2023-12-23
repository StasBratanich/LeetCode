using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _153.Find_Minimum_in_Rotated_Sorted_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = { 3, 4, 5, 1, 2 };
            int result1 = FindMin(nums1);
            Console.WriteLine($"Input: nums = [{string.Join(",", nums1)}], Output: {result1}");

            int[] nums2 = { 4, 5, 6, 7, 0, 1, 2 };
            int result2 = FindMin(nums2);
            Console.WriteLine($"Input: nums = [{string.Join(",", nums2)}], Output: {result2}");

            int[] nums3 = { 11, 13, 15, 17 };
            int result3 = FindMin(nums3);
            Console.WriteLine($"Input: nums = [{string.Join(",", nums3)}], Output: {result3}");

            Console.ReadLine();
        }
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int minVal = nums[0];

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    if (minVal > nums[left])
                    {
                        minVal = nums[left];
                        break;
                    }
                }

                int mid = left + (right - left) / 2;

                if (nums[mid] < minVal)
                {
                    minVal = nums[mid];
                }

                if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return minVal;
        }
    }
}
