using NUnit.Framework;
using System;

using NamespaceHashTable;

namespace hw2_3
{
	[TestFixture ()]
	public class SimpleHashFunctionTest
	{
		[SetUp ()]
		public void Exists ()
		{
			HashTable myHashTable = new HashTable (10, new SimpleHashFunction());
			myHashTable.AddValue ("hello");
			Assert.AreEqual(true, myHashTable.Exists("hello"));
		}

		[Test ()]
		public void DoesntExist ()
		{
			HashTable myHashTable = new HashTable (12, new SimpleHashFunction());
			Assert.AreEqual(false, myHashTable.Exists("hello"));
		}

		[Test ()]
		public void DeleteValue ()
		{
			HashTable myHashTable = new HashTable (2, new SimpleHashFunction());
			myHashTable.AddValue ("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf");
			Assert.AreEqual (true, myHashTable.DeleteValue ("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
		}

		[TearDown ()]
		public void LastTest ()
		{
			HashTable myHashTable = new HashTable (1, new SimpleHashFunction());
			Assert.AreEqual (false, myHashTable.DeleteValue ("bye"));
			myHashTable.AddValue ("i don't know");
			myHashTable.AddValue ("what");
			myHashTable.AddValue ("to");
			myHashTable.AddValue ("write");
			Assert.AreEqual (true, myHashTable.DeleteValue ("what"));
			Assert.AreEqual (false, myHashTable.DeleteValue ("what"));
			Assert.AreEqual (false, myHashTable.DeleteValue("what"));
			Assert.AreEqual (true, myHashTable.DeleteValue ("to"));
		}
	}
}

