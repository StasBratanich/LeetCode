using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _981.Time_Based_Key_Value_Store
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TimeMap timeMap = new TimeMap();

            // Example function calls based on the input/output scenario
            timeMap.Set("foo", "bar", 1);
            Console.WriteLine(timeMap.Get("foo", 1)); // Expected output: "bar"
            Console.WriteLine(timeMap.Get("foo", 3)); // Expected output: "bar"
            timeMap.Set("foo", "bar2", 4);
            Console.WriteLine(timeMap.Get("foo", 4)); // Expected output: "bar2"
            Console.WriteLine(timeMap.Get("foo", 5)); // Expected output: "bar2"

            Console.ReadLine();
        }

        public class TimeMap
        {

            public TimeMap()
            {
                HashSet<string> timeLapsKeys = new HashSet<string>();
                IList<string> timeMapList = new List<string>();
            }

            public void Set(string key, string value, int timestamp)
            {
                
            }

            public string Get(string key, int timestamp)
            {

            }
        }

    }
}
