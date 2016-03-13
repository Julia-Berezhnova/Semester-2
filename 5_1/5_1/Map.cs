using System.Collections.Generic;

namespace _1
{
    delegate int Function(int number);

    class Map
    {
        public List<int> MapFunction(List<int> list, Function function)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                int temp = list[i];
                list.Remove(temp);
                int result = function(temp);
                list.Insert(i, result);
            }
            return list;
        }
    }
}

