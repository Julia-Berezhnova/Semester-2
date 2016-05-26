using NUnit.Framework;
using System;

namespace List
{
    /// <summary>
    /// List tests.
    /// </summary>
    [TestFixture()]
    public class ListTests
    {
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
        }

        [Test()]
        public void AddElement_LowerBorderTest()
        {
            List myList = new List();
            myList.AddElement(int.MinValue);
        }

        [Test()]
        public void DeleteElementTest()
        {
            List myList = new List();
            myList.AddElement(8);
            myList.DeleteElement(8);
        }

        [Test()]
        [ExpectedException(typeof(NonexistentElementException))]
        public void DeleteNonExistentElementTest()
        {
            List myList = new List();
            myList.AddElement(9);
            myList.DeleteElement(8);
        }

        [Test()]
        [ExpectedException(typeof(EmptyListException))]
        public void DeleteElementInEmptyListTest()
        {
            List myList = new List();
            myList.DeleteElement(8);
        }
    }
}

