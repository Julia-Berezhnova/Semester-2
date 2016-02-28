using NUnit.Framework;
using System;

namespace ArrayStack
{
	[TestFixture ()]
	public class hw2_1Test
	{
		[SetUp()] public void InitialState()
		{
			ArrayStack myStack = new ArrayStack();
			Assert.AreEqual (true, myStack.IsEmpty ());
		}

		[Test ()]
		public void Push()
		{
			ArrayStack myStack = new ArrayStack();
			Assert.AreEqual (true, myStack.Push (8));
		}
			
		[Test ()]
		public void PopUpperBorder()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push (int.MaxValue);
			Assert.AreEqual (int.MaxValue, myStack.Pop ());
		}

		[Test ()]
		public void PopLowerBorder()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push (int.MinValue);
			Assert.AreEqual (int.MinValue, myStack.Pop ());
		}

		[Test ()]
		public void IsEmpty()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push (8);
			Assert.AreEqual (false, myStack.IsEmpty ());
		}

		[TearDown()]
		public void LastTest()
		{
			ArrayStack myStack = new ArrayStack();
			myStack.Push (8);
			Assert.AreEqual (8, myStack.Pop ());
			myStack.Push (10);
			myStack.Push (-12);
			Assert.AreEqual (-12, myStack.Pop ());
			Assert.AreEqual (10, myStack.Pop ());
			Assert.AreEqual (true, myStack.IsEmpty ());
		}
	}
}

