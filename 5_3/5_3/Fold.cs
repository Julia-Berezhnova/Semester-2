using System.Collections.Generic;

namespace _3
{
    delegate int Function(int acc, int elem);

    class Fold
    {
        public int FoldFunction(List<int> list, int initialValue, Function function)
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

