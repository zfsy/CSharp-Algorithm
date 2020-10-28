using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        /// <summary>
        /// 迭代实现
        /// </summary>
        /// <returns></returns>
        public static int Search<T>(IList<T> collection, T key, Comparer<T> comparer = null)
        {
            int ret = -1;
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            if (key == null)
            {
                throw new ArgumentNullException("the param \"key\" can't be null");
            }

            int left = 0, middle, cmp;
            int right = collection.Count - 1;
            while (left <= right)
            {
                middle = (left + right) / 2;
                cmp = comparer.Compare(key, collection[middle]);
                if (cmp == 0)
                {
                    ret = middle;
                    break;
                }
                else if (cmp < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return ret;
        }
    }
}
