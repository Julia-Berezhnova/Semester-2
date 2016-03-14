using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _2
{
    [TestFixture()]
    public class FilterFunctionTests
    {
        [SetUp()]
        public void InitialTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
        }

        [Test()]
        public void AboveZero_ValueTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 0);
            myList.Insert(1, 1);
            myList = myFilter.FilterFunction(myList, x => x > 0);
            Assert.AreEqual(1, myList[0]);
        }

        [Test()]
        public void AboveZero_CountTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 0);
            myList.Insert(1, 1);
            myList = myFilter.FilterFunction(myList, x => x > 0);
            Assert.AreEqual(1, myList.Count);
        }

        [Test()]
        public void Parity_ValueTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 4);
            myList.Insert(1, 7);
            myList.Insert(2, 6);
            myList = myFilter.FilterFunction(myList, x => x % 2 == 0);
            Assert.AreEqual(4, myList[0]);
            Assert.AreEqual(6, myList[1]);
        }

        [Test()]
        public void Parity_CountTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 4);
            myList.Insert(1, 7);
            myList.Insert(2, 6);
            myList = myFilter.FilterFunction(myList, x => x % 2 == 0);
            Assert.AreEqual(2, myList.Count);
        }

        [Test()]
        public void CubeAbove27_ValueTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 2);
            myList.Insert(1, 3);
            myList.Insert(2, 4);
            myList = myFilter.FilterFunction(myList, x => x * x * x > 27);
            Assert.AreEqual(4, myList[0]);
        }

        [Test()]
        public void CubeAbove27_CountTest()
        {
            Filter myFilter = new Filter();
            List<int> myList = new List<int>();
            myList.Insert(0, 2);
            myList.Insert(1, 3);
            myList.Insert(2, 4);
            myList = myFilter.FilterFunction(myList, x => x * x * x > 27);
            Assert.AreEqual(1, myList.Count);
        }
    }
}

