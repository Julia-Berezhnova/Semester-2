using System;
using System.Collections.Generic;

namespace _1
{
    /// <summary>
    /// Map class that returns new list whom elements are elements from original list changed according to the delegate .
    /// </summary>
    public class Map
    {
        public List<int> MapFunction(List<int> list, Func<int,int> function)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; ++i)
            {
                int temp = list[i];
                int result = function(temp);
                newList.Insert(i, result);
            }
            return newList;
        }
    }
}

