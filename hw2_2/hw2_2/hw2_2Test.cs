using NUnit.Framework;
using System;

namespace List
{
	[TestFixture ()]
	public class hw2_2Test
	{
		[SetUp()]
		public void InitialState ()
		{
			List myList = new List ();
			Assert.AreEqual (true, myList.IsEmpty());
		}

		[Test ()]
		public void IsEmpty ()
		{
			List myList = new List ();
			myList.AddElement (123);
			Assert.AreEqual(false, myList.IsEmpty());
		}

		[Test ()]
		public void IsEmpty2 ()
		{
			List myList = new List ();
			myList.AddElement (123);
			myList.AddElement (321);
			myList.AddElement (132);
			myList.DeleteElement (123);
			Assert.AreEqual(false, myList.IsEmpty());
		}

		[Test ()]
		public void IsEmpty3 ()
		{
			List myList = new List ();
			myList.AddElement (123);
			myList.AddElement (321);
			myList.AddElement (132);
			myList.DeleteElement (321);
			myList.DeleteElement (123);
			myList.DeleteElement (132);
			Assert.AreEqual(true, myList.IsEmpty());
		}

		[Test ()]
		public void AddElement_UpperBorder ()
		{
			List myList = new List ();
			myList.AddElement (int.MaxValue);
			Assert.AreEqual(true, myList.DeleteElement(int.MaxValue));
		}
			
		[Test ()]
		public void AddElement_LowerBorder ()
		{
			List myList = new List ();
			myList.AddElement (int.MinValue);
			Assert.AreEqual(true, myList.DeleteElement(int.MinValue));
		}

		[Test ()]
		public void DeleteElement ()
		{
			List myList = new List ();
			myList.AddElement (8);
			Assert.AreEqual (true, myList.DeleteElement (8));
		}

		[Test ()]
		public void DeleteElement2 ()
		{
			List myList = new List ();
			myList.AddElement (8);
			myList.AddElement (-8);
			Assert.AreEqual (true, myList.DeleteElement (8));
			Assert.AreEqual (true, myList.DeleteElement (-8));
			Assert.AreEqual (false, myList.DeleteElement (8));
		}

		[TearDown ()]
		public void LastTest ()
		{
			List myList = new List ();
			myList.AddElement (0);
			myList.AddElement (1);
			Assert.AreEqual (true, myList.DeleteElement (0));
			Assert.AreEqual (false, myList.DeleteElement (0));
			myList.AddElement (2);
			myList.AddElement (2);
			Assert.AreEqual (true, myList.DeleteElement (2));
			Assert.AreEqual (true, myList.DeleteElement (2));
			myList.DeleteElement (1);
			Assert.AreEqual (true, myList.IsEmpty ());
		}
	}
}

