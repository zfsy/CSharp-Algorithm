using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Extension
    {
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
