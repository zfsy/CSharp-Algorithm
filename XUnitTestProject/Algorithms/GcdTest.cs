using Algorithms;
using Xunit;

namespace XUnitTestProject
{
    public class GcdTest
    {
        [Fact]
        public void EuclidTest()
        {
            int m = 60, n = 24;

            Assert.Equal(12, GcdAlgorithm.Euclid(m, n));
        }
    }
}
