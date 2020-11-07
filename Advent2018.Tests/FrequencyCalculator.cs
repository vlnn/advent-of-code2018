using NUnit.Framework;

namespace Advent2018.Tests {
    using System.Collections.Generic;

    public class Tests {
        
        [Test]
        public void FrequencyCalculator_JustInitiated_ReturnsZero() {
            var TestCalc = new FrequencyCalculator();
            var result = TestCalc.Accumulate(new List<long> {0});
            Assert.AreEqual(0,result);
        }
        
        [Test]
        public void FrequencyCalculator_AddZero_NoChanges() {
            var TestCalc = new FrequencyCalculator();
            var preResult = TestCalc.Accumulate(new List<long> {0});
            var postResult = TestCalc.Accumulate(new List<long> {0,0,0});
            Assert.IsTrue(preResult == postResult);
        }
        
        [Test]
        public void FrequencyCalculator_PositiveArgs_ReturnsSum() {
            var TestCalc = new FrequencyCalculator();
            var result = TestCalc.Accumulate(new List<long> {1,2,3});
            Assert.AreEqual(6,result);
        }
        
        [Test]
        public void FrequencyCalculator_ArgsWithNegatives_ReturnsSum() {
            var TestCalc = new FrequencyCalculator();
            var result = TestCalc.Accumulate(new List<long> {1,2,-3});
            Assert.AreEqual(0,result);
        }
    }
}