using NUnit.Framework;
using System;

namespace List
{
	[TestFixture ()]
	public class hw2_2Test
	{
		List myList = new List ();

		[Test ()]
		public void TestCase ()
		{
			Assert.AreEqual (false, myList.deleteElement (5));
		}

		[Test ()]
		public void TestCase2 ()
		{
			Assert.AreEqual (true, myList.isEmpty());
		}

		[Test ()]
		public void TestCase3 ()
		{
			myList.addElement (8);
			Assert.AreEqual (true, myList.deleteElement (8));
		}

		[Test ()]
		public void TestCase4 ()
		{
			Assert.AreEqual (true, myList.isEmpty());
		}
	}
}

