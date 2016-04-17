using System;
using System.Collections.Generic;

namespace _3
{
    class Fold
    {
        public static int FoldFunction(List<int> list, int initialValue, Func<int, int, int> function)
        {
            int result = initialValue;
            foreach (int element in list)
            {
                result = function(result, element);
            }
            return result;
        }
    }
}

