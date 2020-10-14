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
            SelectionSort.SortAscending(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void SelectSortDescTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            SelectionSort.SortDescending(list);
            int[] sortedList = { 90, 89, 68, 45, 34, 29, 17 };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void BubbleSortTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            BubbleSort.SortAscending(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void BubbleSortDescTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            BubbleSort.SortDescending(list);
            int[] sortedList = { 90, 89, 68, 45, 34, 29, 17 };
            Assert.True(list.SequenceEqual(sortedList));
        }
    }
}
