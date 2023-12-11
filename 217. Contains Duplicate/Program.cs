using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array length : ");

            int size = int.Parse(Console.ReadLine());

            int[] intArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(ContainsDuplicate(intArray, size));

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

            

        }

        public static bool ContainsDuplicate(int[] nums, int numsSize)
        {
            return new HashSet<int>(nums).Count < nums.Length; 
        }


    }
}
