namespace AdventOfCode2025.Day_2
{
    public static class NumberRangeHelper
    {
        public static List<NumberRange> GetNumberRangesFromString(string ranges)
        {
            var numberRanges = new List<NumberRange>();
            
            // example range "1-10,2-50" should return 1 min and 10 max
            var splitRanges = ranges.Split(",");
            foreach (var range in splitRanges)
            {
                var numbersInRange = range.Split("-");

                if (numbersInRange.Length == 2)
                {
                    numberRanges.Add(new NumberRange()
                    {
                        Min = Convert.ToInt64(numbersInRange[0]),
                        Max = Convert.ToInt64(numbersInRange[1])
                    });
                }
            }
            return numberRanges;
        }
    }
}
