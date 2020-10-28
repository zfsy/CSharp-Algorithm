using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Partitioning
    {
        /// <summary>
        /// 采用Lomuto算法，用第一个元素作为中轴对子数组进行划分
        /// </summary>
        /// <returns></returns>
        public static int LomutoPartition<T>(List<T> collection, int l, int r, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            T p = collection[l];
            int s = l;          // s是划分的分割位置，也就是划分后中轴所在元素的索引
            for (int i = l+1; i <= r; i++)
            {
                if (comparer.Compare(collection[i], p) < 0)
                {
                    s++;
                    collection.Swap(i, s);          // 将比中轴小的元素前置
                }
            }
            collection.Swap(l, s);      // 把第一个元素放到中轴位置

            return s;
        }

        /// <summary>
        /// 采用Hoare算法，用第一个元素作为中轴对子数组进行划分
        /// </summary>
        /// <returns></returns>
        public static int HoarePartition<T>(List<T> collection, int l, int r, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            T p = collection[l];
            int i = l, j = r;
            collection.Add(default(T));     // ???加限位器

            do
            {
                do
                {
                    i++;
                } while (comparer.Compare(collection[i], p) < 0);

                do
                {
                    j--;
                } while (comparer.Compare(collection[j], p) > 0);

                collection.Swap(i, j);
            } while (i < j);

            collection.Swap(i, j);      // 撤销最后一次交换
            collection.Swap(l, j);

            collection.RemoveAt(collection.Count - 1);
            return j;
        }
    }
}
