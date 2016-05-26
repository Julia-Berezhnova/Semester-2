﻿namespace Stacks
{
    /// <summary>
    /// Class stack as a list
    /// </summary>
    class Stack
    {
        private int currentSize;

        private ListElement head;

        public Stack()
        {
            this.currentSize = 0;
            this.head = null;
        }

        private class ListElement
        {
            private int value;

            private ListElement next;

            public ListElement(int value, ListElement next)
            {
                this.value = value;
                this.next = next;
            }

            public int Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }

            public ListElement Next
            {
                get
                {
                    return this.next;
                }
                set
                {
                    this.next = value;
                }
            }
        }

        public void Push(int element)
        {
            ListElement newElement = new ListElement(element, this.head);
            this.head = newElement;
            ++this.currentSize;
        }

        public bool IsEmpty() => this.head == null;

        public int Pop()
        {
            if (!this.IsEmpty())
            {
                int result = this.head.Value;
                this.head = this.head.Next;
                return result;
            }
            else
            {
                throw new StackEmptyException();
            }
        }

        public int Top()
        {
            if (!this.IsEmpty())
            {
                return this.head.Value;
            }
            else
            { 
                throw new StackEmptyException();
            }
        }
    }
}