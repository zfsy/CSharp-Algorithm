using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Algorithms;

namespace XUnitTestProject.Algorithms
{
    public class SelecTest
    {
        [Fact]
        public void LomutoPartitionTest()
        {
            // 1 2 4 10 8 7 12 9 15 
            List<int> partitionList = new List<int>() { 4, 1, 10, 8, 7, 12, 9, 2, 15 };
            int pivotIndex = 2;
            int pivotIndexEx = Partitioning.LomutoPartition(partitionList, 0, partitionList.Count - 1);

            Assert.Equal(pivotIndex, pivotIndexEx);
        }

        [Fact]
        public void HoarePartitionTest()
        {
            // 1 2 4 10 8 7 12 9 15 
            List<int> partitionList = new List<int>() { 4, 1, 10, 8, 7, 12, 9, 2, 15 };
            int pivotIndex = 2;
            int pivotIndexEx = Partitioning.HoarePartition(partitionList, 0, partitionList.Count - 1);

            Assert.Equal(pivotIndex, pivotIndexEx);
        }
    }
}
