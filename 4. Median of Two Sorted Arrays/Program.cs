using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1_1 = { 1, 3 };
            int[] nums2_1 = { 2 };
            Console.WriteLine(FindMedianSortedArrays(nums1_1, nums2_1)); // Expected output: 2.00000

            int[] nums1_2 = { 1, 2 };
            int[] nums2_2 = { 3, 4 };
            Console.WriteLine(FindMedianSortedArrays(nums1_2, nums2_2)); // Expected output: 2.50000

            Console.WriteLine("--------------------------------------");

            int[] nums1_3 = { 1, 3 };
            int[] nums2_3 = { 2 };
            Console.WriteLine(BruteForceFindMedianSortedArrays(nums1_3, nums2_3)); // Expected output: 2.00000

            int[] nums1_4 = { 1, 2 };
            int[] nums2_4 = { 3, 4 };
            Console.WriteLine(BruteForceFindMedianSortedArrays(nums1_4, nums2_4)); // Expected output: 2.50000

            Console.ReadLine();
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedNums = new int[nums1.Length + nums2.Length];



            return 0.0;
        }

        public static double BruteForceFindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedNums = new int[nums1.Length + nums2.Length];
            double numsMedian = 0.0;
            mergedNums = mergeArrays(nums1, nums2);
            
            if ((mergedNums.Length) % 2 == 0)
            {
                numsMedian = (double)(mergedNums[mergedNums.Length / 2] + mergedNums[mergedNums.Length / 2 - 1]) / 2;
            }
            else
            {
                numsMedian = (double)mergedNums[mergedNums.Length / 2];
            }

            return numsMedian;
        }

        public static int[] mergeArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = new int[nums1.Length + nums2.Length];

            int index_nums1 = 0, index_nums2 = 0;
            int index_numsMerged = 0;

            while (index_nums1 < nums1.Length && index_nums2 < nums2.Length)
            {
                if (nums1[index_nums1] < nums2[index_nums2])
                {
                    mergedArray[index_numsMerged++] = nums1[index_nums1++];
                }
                else
                {
                    mergedArray[index_numsMerged++] = nums2[index_nums2++];
                }
            }

            while (index_nums1 < nums1.Length)
            {
                mergedArray[index_numsMerged++] = nums1[index_nums1++];
            }

            while (index_nums2 < nums2.Length)
            {
                mergedArray[index_numsMerged++] = nums2[index_nums2++];
            }

            return mergedArray;
        }
    }
}
