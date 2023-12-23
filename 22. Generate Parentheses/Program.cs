using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Generate_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            IList<string> result1 = GenerateParenthesis(n1);
            Console.WriteLine($"For n = {n1}:");
            foreach (var str in result1)
            {
                Console.WriteLine(str);
            }

            int n2 = 1;
            IList<string> result2 = GenerateParenthesis(n2);
            Console.WriteLine($"\nFor n = {n2}:");
            foreach (var str in result2)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();

            GenerateParenthesisRecursion(result, "(", 1, 0, n);

            return result;
        }
        public static void GenerateParenthesisRecursion(IList<string> result, string current, int open, int closed, int n) 
        {
            if(current.Length == 2 * n)
            {
                result.Add(current);
                return;
            }

            if(open < n)
            {
                GenerateParenthesisRecursion(result, current + "(", open + 1, closed, n);
            }

            if (closed < open)
            {
                GenerateParenthesisRecursion(result, current + ")", open, closed + 1, n);
            }
        }
    }
}
