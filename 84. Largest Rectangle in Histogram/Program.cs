using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84.Largest_Rectangle_in_Histogram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] heights1 = { 2, 1, 5, 6, 2, 3 };
            int asnwer1 = LargestRectangleArea(heights1);
            Console.WriteLine("The largest histogram is : {0}", asnwer1.ToString());

            int[] heights2 = { 2, 4 };
            int asnwer2 = LargestRectangleArea(heights2);
            Console.WriteLine("The largest histogram is : {0}", asnwer2.ToString());

            Console.ReadLine();
        }

        public static int LargestRectangleArea(int[] heights)
        {
            int index = 0;
            int maxArea = 0;
            Stack<(int index, int height)> stack = new Stack<(int, int)>();
            (int index, int height) top;

            stack.Push((0, heights[0]));

            for (int i = 1; i < heights.Length; i++)
            {
                index = i;
                while(stack.Count() > 0 && stack.Peek().height > heights[i])
                {
                    top = stack.Pop();
                    maxArea = Math.Max(maxArea, (top.height * (i - top.index)));
                    index = top.index;
                }

                stack.Push((index, heights[i]));
            }

            while (stack.Count() > 0)
            {
                top = stack.Pop();
                maxArea = Math.Max(maxArea, top.height * (heights.Length - top.index));
            }

            return maxArea;
        }
    }
}
