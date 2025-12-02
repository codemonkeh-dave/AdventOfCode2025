using AdventOfCode2025.Day_2;

namespace AdventOfCode2025.Tests
{
    public class Day2Tests
    {
        [Theory]
        [InlineData(11, 11)]
        [InlineData(22, 22)]
        [InlineData(1010, 1010)]
        [InlineData(1188511885, 1188511885)]
        [InlineData(12, null)]
        public void GivenANumber_WhenGetPatternIsCalled_ReturnPattern(int input, int? expectedOutput)
        {
            var output = PatternHelper.GetPatternNumber(input);

            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData("1-10", 0, 1, 10)]
        [InlineData("5-500", 0, 5, 500)]
        [InlineData("333-555,1-2", 0, 333, 555)]
        [InlineData("333-555,1-2", 1, 1, 2)]
        public void GivenAStringCollectionOfRanges_WhenGetManyRangesFromStringIsCalled_ReturnsExpectedRanges(
            string inputRange, int elementIndex, int expectedMin, int expectedMax)
        {
            var output = NumberRangeHelper.GetNumberRangesFromString(inputRange);

            var element = output.Skip(elementIndex).First();
            Assert.NotNull(element);
            Assert.Equal(expectedMin, element.Min);
            Assert.Equal(expectedMax, element.Max);
        }
    }
}