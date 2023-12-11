using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] nums1 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result1 = ThreeSum(nums1);
            DisplayList(result1);

            int[] nums2 = { 0, 1, 1 };
            IList<IList<int>> result2 = ThreeSum(nums2);
            DisplayList(result2);

            int[] nums3 = { 0, 0, 0 };
            IList<IList<int>> result3 = ThreeSum(nums3);
            DisplayList(result3);

            Console.ReadLine();
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            Array.Sort(nums);
            IList<IList<int>> answerList = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                int target = -nums[i];

                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        List<int> addList = new List<int>() { nums[i], nums[left], nums[right] };
                        answerList.Add(addList);

                        while (left < right && nums[left] == addList[1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == addList[2])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }

                    else if (nums[left] + nums[right] > target)
                    {
                        right--;
                    }

                    else
                    {
                        left++;
                    }
                }
            }

            return answerList;
        }
        static void DisplayList(IList<IList<int>> resultList)
        {
            foreach (var list in resultList)
            {
                Console.Write("[");
                foreach (var num in list)
                {
                    Console.Write(num + ", ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
