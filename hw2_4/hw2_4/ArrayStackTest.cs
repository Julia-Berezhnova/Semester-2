using NUnit.Framework;
using System;
using Stacks;

namespace hw2_4
{
	[TestFixture ()]
	public class ArrayStackTest
	{
		[SetUp()]
		public void InitialState ()
		{
			ArrayStack myList = new ArrayStack ();
			Assert.AreEqual (true, myList.IsEmpty());
		}

		[Test ()]
		public void Push ()
		{
			ArrayStack myList = new ArrayStack ();
			Assert.AreEqual (true, myList.Push (8));
		}

		[Test ()]
		public void Push_Borders()
		{
			ArrayStack myList = new ArrayStack ();
			Assert.AreEqual (true, myList.Push (int.MinValue));
			Assert.AreEqual (true, myList.Push (int.MaxValue));
		}	

		[Test ()]
		public void DontPush()
		{
			ArrayStack myList = new ArrayStack ();
			for (int i = 0; i < 100; i++) 
			{
				Assert.AreEqual (true, myList.Push (i));
			}
			Assert.AreEqual (false, myList.Push (100));
		}

		[Test ()]
		public void PushAndPop()
		{
			ArrayStack myList = new ArrayStack ();
			for (int i = 0; i < 100; i++) 
			{
				Assert.AreEqual (true, myList.Push (i));
			}
			for (int i = 99; i > -1; i--) 
			{
				Assert.AreEqual (i, myList.Pop());
			}
			Assert.AreEqual (true, myList.IsEmpty ());
		}

		[Test ()]
		public void IsNotEmpty ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123);
			Assert.AreEqual(false, myList.IsEmpty());
		}

		[Test ()]
		public void IsEmpty ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123);
			myList.Pop ();
			Assert.AreEqual(true, myList.IsEmpty());
			Assert.AreEqual(true, myList.IsEmpty());
		}

		[Test ()]
		public void Pop ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123456);
			Assert.AreEqual(123456, myList.Pop());
		}

		[Test ()]
		public void Pop2 ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123);
			myList.Push (321);
			myList.Push (132);
			Assert.AreEqual(132, myList.Pop());
			Assert.AreEqual(321, myList.Pop());
			Assert.AreEqual(123, myList.Pop());
		}

		[Test ()]
		public void Pop_UpperBorder ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (int.MaxValue);
			Assert.AreEqual(int.MaxValue, myList.Pop());
		}

		[Test ()]
		public void Pop_LowerBorder ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (int.MinValue);
			Assert.AreEqual(int.MinValue, myList.Pop());
		}

		[Test ()]
		public void Top()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (12);
			Assert.AreEqual (12, myList.Top ());
		}

		[Test ()]
		public void Top2()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123);
			Assert.AreEqual (123, myList.Top ());
			Assert.AreEqual (false, myList.IsEmpty ());
		}

		[Test ()]
		public void TopAndPop()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (123);
			Assert.AreEqual (123, myList.Top ());
			myList.Pop ();
			Assert.AreEqual (true, myList.IsEmpty ());
		}

		[TearDown ()]
		public void LastTest ()
		{
			ArrayStack myList = new ArrayStack ();
			myList.Push (0);
			myList.Push (1);
			Assert.AreEqual (1, myList.Pop());
			myList.Push (2);
			myList.Push (3);
			myList.Push (2);
			Assert.AreEqual (2, myList.Pop());
			Assert.AreEqual (3, myList.Pop());
			Assert.AreEqual (2, myList.Pop());
			Assert.AreEqual (0, myList.Pop());
			Assert.AreEqual (true, myList.IsEmpty ());
			Assert.AreEqual (int.MinValue, myList.Pop ());
		}
	}
}

