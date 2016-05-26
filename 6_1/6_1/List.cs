using System.Collections.Generic;
using System.Collections;
using System;

namespace task1
{
    /// <summary>
    /// List template enumerable class.
    /// </summary>
    class List<T>: IEnumerable<T>
    {
        public bool Contains(T element)
        {
            if (!this.IsEmpty())
            {
                ListElement temp = this.head;
                while (temp != null)
                {
                    if (temp.Value.Equals(element))
                    {
                        return true;
                    }
                    temp = temp.Next;
                }
            }
            return false;
        }

        public void Add(T element)
        {
            if (this.head == null)
            {
                this.head = new ListElement(element, null);
            }
            else
            {
                ListElement temp = new ListElement(element, this.head);
                this.head = temp;
            }
        }

        public bool IsEmpty() =>  this.head == null;

        public void Delete(T element)
        {
            if (this.IsEmpty())
            {
                throw new EmptyListException();
            }

            ListElement temp = this.head;
            if (temp.Value.Equals(element))
            {
                this.head = this.head.Next;
                return;
            }
            if (temp.Next != null)
            {
                if (temp.Next.Value.Equals(element))
                {
                    this.head.Next = this.head.Next.Next;
                    return;
                }
            }
            else
            {
                throw new NonexistentElementException();
            }

            while (temp.Next != null)
            {
                if (temp.Next.Value.Equals(element))
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }
            throw new NonexistentElementException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        public IEnumerator GetEnumerator() => new ListEnum(this);

        public class ListEnum: IEnumerator<T>
        {
            public ListEnum(List<T> list)
            {
                this.list = list;
            }

            public bool MoveNext()
            {
                if (position == null && list.head != null)
                {
                    position = list.head;
                    return true;
                }
                else if (position == null && list.head == null)
                {
                    return false;
                }
                else if (position.Next == null)
                {
                    return false;
                }
                position = position.Next;
                return true;
            }

            public void Reset()
            {
                position = null;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            void IDisposable.Dispose() { }

            public T Current
            {
                get
                {
                    return position.Value;
                }
            }

            private List<T> list;

            private ListElement position = null;
        }

        private ListElement head = null;

        private class ListElement
        {
            public T Value { get; set; }

            public ListElement Next { get; set; }

            public ListElement(T value, ListElement next)
            {
                Value = value;
                Next = next;
            }
        }
    }
} 