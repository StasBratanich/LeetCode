using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _74.Search_a_2D_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][] {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
            int target1 = 3;

            int[][] matrix2 = new int[][] {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
            int target2 = 13;

            int[][] matrix3 = new int[][] {
            new int[] { 1 }
        };
            int target3 = 1;

            Console.WriteLine(SearchMatrix(matrix1, target1)); // Output: true
            Console.WriteLine(SearchMatrix(matrix2, target2)); // Output: false
            Console.WriteLine(SearchMatrix(matrix3, target3)); // Output: true

            Console.ReadLine();
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {

            for(int row = 0; row < matrix.Length - 1; row++)
            {
                int i = Array.BinarySearch(matrix[row], target);

                if(i > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
