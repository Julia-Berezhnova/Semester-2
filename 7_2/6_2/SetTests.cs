using NUnit.Framework;
using System;

namespace task2
{
    [TestFixture()]
    public class SetTests
    {
        [SetUp()]
        public void TestCase()
        {
            var set = new Set<char>();
        }

        [Test()]
        public void AddTest()
        {
            var set = new Set<char>();
            Assert.IsTrue(set.Add('a'));
        }

        [Test()]
        public void AddTheSameElementTest()
        {
            var set = new Set<char>();
            Assert.IsTrue(set.Add('a'));
            Assert.IsFalse(set.Add('a'));
        }

        [Test()]
        public void RemoveTest()
        {
            var set = new Set<string>();
            set.Add("hello world");
            Assert.IsTrue(set.Remove("hello world"));
        }

        [Test()]
        public void RemoveNotTest()
        {
            var set = new Set<string>();
            set.Add("hello");
            Assert.IsFalse(set.Remove("hello world"));
        }

        [Test()]
        public void ContainsTest()
        {
            var set = new Set<string>();
            set.Add("hello");
            Assert.IsTrue(set.Contains("hello"));
        }

        [Test()]
        public void ContainsNotTest()
        {
            var set = new Set<string>();
            Assert.IsFalse(set.Contains("hello"));
        }

        [Test()]
        public void IntersectionTest()
        {
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            var set2 = new Set<int>();
            set2.Add(1);
            set2.Add(2);
            set2.Add(4);
            var result = set.Intersection(set2);
            Assert.IsTrue(result.Contains(1));
            Assert.IsTrue(result.Contains(2));
            Assert.IsFalse(result.Contains(3));
            Assert.IsFalse(result.Contains(4));
        }

        [Test()]
        public void IntergrationTest()
        {
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            var set2 = new Set<int>();
            set2.Add(1);
            set2.Add(2);
            set2.Add(4);
            var result = set.Integration(set2);
            Assert.IsTrue(result.Contains(1));
            Assert.IsTrue(result.Contains(2));
            Assert.IsTrue(result.Contains(3));
            Assert.IsTrue(result.Contains(4));
        }
    }
}

