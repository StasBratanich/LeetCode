using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arraySize = int.Parse(Console.ReadLine());
            int[] nums = new int[arraySize];

            Console.WriteLine("Enter numbers to array :");

            for (int i = 0; i < arraySize; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the target number :");
            int target = int.Parse(Console.ReadLine());

            int[] solution = TwoSum(nums, target);

            Console.WriteLine("The solution is :");

            foreach (int i in solution)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("enter a key to exit");
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashTable.ContainsKey(complement))
                    return new int[] { hashTable[complement], i };
                else
                    hashTable[nums[i]] = i;
            }

            return new int[] {-1, -1};
        }
    }
}
