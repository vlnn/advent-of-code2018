namespace Advent2018 {
    using System.Linq;

    public class FrequencyCalculator : IFrequencyCalculator {
        private long Accumulator = 0;
        public long Accumulate(long[] input) {
            return Accumulator + input.Sum();
        }
    }
}