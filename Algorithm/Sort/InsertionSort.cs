using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
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
    }
}
