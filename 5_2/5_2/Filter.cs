using System.Collections.Generic;

namespace _2
{
    delegate bool Function(int element);

    class Filter
    {
        public List<int> FilterFunction(List<int> list, Function function)
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

