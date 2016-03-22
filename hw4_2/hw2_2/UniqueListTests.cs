using NUnit.Framework;
using System;

namespace List
{
    /// <summary>
    /// UniqueList tests.
    /// </summary>
    [TestFixture()]
    public class UniqueListTests
    {
        [SetUp()]
        public void InitialTest()
        {
            UniqueList myList = new UniqueList();
        }

        [Test()]
        [ExpectedException(typeof(RepeatedValueException))]
        public void AddExistentElementTest()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(123);
            myList.AddElement(123);
        }

        // The rest of the tests are copied from class ListTests
        [Test()]
        public void IsEmptyTest()
        {
            UniqueList myList = new UniqueList();
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        public void IsNotEmptyTest()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(123);
            Assert.AreEqual(false, myList.IsEmpty());
        }

        [Test()]
        public void IsEmptyTest2()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(123);
            myList.AddElement(321);
            myList.AddElement(132);
            myList.DeleteElement(123);
            Assert.AreEqual(false, myList.IsEmpty());
        }

        [Test()]
        public void IsEmptyTest3()
        {
            UniqueList myList = new UniqueList();
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
            UniqueList myList = new UniqueList();
            myList.AddElement(int.MaxValue);
        }

        [Test()]
        public void AddElement_LowerBorderTest()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(int.MinValue);
        }

        [Test()]
        public void DeleteElementTest()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(8);
            myList.DeleteElement(8);
        }

        [Test()]
        [ExpectedException(typeof(NonexistentElementException))]
        public void DeleteNonExistentElementTest()
        {
            UniqueList myList = new UniqueList();
            myList.AddElement(9);
            myList.DeleteElement(8);
        }

        [Test()]
        [ExpectedException(typeof(EmptyListException))]
        public void DeleteElementInEmptyListTest()
        {
            UniqueList myList = new UniqueList();
            myList.DeleteElement(8);
        }
    }
}

