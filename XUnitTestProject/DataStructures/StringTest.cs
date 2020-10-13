using System;
using Xunit;

namespace XUnitTestProject
{
    public class StringTest
    {
        [Fact]
        public void Test1()
        {
            char[] charArray = new char[] { 'h', 'e', 'l', 'l', 'o', 'w', 'o', 'r', 'l', 'd'};

            DataSturctures.String obj = new DataSturctures.String(charArray);
            Assert.Equal(10, obj.Length);
        }
    }
}
