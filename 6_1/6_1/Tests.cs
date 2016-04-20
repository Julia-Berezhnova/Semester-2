using NUnit.Framework;
using System;

namespace task1
{
    /// <summary>
    /// Unit tests for list template class
    /// </summary>
    [TestFixture()]
    public class ListTests
    {
        [Test()]
        public void EnumeratorTest()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int i = 3;
            foreach (int element in list)
            {
                Assert.AreEqual(i,element);
                --i;
            }
        }

        [Test()]
        public void ContainsTest()
        {
            var list = new List<char>();
            list.Add('r');
            Assert.IsTrue(list.Contains('r'));
        }

        [Test()]
        public void ContainsNotTest()
        {
            var list = new List<char>();
            list.Add('w');
            Assert.IsFalse(list.Contains('r'));
        }

        [Test()]
        public void AddTest()
        {
            var list = new List<string>();
            list.Add("hello world");
        }

        [Test()]
        public void DeleteTest()
        {
            var list = new List<string>();
            list.Add("hello world");
            list.Delete("hello world");
        }

        [Test()]
        [ExpectedException(typeof(NonexistentElementException))]
        public void DeleteNonexistentElementTest()
        {
            var list = new List<string>();
            list.Add("hello");
            list.Delete("world");
        }

        [Test()]
        [ExpectedException(typeof(EmptyListException))]
        public void DeleteFromEmptyList()
        {
            var list = new List<string>();
            list.Delete("world");
        }
    }

    /// <summary>
    /// Unit tests for stack template class
    /// </summary>
    [TestFixture()]
    public class StackTests
    {
        [Test()]
        public void PushTest()
        {
            var stack = new Stack<string>();
            stack.Push("hello");
        }

        [Test()]
        public void PopTest()
        {
            var stack = new Stack<string>();
            stack.Push("hello");
            Assert.AreEqual("hello", stack.Pop());
        }

        [Test()]
        [ExpectedException(typeof(EmptyStackException))]
        public void PopEmptyStackTest()
        {
            var stack = new Stack<string>();
            stack.Pop();
        }

        [Test()]
        public void IsEmptyTest()
        {
            var stack = new Stack<string>();
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test()]
        public void IsNotEmptyTest()
        {
            var stack = new Stack<string>();
            stack.Push("hello");
            Assert.IsFalse(stack.IsEmpty());
        }
    }
}

