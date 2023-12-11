using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Valid_Anagram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first string :");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string :");
            string secondString = Console.ReadLine();

            Console.WriteLine(isAnagram(firstString, secondString));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        public static bool isAnagram(string i_firstString, string i_secondString)
        {
            if (i_firstString.Length != i_secondString.Length)
            {
                return false;
            }

            char[] firstStringArray = i_firstString.ToCharArray();
            char[] secondStringArray = i_secondString.ToCharArray();

            Array.Sort(firstStringArray);
            Array.Sort(secondStringArray);

            return firstStringArray.SequenceEqual(secondStringArray);
        }
    }
}
