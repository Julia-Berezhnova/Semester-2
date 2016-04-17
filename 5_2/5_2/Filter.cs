using System;
using System.Collections.Generic;

namespace _2
{
    class Filter
    {
        public static List<int> FilterFunction(List<int> list, Func<int, bool> function)
        {
            List<int> result = new List<int>();
            foreach (int element in list)
            {
                if (function(element))
                {
                    result.Add(element);
                }
            }
            return result;
        }
    }
}

