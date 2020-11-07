using System;

namespace Advent2018 {
    using System.IO;
    using System.Linq;

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello future Santa! I'm trapped in the past trying to save you.");
            var frequencyCalculator = new FrequencyCalculator();

            Console.WriteLine(frequencyCalculator.Accumulate(Day1InputReader()));
        }

        private static long[] Day1InputReader() {
            var data = new long[]{};
            using (TextReader reader = File.OpenText("inputs/1.txt")){
                string? entry;
                while (null != (entry = reader.ReadLine()))
                {
                    data.Append(long.Parse(entry));
                }
            }

            return data;
        }
    }
}