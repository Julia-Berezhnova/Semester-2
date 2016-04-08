using System.Collections;
using System.Collections.Generic;

namespace _1
{
    /// <summary>
    /// Enumerator for a list from System.Collections.Generic
    /// with a definite length
    /// that can be set up at the moment constructor called
    /// </summary>
    public class ListEnum<T>: IEnumerator
    {
        private int position = -1;

        private uint length;

        public List<T> list;

        public ListEnum(List<T> someList, uint maxLength)
        {
            this.list = someList;
            this.length = maxLength;
        }

        public bool MoveNext()
        {
            if (++position < length)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                if (position < length && position > -1)
                {
                    return list[position];
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}

