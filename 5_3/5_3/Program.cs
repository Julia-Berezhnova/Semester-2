using System;
using System.Collections.Generic;

namespace _3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Fold().FoldFunction(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem));
        }
    }
}
