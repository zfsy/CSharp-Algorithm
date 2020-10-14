using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class GcdAlgorithm
    {
        public static int Euclid(int m, int n)
        {
            int result;
            if (m == 0 && n == 0)
            {
                throw new ArgumentException("all params can't be  0");
            }
            else if (m < 0 || n < 0)
            {
                throw new ArgumentException("params can't be negative");
            }

            int r;
            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;
            }
            result = m;

            return result;
        }
    }
}
