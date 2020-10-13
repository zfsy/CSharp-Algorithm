using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithms;
using System.Linq;

namespace XUnitTestProject.Algorithms
{
    public class SortTest
    {
        [Fact]
        public void SelectSortTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            list.SortAscending();
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90};
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void SelectSortDescTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            list.SortDescending();
            int[] sortedList = { 90, 89, 68, 45, 34, 29, 17 };
            Assert.True(list.SequenceEqual(sortedList));
        }
    }
}
