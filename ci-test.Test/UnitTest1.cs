using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ci_test.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CoolFunctionalityToTest _functionality;

        public UnitTest1()
        {
            _functionality = new CoolFunctionalityToTest();
        }

        [TestMethod]
        public void TestSum()
        {
            var result = _functionality.Sum(3, 12);
            Assert.IsTrue(result == 15, "Result should be 15.");
        }

        [DataTestMethod]
        [DataRow( 22, 13,  35, DisplayName = "Positive numbers")]
        [DataRow(-17, -4, -21, DisplayName = "Negative numbers")]
        public void TestSum2(int a, int b, int correct)
        {
            var result = _functionality.Sum(a, b);
            Assert.IsTrue(result == correct, "Result should be " + correct + ".");
        }

        [DataTestMethod]
        [DataRow(184, false, DisplayName = "Positive numbers")]
        [DataRow(-19,  true, DisplayName = "Negative numbers")]
        [DataRow(  0, false, DisplayName = "Zero")]
        public void TestIsNegative(int a, bool negative)
        {
            var result = _functionality.IsNegative(a);
            Assert.IsTrue(result == negative, "Result should be " + negative + ".");
        }
    }
}
