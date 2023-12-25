using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            private readonly Dictionary<string, IList<(int time, string value)>> timeLapsDict = new Dictionary<string, IList<(int time, string value)>>();

            public void Set(string key, string value, int timestamp)
            {
                if (!timeLapsDict.ContainsKey(key))
                {
                    timeLapsDict[key] = new List<(int time, string value)>();
                }

                timeLapsDict[key].Add((timestamp, value));
            }

            public string Get(string key, int timestamp)
            {
                if(!timeLapsDict.ContainsKey(key))
                { 
                    return string.Empty;
                }
                
                var list = timeLapsDict[key];
                int left = 0;
                int right = list.Count - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (list[mid].time == timestamp)
                    {
                        return list[mid].value;
                    }
                    else if (list[mid].time > timestamp)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                return left == 0 ? string.Empty : list[left - 1].value;

            }
        }
    }
}
