using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _2
{
    [TestFixture()]
    public class FilterFunctionTests
    {
        [Test()]
        public void OriginalListDoesntChangeTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 0);
            myList.Insert(1, 1);
            Filter.FilterFunction(myList, x => x > 0);
            Assert.AreEqual(0, myList[0]);
            Assert.AreEqual(1, myList[1]);
        }

        [Test()]
        public void AboveZero_ValueTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 0);
            myList.Insert(1, 1);
            myList = Filter.FilterFunction(myList, x => x > 0);
            Assert.AreEqual(1, myList[0]);
        }

        [Test()]
        public void AboveZero_CountTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 0);
            myList.Insert(1, 1);
            myList = Filter.FilterFunction(myList, x => x > 0);
            Assert.AreEqual(1, myList.Count);
        }

        [Test()]
        public void Parity_ValueTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 4);
            myList.Insert(1, 7);
            myList.Insert(2, 6);
            myList = Filter.FilterFunction(myList, x => x % 2 == 0);
            Assert.AreEqual(4, myList[0]);
            Assert.AreEqual(6, myList[1]);
        }

        [Test()]
        public void Parity_CountTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 4);
            myList.Insert(1, 7);
            myList.Insert(2, 6);
            myList = Filter.FilterFunction(myList, x => x % 2 == 0);
            Assert.AreEqual(2, myList.Count);
        }

        [Test()]
        public void CubeAbove27_ValueTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 2);
            myList.Insert(1, 3);
            myList.Insert(2, 4);
            myList = Filter.FilterFunction(myList, x => x * x * x > 27);
            Assert.AreEqual(4, myList[0]);
        }

        [Test()]
        public void CubeAbove27_CountTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 2);
            myList.Insert(1, 3);
            myList.Insert(2, 4);
            myList = Filter.FilterFunction(myList, x => x * x * x > 27);
            Assert.AreEqual(1, myList.Count);
        }
    }
}

