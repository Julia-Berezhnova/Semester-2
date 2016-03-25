using NUnit.Framework;
using System;

namespace exam
{
    /// <summary>
    /// Tests for Queue class.
    /// </summary>
    [TestFixture()]
    public class QueueTests
    {
        [Test()]
        public void EnqueueSimpleTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
        }

        [Test()]
        public void EnqueueElementWithHigherPriorityTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
            myQ.Enqueue(200, 2);
        }

        [Test()]
        public void EnqueueElementWithLowerPriorityTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
            myQ.Enqueue(200, -1);
        }

        [Test()]
        public void EnqueueUpBorderPriorityTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, int.MaxValue);
        }

        [Test()]
        public void EnqueueDownBorderPriorityTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, int.MinValue);
        }

        [Test()]
        public void EnqueueUpBorderValueTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(int.MaxValue, 1);
        }

        [Test()]
        public void EnqueueDownBorderValueTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(int.MinValue, 1);
        }

        [Test()]
        [ExpectedException(typeof(EmptyQueueException))]
        public void DequeueExceptionTest()
        {
            Queue myQ = new Queue();
            myQ.Dequeue();
        }

        [Test()]
        public void DequeueSimpleTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
            Assert.AreEqual(100, myQ.Dequeue());
        }

        [Test()]
        public void DequeueTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
            myQ.Enqueue(200, 2);
            Assert.AreEqual(200, myQ.Dequeue());
        }

        [Test()]
        public void AnotherDequeueTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(100, 1);
            myQ.Enqueue(200, -1);
            Assert.AreEqual(100, myQ.Dequeue());
        }

        [Test()]
        public void SaveOrderOfElementsWithEqualPrioritiesTest()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(2, 9);
            myQ.Enqueue(1, 10);
            myQ.Enqueue(3, 9);
            Assert.AreEqual(1, myQ.Dequeue());
            Assert.AreEqual(2, myQ.Dequeue());
            Assert.AreEqual(3, myQ.Dequeue());
        }

        [Test()]
        public void SaveOrderOfElementsWithEqualPrioritiesTest2()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(1, 9);
            myQ.Enqueue(2, 9);
            myQ.Enqueue(3, 9);
            Assert.AreEqual(1, myQ.Dequeue());
            Assert.AreEqual(2, myQ.Dequeue());
            Assert.AreEqual(3, myQ.Dequeue());
        }
    }
}

