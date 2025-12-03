using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Day2
{
    public static class BatteryHelper
    {
        public static List<String> GetBanks(string input)
        {
            return input.Split(Environment.NewLine).ToList();
        }

        public static int GetJoltage(string bank)
        {
            if (bank == String.Empty)
                return 0;

            List<string> numbers = new List<string>();
            foreach (char c in bank)
            {
                numbers.Add(c.ToString());
            }

            var numbersSorted = new List<string>();
            foreach (var s in numbers)
            {
                numbersSorted.Add(s);
            }
            numbersSorted.Sort();
            numbersSorted.Reverse();

            var highestNumber = numbersSorted.First();
            var highestNumberPosition = numbers.FindIndex(n => n == highestNumber);

            numbers.RemoveRange(0, highestNumberPosition + 1);
            var secondNumbersSorted = new List<string>();
            foreach (var s in numbers)
            {
                secondNumbersSorted.Add(s);
            }
            secondNumbersSorted.Sort();
            secondNumbersSorted.Reverse();

            var secondHighestNumber = secondNumbersSorted.First();
            var secondHighestNumberPosition = numbers.FindIndex(n => n == secondHighestNumber);

            string combined = "";
            combined = highestNumber + secondHighestNumber;

            return Convert.ToInt32(combined);
        }
    }
}
