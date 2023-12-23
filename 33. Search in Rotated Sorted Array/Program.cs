using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _33.Search_in_Rotated_Sorted_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = { 4, 5, 6, 7, 0, 1, 2 };
            int target1 = 0;
            int result1 = Search(nums1, target1);
            Console.WriteLine($"Input: nums = [{string.Join(",", nums1)}], target = {target1}: Output: {result1}");

            int[] nums2 = { 4, 5, 6, 7, 0, 1, 2 };
            int target2 = 3;
            int result2 = Search(nums2, target2);
            Console.WriteLine($"input: nums = [{string.Join(",", nums2)}], target = {target2}: output: {result2}");

            int[] nums3 = { 1 };
            int target3 = 0;
            int result3 = Search(nums3, target3);
            Console.WriteLine($"input: nums = [{string.Join(",", nums3)}], target = {target3}: output: {result3}");

            int[] nums4 = { 1, 3 };
            int target4 = 3;
            int result4 = Search(nums4, target4);
            Console.WriteLine($"Input: nums = [{string.Join(",", nums4)}], target = {target4}: Output: {result4}");

            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] >= nums[left])
                {
                    if (target > nums[mid] || target < nums[left])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (target < nums[mid] || target > nums[right])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
