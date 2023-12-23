using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _74.Search_a_2D_Matrix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[][] matrix1 = {
                new int[] {1, 3, 5, 7},
                new int[] {10, 11, 16, 20},
                new int[] {23, 30, 34, 60}
            };
            int target1 = 3;
            bool result1 = SearchMatrix(matrix1, target1);
            Console.WriteLine($"For target = {target1}: Result = {result1}");

            };
            int target2 = 13;
            bool result2 = SearchMatrix(matrix2, target2);
            Console.WriteLine($"For target = {target2}: Result = {result2}");

        };


            Console.ReadLine();
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rowLength = matrix.Length;
            int columnLength = matrix[0].Length;
            int k = 0;

            int[] Matrix1D = new int[rowLength * columnLength];

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Matrix1D[k] = matrix[i][j];
                    k++;
                }
            }

            int answer = Array.BinarySearch(Matrix1D, target);

            if(answer < 0) 
            {
                return false;
            }

            return true; 
        }

                {

                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
