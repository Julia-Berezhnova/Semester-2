using NUnit.Framework;
using System;

namespace ArrayStack
{
	[TestFixture ()]
	public class hw2_1Test
	{
		ArrayStack myStack = new ArrayStack();

		[Test ()]
		public void TestCase1 ()
		{
			Assert.AreEqual (true, myStack.Push (8));
		}

		[Test ()]
		public void TestCase2 ()
		{
			Assert.AreEqual (8, myStack.Pop ());
		}

		[Test ()]
		public void TestCase3 ()
		{
			Assert.AreEqual (true, myStack.isEmpty ());
		}
	}
}

