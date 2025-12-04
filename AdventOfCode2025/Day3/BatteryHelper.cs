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
            bool lastNumberWasHighestNumber = false;
            if (bank == String.Empty)
                return 0;

            List<string> numberList = new List<string>();
            foreach (char c in bank)
            {
                numberList.Add(c.ToString());
            }
            List<string> numberListStored = GetSorted(numberList);

            var highestNumber = numberListStored.First();
            var highestNumberPosition = numberList.FindIndex(n => n == highestNumber);

            var numberListAfterFirstHighestPosition = numberList.GetRange(highestNumberPosition + 1, numberList.Count() - highestNumberPosition - 1);
            
            if (numberListAfterFirstHighestPosition.Count() == 0) // last number was highest
            {
                lastNumberWasHighestNumber = true;
                numberListAfterFirstHighestPosition = numberList.GetRange(0, numberList.Count() - 1);
            }

            var numberListAfterFirstHighestPositionSorted = GetSorted(numberListAfterFirstHighestPosition);

            var secondHighestNumberFollowingFirstHighestPosition = numberListAfterFirstHighestPositionSorted.First();
            var secondHighestNumberPosition = numberListAfterFirstHighestPosition.FindIndex(n => n == secondHighestNumberFollowingFirstHighestPosition);

            string combined = "";

            if (lastNumberWasHighestNumber)
            {
                combined = secondHighestNumberFollowingFirstHighestPosition + highestNumber;
            }
            else
            {
                combined = highestNumber + secondHighestNumberFollowingFirstHighestPosition;
            }

            return Convert.ToInt32(combined);
        }

        private static List<string> GetSorted(List<string> numberList)
        {
            var numberListStored = new List<string>();
            foreach (var s in numberList)
            {
                numberListStored.Add(s);
            }
            numberListStored.Sort();
            numberListStored.Reverse();
            return numberListStored;
        }
    }
}
