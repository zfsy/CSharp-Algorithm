using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms.Sort
{
    public class QuickSort
    {
        public static void Sort<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            int startIndex = 0;
            int endIndex = collection.Count - 1;

            InternalQuickSort(collection, startIndex, endIndex, comparer);
        }

        private static void InternalQuickSort<T>(IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            if (leftmostIndex < rightmostIndex)
            {
                int wallIndex = InternalPartition(collection, leftmostIndex, rightmostIndex, comparer);
                InternalQuickSort(collection, leftmostIndex, wallIndex - 1, comparer);
                InternalQuickSort(collection, wallIndex + 1, rightmostIndex, comparer);
            }
        }



        /// <summary>
        /// 采用Lomuto算法进行数组划分
        /// </summary>
        /// <returns></returns>
        private static int InternalPartition<T>(IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            int wallIndex, pivotIndex;

            pivotIndex = rightmostIndex;
            T pivotValue = collection[pivotIndex];

            wallIndex = leftmostIndex;

            for (int i = leftmostIndex; i <= (rightmostIndex - 1); i++)
            {
                if (comparer.Compare(collection[i], pivotValue) <= 0)
                {
                    collection.Swap(i, wallIndex);
                    wallIndex++;
                }
            }

            collection.Swap(wallIndex, pivotIndex);

            return wallIndex;
        }
    }
}
