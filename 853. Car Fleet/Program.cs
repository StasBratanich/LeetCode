using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _853.Car_Fleet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int target1 = 12;
            int[] position1 = { 10, 8, 0, 5, 3 };
            int[] speed1 = { 2, 4, 1, 1, 3 };
            int fleets1 = CarFleet(target1, position1, speed1);
            Console.WriteLine($"For target = {target1}: Number of car fleets = {fleets1}");

            int target2 = 10;
            int[] position2 = { 3 };
            int[] speed2 = { 3 };
            int fleets2 = CarFleet(target2, position2, speed2);
            Console.WriteLine($"For target = {target2}: Number of car fleets = {fleets2}");

            int target3 = 100;
            int[] position3 = { 0, 2, 4 };
            int[] speed3 = { 4, 2, 1 };
            int fleets3 = CarFleet(target3, position3, speed3);
            Console.WriteLine($"For target = {target3}: Number of car fleets = {fleets3}");

            int target4 = 10;
            int[] position4 = { 6, 8 };
            int[] speed4 = { 3, 2 };
            int fleets4 = CarFleet(target4, position4, speed4);
            Console.WriteLine($"For target = {target4}: Number of car fleets = {fleets4}");

            int target5 = 10;
            int[] position5 = { 8, 3, 7, 4, 6, 5 };
            int[] speed5 = { 4, 4, 4, 4, 4, 4 };
            int fleets5 = CarFleet(target5, position5, speed5);
            Console.WriteLine($"For target = {target5}: Number of car fleets = {fleets5}");

            Console.ReadLine();
        }
        public static int CarFleet(int target, int[] position, int[] speed)
        {
            Stack<double> carFleetStack = new Stack<double>();
            carFleetStack.Push(0);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < position.Length; i++)
            {
                dict.Add(position[i], speed[i]);
            }

            var sortedDict = dict.OrderByDescending(x => x.Key);
            
            foreach (KeyValuePair<int, int> kvp in sortedDict) 
            {
                double divisionResult = (double)(target - kvp.Key) / kvp.Value;

                if (divisionResult > carFleetStack.Peek())
                {
                    carFleetStack.Push(divisionResult);
                }
            }

            return carFleetStack.Count() - 1;
        }
    }
}
