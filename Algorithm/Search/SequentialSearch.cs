using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SequentialSearch
    {
        public static int Search<T>(IList<T> collection, T key, Comparer<T> comparer = null)
        {
            int ret = -1;
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            if (key == null)
            {
                throw new ArgumentNullException("the param \"key\" can't be null");
            }
            collection.Add(key);    // 用查找键来做限位器

            int i = 0;
            while (comparer.Compare(collection[i], key) != 0)
            {
                i++;
            }

            if (i < collection.Count - 1)
            {
                ret = i;
            }

            return ret;
        }

        // 如果已知给定数组有序，只要遇到一个大于或等于查找键的元素，查找就可以停止了
    }
}
