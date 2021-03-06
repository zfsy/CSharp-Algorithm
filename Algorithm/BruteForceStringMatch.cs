﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BruteForceStringMatch
    {
        /*
         子串最多需要移动的次数: n - m +1次
         每一次移动子串最多需要比较的次数: m次
             */
        public static int Match(string text, string pattern)
        {
            int ret = -1;

            if (pattern == null || pattern.Length > text.Length)
            {
                throw new ArgumentException("the number of characters in pattern must't be greater than the number of characters in text");
            }

            int t = text.Length, p = pattern.Length, j;
            for (int i = 0; i < t - p; i++)
            {
                j = 0;
                while (j < p && pattern[j] == text[i+j])
                {
                    j++;
                }
                if (j == p)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }
    }
}
