using NUnit.Framework;
using System;

namespace ArrayStack
{
	[TestFixture ()]
	public class hw2_1Test
	{
		[SetUp()] 
        public void InitialStateTest()
        {
            ArrayStack myStack = new ArrayStack();
        }

		[Test()]
		public void PushTest()
		{
			ArrayStack myStack = new ArrayStack();
			Assert.AreEqual(true, myStack.Push(8));
		}
			
		[Test()]
		public void PopUpperBorderTest()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push(int.MaxValue);
			Assert.AreEqual(int.MaxValue, myStack.Pop());
		}

		[Test()]
		public void PopLowerBorderTest()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push(int.MinValue);
			Assert.AreEqual(int.MinValue, myStack.Pop());
		}

        [ExpectedException(typeof(Exception))]
        public void EmptyStack_PopTest()
        {
            ArrayStack myStack = new ArrayStack();
            myStack.Pop();
        }

		[Test()]
		public void IsNotEmptyTest()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push(8);
			Assert.AreEqual(false, myStack.IsEmpty());
		}

        [Test()]
        public void IsEmptyTest()
        {
            ArrayStack myStack = new ArrayStack();
            Assert.AreEqual(true, myStack.IsEmpty());
        }

        [Test()]
		public void LastTest()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push (8);
			Assert.AreEqual(8, myStack.Pop());
			myStack.Push(10);
			myStack.Push(-12);
			Assert.AreEqual(-12, myStack.Pop());
			Assert.AreEqual(10, myStack.Pop());
			Assert.AreEqual(true, myStack.IsEmpty());
		}
	}
}

