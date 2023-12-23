using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _875.Koko_Eating_Bananas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Best algorithm :");
            Console.WriteLine("----------------");

            int[] piles1 = { 3, 6, 7, 11 };
            int h1 = 8;
            int result1 = MinEatingSpeed(piles1, h1);
            Console.WriteLine($"For piles = [{string.Join(",", piles1)}], h = {h1}: Result = {result1}");

            int[] piles2 = { 30, 11, 23, 4, 20 };
            int h2 = 5;
            int result2 = MinEatingSpeed(piles2, h2);
            Console.WriteLine($"For piles = [{string.Join(",", piles2)}], h = {h2}: Result = {result2}");

            int[] piles3 = { 30, 11, 23, 4, 20 };
            int h3 = 6;
            int result3 = MinEatingSpeed(piles3, h3);
            Console.WriteLine($"For piles = [{string.Join(",", piles3)}], h = {h3}: Result = {result3}");

            int[] piles4 = { 312884470 };
            int h4 = 312884469;
            int result4 = MinEatingSpeed(piles4, h4);
            Console.WriteLine($"For piles = [{string.Join(",", piles4)}], h = {h4}: Result = {result4}");

            int[] piles5 = { 1, 1, 1, 999999999 };
            int h5 = 10;
            int result5 = MinEatingSpeed(piles5, h5);
            Console.WriteLine($"For piles = [{string.Join(",", piles5)}], h = {h5}: Result = {result5}");

            //Console.WriteLine();

            //Console.WriteLine("Brute force algorithm :");
            //Console.WriteLine("-----------------------");

            //int[] piles6 = { 3, 6, 7, 11 };
            //int h6 = 8;
            //int result6 = BruteForceMinEatingSpeed(piles6, h6);
            //Console.WriteLine($"For piles = [{string.Join(",", piles6)}], h = {h6}: Result = {result6}");

            //int[] piles7 = { 30, 11, 23, 4, 20 };
            //int h7 = 5;
            //int result7 = BruteForceMinEatingSpeed(piles7, h7);
            //Console.WriteLine($"For piles = [{string.Join(",", piles7)}], h = {h7}: Result = {result7}");

            //int[] piles8 = { 30, 11, 23, 4, 20 };
            //int h8 = 6;
            //int result8 = BruteForceMinEatingSpeed(piles8, h8);
            //Console.WriteLine($"For piles = [{string.Join(",", piles8)}], h = {h8}: Result = {result8}");

            //int[] piles9 = { 312884470 };
            //int h9 = 312884469;
            //int result9 = BruteForceMinEatingSpeed(piles9, h9);
            //Console.WriteLine($"For piles = [{string.Join(",", piles9)}], h = {h9}: Result = {result9}");

            //int[] piles10 = { 1, 1, 1, 999999999 };
            //int h10 = 10;
            //int result10 = BruteForceMinEatingSpeed(piles10, h10);
            //Console.WriteLine($"For piles = [{string.Join(",", piles10)}], h = {h10}: Result = {result10}");

            Console.WriteLine();
            Console.WriteLine("End");
            Console.ReadLine();
        }

        public static int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();
            int result = 0;

            while (left <= right)
            {
                int k = left + (right - left) / 2;
                int sumHours = 0;

                foreach (int pile in piles)
                {
                    sumHours += (pile + k - 1) / k;

                    if (sumHours > h)
                    {
                        left = k + 1;
                        break;
                    }
                }

                if (sumHours <= h)
                {
                    result = k;
                    right = k - 1;
                }
            }

            return result;
        }

        public static int BruteForceMinEatingSpeed(int[] piles, int h)
        {
            int right = piles.Max();
            int left = 1;
            int k = right;

            for (k = left; k < right; k++)
            {
                int index = 0;
                int sumHours = 0;

                while (index < piles.Length)
                {
                    sumHours += (int)Math.Ceiling((double)piles[index] / k);

                    if (sumHours >= h && index < piles.Length - 1)
                    {
                        break;
                    }

                    if(sumHours <= h && index >= piles.Length - 1)
                    {
                        return k;
                    }

                    index++;
                }
            }

            return k;
        }

    }
}
