using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithms;
using System.Linq;
using Algorithms.Sort;

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

        [Fact]
        public void InsertSortTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            InsertionSort.Sort(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void InsertSortTest2()
        {
            var list = new List<char>() { 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            InsertionSort.Sort(list);
            char[] sortedList = { 'A', 'E', 'E', 'L', 'M', 'P', 'X' };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void InsertSortTest3()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            InsertionSort.SortStp(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void MergeSortTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            var sortList = MergeSort.SortTopDown(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(sortList.SequenceEqual(sortedList));
        }

        [Fact]
        public void MergeSortTest2()
        {
            var list = new List<char> { 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            var sortList = MergeSort.SortTopDown(list);
            char[] sortedList = { 'A', 'E', 'E', 'L', 'M', 'P', 'X' };
            Assert.True(sortList.SequenceEqual(sortedList));
        }

        [Fact]
        public void MergeSortTest3()
        {
            var list = new List<char> { 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            MergeSort.SortBottomUp(list);
            char[] sortedList = { 'A', 'E', 'E', 'L', 'M', 'P', 'X' };
            Assert.True(list.SequenceEqual(sortedList));
        }

        [Fact]
        public void QuickSortTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 29, 34, 17 };
            QuickSort.Sort(list);
            int[] sortedList = { 17, 29, 34, 45, 68, 89, 90 };
            Assert.True(list.SequenceEqual(sortedList));
        }
    }
}
