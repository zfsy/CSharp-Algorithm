using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        /// <summary>
        /// 自顶向下，递归实现
        /// </summary>
        /// <returns></returns>
        public static List<T> SortTopDown<T>(List<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            if (collection.Count < 2)
            {
                return collection;
            }

            int midIndex = collection.Count / 2;

            var leftCollection = collection.GetRange(0, midIndex);
            var rightCollection = collection.GetRange(midIndex, collection.Count - midIndex);

            leftCollection = SortTopDown<T>(leftCollection, comparer);
            rightCollection = SortTopDown<T>(rightCollection, comparer);

            return Merge<T>(leftCollection, rightCollection, comparer);
        }

        /// <summary>
        /// 合并两个有序的数组
        /// </summary>
        private static List<T> Merge<T>(List<T> leftCollection, List<T> rightCollection, Comparer<T> comparer)
        {
            int left = 0;
            int right = 0;
            int index;
            int length = leftCollection.Count + rightCollection.Count;

            List<T> result = new List<T>(length);

            for (index = 0;  right < rightCollection.Count && left < leftCollection.Count; ++index)
            {
                if (comparer.Compare(rightCollection[right], leftCollection[left]) <= 0)
                {
                    result.Insert(index, rightCollection[right++]);
                }
                else
                {
                    result.Insert(index, leftCollection[left++]);
                }
            }

            // At most one of left and right might still have elements left

            while (right < rightCollection.Count)
            {
                result.Insert(index++, rightCollection[right++]);
            }

            while (left < leftCollection.Count)
            {
                result.Insert(index++, leftCollection[left++]);
            }

            return result;
        }

        /// <summary>
        /// 自底向上, 迭代实现
        /// </summary>
        /// <returns></returns>
        public static void SortBottomUp<T>(List<T> collection, Comparer<T> comparer=null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;
            List<T> temp = new List<T>(collection.Count);

            for (int size = 1; size < collection.Count; size = 2 * size)
            {
                for (int left = 0; left + size < collection.Count; left += 2 * size)
                {
                    MergeBU(collection, temp, left, left + size - 1, Math.Min(left + 2*size - 1, collection.Count - 1), comparer);
                }
            }
        }

        /// <summary>
        /// 每一次归并排序的临时结果存在哪里?对两个有序数组排序?
        /// </summary>
        private static void MergeBU<T>(List<T> collection, List<T> temp, int min, int mid, int max, Comparer<T> comparer)
        {
            int i = min;
            int j = mid + 1;

            for (int x = min; x <= max; x++)
            {
                temp.Insert(x, collection[x]);
            }

            for (int x = min; x <= max; x++)
            {
                if (i > mid)
                {
                    collection[x] = temp[j++];
                }
                else if (j > max)
                {
                    collection[x] = temp[i++];
                }
                else if (comparer.Compare(temp[i], temp[j]) > 0)
                {
                    collection[x] = temp[j++];
                }
                else
                {
                    collection[x] = temp[i++];
                }
            }
        }
    }
}
