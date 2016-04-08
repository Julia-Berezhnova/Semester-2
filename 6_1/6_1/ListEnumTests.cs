using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _1
{
    /// <summary>
    /// Unit tests for enumerator 'ListEnum<T>'
    /// </summary>
    [TestFixture()]
    public class ListEnumTests
    {
        [SetUp()]
        public void InitialTest()
        {
            List<string> myList = new List<string>();
            var words = new ListEnum<string>(myList, 10);
        }

        [Test()]
        public void MoveNextTest()
        {
            List<string> myList = new List<string>();
            var words = new ListEnum<string>(myList, 1);
            Assert.AreEqual(true, words.MoveNext());
        }

        [Test()]
        public void MoveNextFalseTest()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            var words = new ListEnum<int>(myList, 2);
            Assert.AreEqual(true, words.MoveNext());
            Assert.AreEqual(true, words.MoveNext());
            Assert.AreEqual(false, words.MoveNext());
        }

        [Test()]
        public void CurrentSimpleTest()
        {
            List<char> myList = new List<char>();
            myList.Add('w');
            var words = new ListEnum<char>(myList, 10);
            words.MoveNext();
            Assert.AreEqual('w', words.Current);
        }

        [Test()]
        public void CurrentTest()
        {
            List<int> myList = new List<int>();
            myList.Add(123);
            myList.Add(3);
            myList.Add(908);
            myList.Add(51);
            myList.Add(412);
            var words = new ListEnum<int>(myList, 5);
            words.MoveNext();
            Assert.AreEqual(123, words.Current);
            words.MoveNext();
            Assert.AreEqual(3, words.Current);
            words.MoveNext();
            Assert.AreEqual(908, words.Current);
            words.MoveNext();
            Assert.AreEqual(51, words.Current);
            words.MoveNext();
            Assert.AreEqual(412, words.Current);
        }

        [Test()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CurrentExceptionTest()
        {
            List<string> myList = new List<string>();
            myList.Add("hello");
            var words = new ListEnum<string>(myList, 1);
            words.MoveNext();
            words.MoveNext();
            var x = words.Current;
        }

        [Test()]
        public void ResetSimpleTest()
        {
            List<string> myList = new List<string>();
            myList.Add("hello");
            var words = new ListEnum<string>(myList, 100);
            words.MoveNext();
            words.Reset();
        }

        [Test()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ResetExceptionTest()
        {
            List<string> myList = new List<string>();
            myList.Add("hello");
            var words = new ListEnum<string>(myList, 100);
            words.MoveNext();
            words.Reset();
            var x = words.Current;
        }
    }
}

