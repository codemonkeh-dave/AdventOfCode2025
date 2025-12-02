namespace AdventOfCode2025.Day_2
{
    public static class PatternHelper
    {

        public static long? GetPatternNumber(long number)
        {
            string numberAsString = number.ToString();
            var length = numberAsString.Length;

            if (EvenLength(number))
            {
                var leftHalf = numberAsString.Substring(0, length/2);
                var rightHalf = numberAsString.Substring(length / 2, length / 2);
                if (leftHalf == rightHalf)
                {
                    return number;
                }
            }
            return null;
        }

        private static bool EvenLength(long number)
        {
            return number.ToString().Length % 2 == 0;
        }
    }
}