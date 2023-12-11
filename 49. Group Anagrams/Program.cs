using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49___Group_Anagrams
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] strs1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            List<List<string>> result1 = GroupAnagrams(strs1);
            DisplayResult(result1);

            string[] strs2 = { "" };
            List<List<string>> result2 = GroupAnagrams(strs2);
            DisplayResult(result2);

            string[] strs3 = { "a" };
            List<List<string>> result3 = GroupAnagrams(strs3);
            DisplayResult(result3);

            Console.ReadLine();
        }
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new string(charArray);

                if (!anagramGroups.ContainsKey(sortedStr))
                {
                    anagramGroups[sortedStr] = new List<string>();
                }

                anagramGroups[sortedStr].Add(str);
            }

            return anagramGroups.Values.ToList();
        }

        static void DisplayResult(List<List<string>> result)
        {
            foreach (List<string> group in result)
            {
                Console.Write("[");
                foreach (string str in group)
                {
                    Console.Write("\"" + str + "\", ");
                }
                Console.Write("], ");
            }
            Console.WriteLine();
        }
    }
}
