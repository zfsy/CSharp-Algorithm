using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithms;
using Algorithms.Search;

namespace XUnitTestProject.Algorithms
{
    public class Search
    {
        [Fact]
        public void SequenSearchTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 100, 29, 34, 17, 55 };
            
            Assert.Equal(4, SequentialSearch.Search(list, 100));
        }

        [Fact]
        public void SequenSearchTest2()
        {
            var list = new List<int>() { 89, 45, 68, 90, 100, 29, 34, 17, 55 };

            Assert.Equal(-1, SequentialSearch.Search(list, 99));
        }

        [Fact]
        public void BinarySearchTest()
        {
            var list = new List<int>() { 89, 45, 68, 90, 100, 29, 34, 17, 55 };

            Assert.Equal(-1, BinarySearch.Search(list, 99));
        }

        [Fact]
        public void BinarySearchTest2()
        {
            var list = new List<int>() { 89, 45, 68, 90, 100, 29, 34, 17, 55 };

            Assert.Equal(4, BinarySearch.Search(list, 100));
        }
    }
}
