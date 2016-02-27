using NUnit.Framework;
using System;

using NamespaceHashTable;

namespace hw2_3
{
	[TestFixture ()]
	public class hw2_3Test
	{
		private HashTable myHashTable = new HashTable ();

		[Test ()]
		public void HashTableTestCase ()
		{
			myHashTable.addValue ("hello");
			Assert.AreEqual(true, myHashTable.exists("hello"));
			myHashTable.deleteValue ("hello");
		}

		[Test ()]
		public void HashTableTestCase2 ()
		{
			Assert.AreEqual(false, myHashTable.exists("hello"));
		}

		[Test ()]
		public void HashTableTestCase3 ()
		{
			myHashTable.addValue ("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf");
			Assert.AreEqual (true, myHashTable.exists ("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
		}

		[Test ()]
		public void HashTableTestCase4 ()
		{
			Assert.AreEqual (false, myHashTable.deleteValue ("bye"));
		}
	}
}

