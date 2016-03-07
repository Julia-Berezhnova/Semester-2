using NUnit.Framework;
using System;

using NamespaceHashTable;

namespace hw2_3
{
    /// <summary>
    /// Test that checks class 'SimpleHashFunction: IHashFunction'.
    /// </summary>
	[TestFixture()]
	public class SimpleHashFunctionTest
	{
        [SetUp()]
        public void InitialTest()
        {
            HashTable myHashTable = new HashTable(1, new SimpleHashFunction());
        }

        [Test()]
        public void ExistsTest()
		{
			HashTable myHashTable = new HashTable(10, new SimpleHashFunction());
			myHashTable.AddValue("hello");
			Assert.AreEqual(true, myHashTable.Exists("hello"));
		}

		[Test()]
        public void DoesntExistTest()
		{
			HashTable myHashTable = new HashTable(12, new SimpleHashFunction());
			Assert.AreEqual(false, myHashTable.Exists("hello"));
		}

		[Test()]
		public void DeleteValueTest()
		{
			HashTable myHashTable = new HashTable(2, new SimpleHashFunction());
			myHashTable.AddValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf");
			Assert.AreEqual(true, myHashTable.DeleteValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
		}

        [Test()]
		public void LastTest()
		{
			HashTable myHashTable = new HashTable(1, new SimpleHashFunction());
			Assert.AreEqual(false, myHashTable.DeleteValue("bye"));
			myHashTable.AddValue("i don't know");
			myHashTable.AddValue("what");
			myHashTable.AddValue("to");
			myHashTable.AddValue("write");
			Assert.AreEqual(true, myHashTable.DeleteValue("what"));
			Assert.AreEqual(false, myHashTable.DeleteValue("what"));
			Assert.AreEqual(false, myHashTable.DeleteValue("what"));
			Assert.AreEqual(true, myHashTable.DeleteValue("to"));
		}
	}
}

