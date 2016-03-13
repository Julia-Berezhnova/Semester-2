using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _1
{
    [TestFixture()]
    public class MapFunctionTest
    {
        [SetUp()]
        public void InitialTest()
        {
            Map myMap = new Map();
            List<int> myList = new List<int>();
        }

        [Test()]
        public void SquareTest()
        {
            Map myMap = new Map();
            List<int> myList = new List<int>();
            myList.Insert(0, 5);
            myList = myMap.MapFunction(myList, x => x * x);
            Assert.AreEqual(25, (myList[0]));
        }

        [Test()]
        public void CubeTest()
        {
            Map myMap = new Map();
            List<int> myList = new List<int>();
            myList.Insert(0, 5);
            myList = myMap.MapFunction(myList, x => x * x * x);
            Assert.AreEqual(125, myList[0]);
        }

        [Test()]
        public void DoubleTest()
        {
            Map myMap = new Map();
            List<int> myList = new List<int>();
            myList.Insert(0, 1);
            myList.Insert(1, 2);
            myList.Insert(2, 3);
            myList = myMap.MapFunction(myList, x => x * 2);
            Assert.AreEqual(2, myList[0]);
            Assert.AreEqual(4, myList[1]);
            Assert.AreEqual(6, myList[2]);
        }
    }
}

