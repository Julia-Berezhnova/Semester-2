using NUnit.Framework;
using hw2_4;
using Stacks;
using Calculator;
using System;

namespace hw2_4
{
	[TestFixture ()]
	public class hw2_4Test
	{
		[Test ()]
		public void ArrayStackPushCase()
		{
			ArrayStack myStack = new ArrayStack ();
			for (var i = 0; i < 100; ++i) 
			{
				Assert.AreEqual (true, myStack.Push (i));
			}
			Assert.AreEqual (false, myStack.Push (100));
		}

		[Test ()]
		public void ListStackPushCase()
		{
			ListStack myStack = new ListStack ();
			for (var i = 0; i < 100; ++i) 
			{
				Assert.AreEqual (true, myStack.Push (i));
			}
			Assert.AreEqual (false, myStack.Push (100));
		}

		[Test ()]
		public void ArrayStack_and_CaluculatorCase ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (3);
			myCalculator.Push (2);
			myCalculator.Add ();
			Assert.AreEqual(5, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_and_CaluculatorCase2 ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (81);
			myCalculator.Push (3);
			myCalculator.Divide ();
			Assert.AreEqual(27, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_and_CaluculatorCase3 ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (8);
			myCalculator.Push (3);
			myCalculator.Subtract ();
			Assert.AreEqual(5, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_and_CaluculatorCase4 ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (8);
			myCalculator.Push (3);
			myCalculator.Multiply ();
			Assert.AreEqual(24, myCalculator.Result());
		}

		[Test ()]
		public void ListStack_and_CaluculatorCase ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (1);
			myCalculator2.Push (2);
			myCalculator2.Add ();
			Assert.AreEqual (3, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_and_CaluculatorCase2 ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (72);
			myCalculator2.Push (60);
			myCalculator2.Subtract ();
			Assert.AreEqual (12, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_and_CaluculatorCase3 ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (30);
			myCalculator2.Push (2);
			myCalculator2.Divide ();
			Assert.AreEqual (15, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_and_CaluculatorCase4 ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (30);
			myCalculator2.Push (2);
			myCalculator2.Multiply ();
			Assert.AreEqual (60, myCalculator2.Result ());
		}
	}
}

