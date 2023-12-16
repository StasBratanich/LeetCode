using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _42.Trapping_Rain_Water
{
    internal class Program
    {
        static void Main()
        {
            int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int result1 = Trap(height1);
            Console.WriteLine("Trapped water for height1: " + result1);

            int[] height2 = { 4, 2, 0, 3, 2, 5 };
            int result2 = Trap(height2);
            Console.WriteLine("Trapped water for height2: " + result2);

            Console.ReadLine();
        }

        public static int Trap(int[] height)
        {
            int sum = 0;

            int[] leftMaxArr = new int[height.Length];
            int leftMax = height[0];
            leftMaxArr[0] = leftMax;

            for(int left = 1; left < height.Length; left++)
            {
                if (height[left] > leftMax)
                {
                    leftMax = height[left];
                }

                leftMaxArr[left] = leftMax;
            }

            int[] rightMaxArr = new int[height.Length];
            int rightMax = height[height.Length - 1];
            rightMaxArr[height.Length - 1] = rightMax;

            for(int right = height.Length - 2; right >= 0; right--)
            {
                if (height[right] > rightMax)
                {
                    rightMax = height[right];
                }

                rightMaxArr[right] = rightMax;
            }

            for (int i = 0; i < height.Length; i++)
            {
                int addVal = Math.Min(leftMaxArr[i], rightMaxArr[i]) - height[i];

                if(addVal < 0)
                {
                    continue;
                }
                else
                {
                    sum += addVal;
                }
            }

            return sum;
        }
    }
}
