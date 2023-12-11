using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238___Product_of_Array_Except_Self
{
    internal class Program
    {
        static void Main()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = ProductExceptSelf(nums1);
            DisplayArray(result1);

            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = ProductExceptSelf(nums2);
            DisplayArray(result2);

            Console.ReadLine();
        }
        public static int[] ProductExceptSelf(int[] nums)
        {

            int arraysLength = nums.Length;

            int[] prefixArr = new int[arraysLength];
            int[] suffixArr = new int[arraysLength];

            int i = 0;
            int j = arraysLength - 1;

            prefixArr[i] = suffixArr[j] = 1;

            for (i = 1; i < arraysLength; i++)
            {
                prefixArr[i] = nums[i - 1] * prefixArr[i - 1];
            }

            for (j = j - 1; j >= 0; j--)
            {
                suffixArr[j] = nums[j + 1] * suffixArr[j + 1];
            }

            int[] answerArr = new int[arraysLength];

            for (int k = 0; k < arraysLength; k++)
            {
                answerArr[k] = prefixArr[k] * suffixArr[k];
            }

            return answerArr;
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
