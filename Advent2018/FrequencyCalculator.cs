namespace Advent2018 {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FrequencyCalculator : IFrequencyCalculator {
        private long Accumulator;
        public long Accumulate(List<long> input) {
            Accumulator += input.Sum();
            return Accumulator;
        }
    }
}