using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    public class Generic
    {
        public static List<T> CopyAtMost<T>( List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> ret = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }
            return ret;
        }

    }
}
