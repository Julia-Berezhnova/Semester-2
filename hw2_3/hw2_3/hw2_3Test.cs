using NUnit.Framework;
using System;

using NamespaceHashTable;

namespace hw2_3
{
	[TestFixture()]
	public class hw2_3Test
	{
		[Test()]
		public void Exists()
		{
			HashTable myHashTable = new HashTable();
			myHashTable.AddValue("hello");
			Assert.AreEqual(true, myHashTable.Exists("hello"));
		}

		[Test()]
		public void DoesntExist()
		{
			HashTable myHashTable = new HashTable();
			Assert.AreEqual(false, myHashTable.Exists("hello"));
		}

		[Test()]
		public void DeleteValue()
		{
			HashTable myHashTable = new HashTable();
			myHashTable.AddValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf");
			Assert.AreEqual(true, myHashTable.Exists("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
			Assert.AreEqual(true, myHashTable.DeleteValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
		}

		[Test()]
		public void LastTest()
		{
			HashTable myHashTable = new HashTable();
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

