using System;

namespace Advent2018 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello future Santa! I'm trapped in the past trying to save you.");
            var frequencyCalculator = new FrequencyCalculator();
            Console.WriteLine(frequencyCalculator.Accumulate(new long[] {0}));
        }
    }
}