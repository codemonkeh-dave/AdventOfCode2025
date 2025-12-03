using AdventOfCode2025.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Tests
{
    public class Day3Tests
    {
        [Fact]
        public void GivenAListOfBanks_WhenGetBanksIsCalled_ShouldReturnBanksList()
        {
            var input = @"987654321111111
811111111111119
234234234234278
818181911112111";

            List<string> banks = BatteryHelper.GetBanks(input);
            Assert.Equal(4, banks.Count);
            Assert.Equal("987654321111111", banks[0]);
            Assert.Equal("811111111111119", banks[1]);
            Assert.Equal("234234234234278", banks[2]);
            Assert.Equal("818181911112111", banks[3]);
        }

        [Theory]
        [InlineData("987654321111111", 98)]
        [InlineData("811111111111119", 89)]
        [InlineData("234234234234278", 78)]
        [InlineData("818181911112111", 92)]

        public void GivenABank_WhenGetGetJoltageIsCalled_ShouldReturnCorrectJoltage(string bank, int expectedJoltage)
        { 
            int joltage = BatteryHelper.GetJoltage(bank);
            Assert.Equal(expectedJoltage, joltage);
        }
    }
}
