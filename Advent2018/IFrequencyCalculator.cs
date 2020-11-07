namespace Advent2018 {
    using System.Collections.Generic;

    public interface IFrequencyCalculator {
        public long Accumulate(List<long> input);
    }
}