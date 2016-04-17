using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _1
{
    /// <summary>
    /// Map function test.
    /// </summary>
    [TestFixture()]
    public class MapFunctionTest
    {
        [Test()]
        public void OriginalListDoesntChangeTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 5);
            Map.MapFunction(myList, x => x * x);
            Assert.AreEqual(5, (myList[0]));
        }

        [Test()]
        public void SquareTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 5);
            List<int> changedList = Map.MapFunction(myList, x => x * x);
            Assert.AreEqual(25, (changedList[0]));
        }

        [Test()]
        public void CubeTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 5);
            List<int> changedList = Map.MapFunction(myList, x => x * x * x);
            Assert.AreEqual(125, changedList[0]);
        }

        [Test()]
        public void DoubleTest()
        {
            List<int> myList = new List<int>();
            myList.Insert(0, 1);
            myList.Insert(1, 2);
            myList.Insert(2, 3);
            List<int> changedList = Map.MapFunction(myList, x => x * 2);
            Assert.AreEqual(2, changedList[0]);
            Assert.AreEqual(4, changedList[1]);
            Assert.AreEqual(6, changedList[2]);
        }
    }
}

