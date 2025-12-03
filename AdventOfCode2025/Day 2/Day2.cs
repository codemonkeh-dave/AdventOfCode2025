using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Day_2
{
    public static class Day2
    {
        public static void Run()
        {
            Console.WriteLine("Running Day 2");

            var ranges = NumberRangeHelper.GetNumberRangesFromString("132454-182049,42382932-42449104,685933-804865,5330496-5488118,21-41,289741-376488,220191-245907,49-70,6438484-6636872,2-20,6666660113-6666682086,173-267,59559721-59667224,307-390,2672163-2807721,658272-674230,485679-647207,429-552,72678302-72815786,881990-991937,73-111,416063-479542,596-934,32825-52204,97951700-98000873,18335-27985,70203-100692,8470-11844,3687495840-3687599608,4861-8174,67476003-67593626,2492-4717,1442-2129,102962-121710,628612213-628649371,1064602-1138912\r\n");
            long invalidSum = 0;
            foreach (var range in ranges)
            {
                for (var i = range.Min; i <= range.Max; i++)
                {
                    var invalid = PatternHelper.GetPatternNumber(i);
                    if (invalid != null)
                        invalidSum += invalid.Value;
                }
            }
            Console.WriteLine($"Invalid sum = {invalidSum}");
            Console.ReadLine();
        }
    }
}
