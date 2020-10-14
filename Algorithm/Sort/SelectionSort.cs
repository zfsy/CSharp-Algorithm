using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms
{
    public static class SelectionSort
    {
        public static void SortAscending<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default; 

            int min;
            for (int i = 0; i < collection.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[min]) < 0)
                    {
                        min = j;
                    }
                }
              
                collection.Swap(i, min);
            }
        }

        public static void SortDescending<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer != null ? comparer : Comparer<T>.Default;

            int max;
            for (int i = 0; i < collection.Count - 1; i++)
            {
                max = i;
                for (int j = i+1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[max]) > 0)
                    {
                        max = j;
                    }
                }

                collection.Swap(i, max);
            }
        }


    }
}
