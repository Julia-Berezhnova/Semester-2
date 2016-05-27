using System;

namespace task1
{
    /// <summary>
    /// Stack template class
    /// </summary>
    class Stack<T>
    {
        public void Push(T element)
        {
            if (head == null)
            {
                head = new StackElement(element, null);
                return;
            }
            var temp = new StackElement(element, this.head);
            head = temp;
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new EmptyStackException();
            }
            T temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool IsEmpty() => head == null;

        private class StackElement
        {
            public T Value { get; set; }

            public StackElement Next { get; set; }

            public StackElement(T value, StackElement next)
            {
                Value = value;
                Next = next;
            }
        }

        private StackElement head = null;
    }
}

