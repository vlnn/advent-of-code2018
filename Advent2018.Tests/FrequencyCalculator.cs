using NUnit.Framework;

namespace Advent2018.Tests {
    public class Tests {
        [Test]
        public void FrequencyCalculator_AddZero_NoChanges() {
            var TestCalc = new FrequencyCalculator();
            var preResult = TestCalc.Accumulate(new long[] {0});
            var postResult = TestCalc.Accumulate(new long[] {0,0,0});
            Assert.IsTrue(preResult == postResult);
        }
    }
}