using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155.Min_Stack
{
    internal class Program
    {
        static void Main()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            int min1 = minStack.GetMin(); // return -3
            minStack.Pop();
            int top = minStack.Top();    // return 0
            int min2 = minStack.GetMin(); // return -2

            Console.WriteLine($"Min1: {min1}, Top: {top}, Min2: {min2}");

            Console.ReadLine();
        }

        public class MinStack
        {
            private Stack<int> stack;
            private Stack<int> minStack;
            private int minValue;

            public MinStack()
            {
                stack = new Stack<int>();
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                if (stack.Count == 0)
                {
                    minValue = val;
                }

                stack.Push(val);

                minValue = Math.Min(minValue, val);
                minStack.Push(minValue);
            }

            public void Pop()
            {
                stack.Pop();
                minStack.Pop();
                if (minStack.Count > 0)
                {
                    minValue = minStack.Peek();
                }
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return minValue;
            }
        }
    }
}
