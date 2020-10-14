using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Algorithms
{
    public class StringMatchTest
    {
        [Fact]
        public void BruteForceStringMatchTest()
        {
            string text = "The first computers were used primarily for numerical calculations";
            string pattern = "primarily";
            Assert.Equal(30, BruteForceStringMatch.Match(text, pattern));
        }

        [Fact]
        public void BruteForceStringMatchTest2()
        {
            string text = "primarila primarilb primarilc primarild primarile primarilf primarilag primarilh primarilj";
            string pattern = "primarily";
            Assert.Equal(-1, BruteForceStringMatch.Match(text, pattern));
        }
    }
}
