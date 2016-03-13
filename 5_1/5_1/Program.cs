using System;
using System.Collections.Generic;

namespace _1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Map myMap = new Map();
            List<int> myList = new List<int>();
            myList.Insert(0, 1);
            myList.Insert(1, 2);
            myList.Insert(2, 3);
            myList = myMap.MapFunction(myList, x => x * 2);
            foreach (int element in myList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
