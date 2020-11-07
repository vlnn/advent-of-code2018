using System;

namespace Advent2018 {
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello future Santa! I'm trapped in the past trying to save you.");
            var frequencyCalculator = new FrequencyCalculator();
            var day1Answer = frequencyCalculator.Accumulate(Day1InputReader());
            Console.WriteLine($"Answer for first star is: {day1Answer}.");
        }

        private static List<long> Day1InputReader() {
            using TextReader reader = File.OpenText("inputs/1.txt");
            string? entry;
            var data = new List<long>();
            while ((entry = reader.ReadLine()) != null)
            {
                data.Add(long.Parse(entry));
            }
            return data;
        }
    }
}