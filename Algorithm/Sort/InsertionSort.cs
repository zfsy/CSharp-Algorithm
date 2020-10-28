using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Algorithms.Sort
{
    /*
     需要插入的元素个数: 从1到n-1
     每次插入: 将插入元素v和前一个元素比较，若大于，插入完成；若小于，前一个元素后移，插入元素继续向前一个元素比较，直到没有元素或找到比它小的元素为止，最多比较i次

    限位器实现: 避免了j>=0的比较，将数组的0号元素空出，每次将要插入的元素复制到0号元素。牺牲
        一个空间换取时间上的效率。

        程序上的实现，不需要像思维上操作的要一个可变数组，直接利用一个临时变量。
        已排序的序列中比要插入的变量大的后移一位，直到碰到比要插入的变量要小的，插入
        位置定在该变量后面即可。
         */
    public class InsertionSort
    {
        public static void Sort<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            int j;
            T v;
            for (int i = 1; i < collection.Count; i++)
            {
                v = collection[i];
                j = i - 1;
                while (j >= 0 && comparer.Compare(collection[j], v) > 0)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }
                collection[j + 1] = v;
            }
        }

        /// <summary>
        /// 加入了限位器的版本
        /// </summary>
        public static void SortStp<T>(IList<T> collection, Comparer<T> comparer = null)
        { 
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            collection.Insert(0, default(T));
            int j;
            for (int i = 1; i < collection.Count; i++)
            {
                collection[0] = collection[i];
                j = i - 1;
                while (comparer.Compare(collection[j], collection[0]) > 0)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }

                collection[j + 1] = collection[0];
            }

            collection.RemoveAt(0);
        }
    }
}
