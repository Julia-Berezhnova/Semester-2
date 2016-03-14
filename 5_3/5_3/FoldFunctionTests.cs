using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _3
{
    [TestFixture()]
    public class FoldFunctionTests
    {
        [SetUp()]
        public void InitialTest()
        {
            Fold myFold = new Fold();
        }

        [Test()]
        public void SampleTest()
        {
            Fold myFold = new Fold();
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(2);
            int result = myFold.FoldFunction(myList, 1, (x, y) => x * y);
            Assert.AreEqual(6, result);
        }

        [Test()]
        public void UselessFuncTest()
        {
            Fold myFold = new Fold();
            List<int> myList = new List<int>() { 6, 9, 8, 7};
            int result = myFold.FoldFunction(myList, 0, (x, y) => x * y);
            Assert.AreEqual(0, result);
        }

        [Test()]
        public void FiveThousandFuncTest()
        {
            Fold myFold = new Fold();
            List<int> myList = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1};
            int result = myFold.FoldFunction(myList, 500, (x, y) => x + y * 100);
            Assert.AreEqual(5000, result);
        }
    }
}

