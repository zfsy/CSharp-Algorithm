using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms
{
    /*
     冒泡的次数i: 和数组的个数n有关，从0到n-1
     每一次冒泡和相邻元素比较的次数j: n - 2 - i
        */
    public class BubbleSort
    {
        public static void SortAscending<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - 1 - i; j++)
                {
                    if (comparer.Compare(collection[j], collection[j+1]) > 0)
                    {
                        collection.Swap(j, j+1);
                    }
                }
            }
        
        }

        public static void SortDescending<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - 1 - i; j++)
                {
                    if (comparer.Compare(collection[j], collection[j+1]) < 0)
                    {
                        collection.Swap(j, j+1);
                    }
                }
            } 
        }
    }
}
