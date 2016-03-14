using NUnit.Framework;
using System;

using NamespaceHashTable;

namespace hw2_3
{
    /// <summary>
    /// Test that checks class 'HashFunction37: IHashFunction'
    /// </summary>
    [TestFixture()]
    public class HashFunction37Test
    {
        [SetUp()]
        public void InitialTest()
        {
            HashTable myHashTable = new HashTable(10, new HashFunction37());
        }

        [Test()]
        public void ExistsTest()
        {
            HashTable myHashTable = new HashTable(10, new HashFunction37());
            myHashTable.AddValue("hello");
            Assert.AreEqual(true, myHashTable.Exists("hello"));
        }

        [Test()]
        public void DoesntExistTest()
        {
            HashTable myHashTable = new HashTable(12, new HashFunction37());
            Assert.AreEqual(false, myHashTable.Exists("hello"));
        }

        [Test()]
        public void DeleteValueTest()
        {
            HashTable myHashTable = new HashTable(10, new HashFunction37());
            myHashTable.AddValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf");
            Assert.AreEqual(true, myHashTable.DeleteValue("sdbgkjsgfskfjnbsf,gmbnfsgbsfgjbnrtbkjadfvjwrblhygwtlekjbg;qkejrbfdnfbvsmngv ae;erjgejgbjtrhvbgmd fveqjrgfq;owrfgqoreihgeqjbgvkdnfvm,nqegforewgftwrf"));
        }

        [TearDown()]
        public void LastTest()
        {
            HashTable myHashTable = new HashTable(1, new HashFunction37());
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

