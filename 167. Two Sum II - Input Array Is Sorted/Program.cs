using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _167.Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = TwoSum(numbers1, target1);
            DisplayArray(result1);

            int[] numbers2 = { 2, 3, 4 };
            int target2 = 6;
            int[] result2 = TwoSum(numbers2, target2);
            DisplayArray(result2);

            int[] numbers3 = { -1, 0 };
            int target3 = -1;
            int[] result3 = TwoSum(numbers3, target3);
            DisplayArray(result3);

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] answer = new int[2];
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    answer[0] = left + 1;
                    answer[1] = right + 1;
                    break;
                }

                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }

                else
                {
                    right--;
                }
            }

            return answer;
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
