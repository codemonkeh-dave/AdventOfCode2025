using System;

namespace AdventOfCode2025.Day_2
{
    public static class PatternHelper
    {

        public static long? GetPatternNumber(long number)
        {
            string numberAsString = number.ToString();
            var lengthOfNumber = numberAsString.Length;

            

            for (int numberOfPartsToSplintNumberInto=lengthOfNumber; 
                     numberOfPartsToSplintNumberInto>=2;numberOfPartsToSplintNumberInto--)
            {
                if (lengthOfNumber % numberOfPartsToSplintNumberInto == 0)
                {
                    int sizeOfPart = lengthOfNumber / numberOfPartsToSplintNumberInto;
                    List<string> parts = new List<string>();

                    for (int currentStartIndex = 0; currentStartIndex <= lengthOfNumber - sizeOfPart; currentStartIndex+= sizeOfPart)
                    {
                        parts.Add(numberAsString.Substring(currentStartIndex, sizeOfPart));
                    }

                    var firstPart = parts.First();
                    if (parts.All(p => p == firstPart))
                    {
                        return number;
                    }
                }
            }

            return null;

            //if (EvenLength(number))
            //{
            //    var leftHalf = numberAsString.Substring(0, lengthOfNumber/2);
            //    var rightHalf = numberAsString.Substring(lengthOfNumber / 2, lengthOfNumber / 2);
            //    if (leftHalf == rightHalf)
            //    {
            //        return number;
            //    }
            //}
            //return null;
        }

        private static bool EvenLength(long number)
        {
            return number.ToString().Length % 2 == 0;
        }
    }
}