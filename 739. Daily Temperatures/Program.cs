using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _739.Daily_Temperatures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] temperatures1 = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] temperatures2 = { 30, 40, 50, 60 };
            int[] temperatures3 = { 30, 60, 90 };

            Console.WriteLine("Example 1:");
            PrintArray(DailyTemperatures(temperatures1));

            Console.WriteLine("Example 2:");
            PrintArray(DailyTemperatures(temperatures2));

            Console.WriteLine("Example 3:");
            PrintArray(DailyTemperatures(temperatures3));

            Console.ReadLine();
        }
        public static int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int[] answerArr = new int[temperatures.Length];

            

            return answerArr;
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
