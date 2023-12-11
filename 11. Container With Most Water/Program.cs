using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    internal class Program
    {
        static void Main()
        {
            int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result1 = MaxArea(height1);
            Console.WriteLine("Max Area for height1: " + result1);

            int[] height2 = { 1, 1 };
            int result2 = MaxArea(height2);
            Console.WriteLine("Max Area for height2: " + result2);

            int[] height3 = { 4, 3, 2, 1, 4 };
            int result3 = MaxArea(height3);
            Console.WriteLine("Max Area for height3: " + result3);

            Console.ReadLine();
        }
        public static int MaxArea(int[] height)
        {

            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;
            int maxHeight = 0;

            while (left < right)
            {

                maxHeight = (height[left] < height[right]) ? height[left] : height[right];
                maxArea = (maxArea < (right - left) * maxHeight) ? (right - left) * maxHeight : maxArea;

                _ = (height[left] < height[right]) ? left++ : right--;
            }

            return maxArea;
        }
    }
}
