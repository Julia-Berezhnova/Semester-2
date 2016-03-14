using NUnit.Framework;
using System;

namespace List
{
    /// <summary>
    /// Hw2.2 test.
    /// </summary>
    [TestFixture()]
    public class hw2_2Test
    {
        [SetUp()]
        public void InitialTest()
        {
            List myList = new List();
        }

        [Test()]
        public void IsEmptyTest()
        {
            List myList = new List();
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        public void IsNotEmptyTest()
        {
            List myList = new List();
            myList.AddElement(123);
            Assert.AreEqual(false, myList.IsEmpty());
        }

        [Test()]
        public void IsEmptyTest2()
        {
            List myList = new List();
            myList.AddElement(123);
            myList.AddElement(321);
            myList.AddElement(132);
            myList.DeleteElement(123);
            Assert.AreEqual(false, myList.IsEmpty());
        }

        [Test()]
        public void IsEmptyTest3()
        {
            List myList = new List();
            myList.AddElement(123);
            myList.AddElement(321);
            myList.AddElement(132);
            myList.DeleteElement(321);
            myList.DeleteElement(123);
            myList.DeleteElement(132);
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        public void AddElement_UpperBorderTest()
        {
            List myList = new List();
            myList.AddElement(int.MaxValue);
            Assert.AreEqual(true, myList.DeleteElement(int.MaxValue));
        }

        [Test()]
        public void AddElement_LowerBorderTest()
        {
            List myList = new List();
            myList.AddElement(int.MinValue);
            Assert.AreEqual(true, myList.DeleteElement(int.MinValue));
        }

        [Test()]
        public void DeleteElementTest()
        {
            List myList = new List();
            myList.AddElement(8);
            Assert.AreEqual(true, myList.DeleteElement(8));
        }

        [Test()]
        public void DeleteElementTest2()
        {
            List myList = new List();
            myList.AddElement(8);
            myList.AddElement(-8);
            Assert.AreEqual(true, myList.DeleteElement(8));
            Assert.AreEqual(true, myList.DeleteElement(-8));
            Assert.AreEqual(false, myList.DeleteElement(8));
        }

        [Test()]
        public void LastTestTest()
        {
            List myList = new List();
            myList.AddElement(0);
            myList.AddElement(1);
            Assert.AreEqual(true, myList.DeleteElement(0));
            Assert.AreEqual(false, myList.DeleteElement(0));
            myList.AddElement(2);
            myList.AddElement(2);
            Assert.AreEqual(true, myList.DeleteElement(2));
            Assert.AreEqual(true, myList.DeleteElement(2));
            myList.DeleteElement(1);
            Assert.AreEqual(true, myList.IsEmpty());
        }
    }
}

