using System;
using System.Collections.Generic;

namespace _1
{
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 1);
            myList.Insert(1, 2);
            myList.Insert(2, 3);
            List<int> changedList = Map.MapFunction(myList, x => x * 2);
            foreach (int element in changedList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
