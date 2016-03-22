using NUnit.Framework;
using System;
using Stacks;

namespace hw2_4
{
    [TestFixture()]
    public class ArrayStackTest
    {
        [SetUp()]
        public void InitialStateTest()
        {
            ArrayStack myList = new ArrayStack();
        }

        [Test()]
        public void PushTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(8);
        }

        [Test()]
        public void Push_BordersTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(int.MinValue);
            myList.Push(int.MaxValue);
        }

        [Test()]
        [ExpectedException(typeof(StackOverloadedException))]
        public void DontPushTest()
        {
            ArrayStack myList = new ArrayStack();
            for (int i = 0; i < 100; i++)
            {
                myList.Push(i);
            }
            myList.Push(100);
        }

        [Test()]
        public void PushAndPopTest()
        {
            ArrayStack myList = new ArrayStack();
            for (int i = 0; i < 100; i++)
            {
                myList.Push(i);
            }
            for (int i = 99; i > -1; i--)
            {
                Assert.AreEqual(i, myList.Pop());
            }
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        public void IsNotEmptyTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(123);
            Assert.AreEqual(false, myList.IsEmpty());
        }

        [Test()]
        public void IsEmptyTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(123);
            myList.Pop();
            Assert.AreEqual(true, myList.IsEmpty());
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        public void PopTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(123456);
            Assert.AreEqual(123456, myList.Pop());
        }

        [Test()]
        public void PopTest2()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(123);
            myList.Push(321);
            myList.Push(132);
            Assert.AreEqual(132, myList.Pop());
            Assert.AreEqual(321, myList.Pop());
            Assert.AreEqual(123, myList.Pop());
        }

        [Test()]
        public void Pop_UpperBorderTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(int.MaxValue);
            Assert.AreEqual(int.MaxValue, myList.Pop());
        }

        [Test()]
        public void Pop_LowerBorderTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(int.MinValue);
            Assert.AreEqual(int.MinValue, myList.Pop());
        }

        [Test()]
        [ExpectedException(typeof(StackEmptyException))]
        public void PopExceptionTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Pop();
        }

        [Test()]
        public void TopTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(12);
            Assert.AreEqual(12, myList.Top());
        }

        [ExpectedException(typeof(StackEmptyException))]
        public void TopExceptionTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Top();
        }

        [Test()]
        public void TopAndPopTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(123);
            Assert.AreEqual(123, myList.Top());
            myList.Pop();
            Assert.AreEqual(true, myList.IsEmpty());
        }

        [Test()]
        [ExpectedException(typeof(StackEmptyException))]
        public void LastTest()
        {
            ArrayStack myList = new ArrayStack();
            myList.Push(0);
            myList.Push(1);
            Assert.AreEqual(1, myList.Pop());
            myList.Push(2);
            myList.Push(3);
            myList.Push(2);
            Assert.AreEqual(2, myList.Pop());
            Assert.AreEqual(3, myList.Pop());
            Assert.AreEqual(2, myList.Pop());
            Assert.AreEqual(0, myList.Pop());
            Assert.AreEqual(true, myList.IsEmpty());
            myList.Pop();
        }
    }
}

