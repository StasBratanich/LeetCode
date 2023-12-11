using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    internal class Program
    {
        static void Main()
        {
            string s1 = "()";
            bool result1 = IsValid(s1);
            Console.WriteLine("Is valid for s1: " + result1);

            string s2 = "()[]{}";
            bool result2 = IsValid(s2);
            Console.WriteLine("Is valid for s2: " + result2);

            string s3 = "(]";
            bool result3 = IsValid(s3);
            Console.WriteLine("Is valid for s3: " + result3);

            Console.ReadLine();
        }
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            {'(' , ')'},
            {'{' , '}'},
            {'[' , ']'}
        };

            foreach (char c in s)
            {
                if (dict.Keys.Contains(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0 && c == dict[stack.Peek()])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count() == 0;
        }
    }
}
