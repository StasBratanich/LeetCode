using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150___Evaluate_Reverse_Polish_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens1 = { "2", "1", "+", "3", "*" };
            int result1 = EvalRPN(tokens1);
            Console.WriteLine("Result 1: " + result1);

            string[] tokens2 = { "4", "13", "5", "/", "+" };
            int result2 = EvalRPN(tokens2);
            Console.WriteLine("Result 2: " + result2);

            string[] tokens3 = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            int result3 = EvalRPN(tokens3);
            Console.WriteLine("Result 3: " + result3);

            Console.ReadLine();
        }

        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if (IsOperator(token))
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    int result = PerformOperation(token, left, right);
                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }

        public static bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }
        public static int PerformOperation(string token, int num1, int num2)
        {
            switch (token)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
            }

            return 0;
        }
    }
}