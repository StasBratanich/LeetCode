using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4___Valid_Palindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string stringInput = Console.ReadLine();

            Console.WriteLine(isPalindrome(stringInput));

        }

        public static bool isPalindrome(string s)
        {
            var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
            return clean.Reverse().SequenceEqual(clean);
        }
    }
}
