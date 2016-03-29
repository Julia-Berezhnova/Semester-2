using System;

namespace exam
{
    /// <summary>
    /// Queue with priorities.
    /// </summary>
    public class Queue
    {
        private class QueueElement
        {
            public int Value { get; set; }

            public int Priority { get; set; }

            public QueueElement Previous { get; set; }

            public QueueElement(int value, int priority, QueueElement previous)
            {
                this.Value = value;
                this.Priority = priority;
                this.Previous = previous;
            }
        }

        private QueueElement tail;

        public Queue()
        {
            this.tail = null;
        }

        public void Enqueue(int value, int priority)
        {
            if (this.tail == null)
            {
                this.tail = new QueueElement(value, priority, null);
            }
            else
            {
                if (tail.Priority < priority)
                {
                    QueueElement exTail = this.tail;
                    this.tail = new QueueElement(value, priority, exTail);
                    return;
                }
                QueueElement temp = this.tail;
                QueueElement after;
                while (temp.Priority >= priority)
                {
                    after = temp;
                    if (temp.Previous == null)
                    {
                        temp.Previous = new QueueElement(value, priority, null);
                        return;
                    }
                    temp = temp.Previous;
                }
                QueueElement newElement = new QueueElement(value, priority, temp);
                after.Previous = newElement;
            }
        }

        public int Dequeue()
        {
            if (this.tail == null)
            {
                throw new EmptyQueueException();
            }
            int result = this.tail.Value;
            this.tail = this.tail.Previous;
            return result;
        }
    }
}