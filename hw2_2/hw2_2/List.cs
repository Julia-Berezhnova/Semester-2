namespace List
{
    /// <summary>
    /// List.
    /// </summary>
    class List: IList
    {
        private int listSize = 0;
        private ListElement head = null;

        private class ListElement
        {
            public int Value { get; set; }

            public ListElement Next { get; set; }

            public ListElement()
            {
                Value = 0;
                Next = null;
            }

            public ListElement(int value, ListElement next)
            {
                Value = value;
                Next = next;
            }
        }

        public void AddElement(int element)
        {
            if (this.head == null)
            {
                this.head = new ListElement(element, null);
            }
            else if (this.head.Next == null)
            {
                this.head.Next = new ListElement(element, null);
            }
            else
            {
                ListElement temp = this.head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new ListElement(element, null);
            }
            ++this.listSize;
        }

        public bool IsEmpty() =>  this.head == null;

        public bool DeleteElement(int element)
        {
            if (this.IsEmpty())
            {
                return false;
            }

            ListElement temp = this.head;
            if (temp.Value == element)
            {
                this.head = this.head.Next;
                return true;
            }
            if (temp.Next != null)
            {
                if (temp.Next.Value == element)
                {
                    this.head.Next = this.head.Next.Next;
                    return true;
                }
            }
            else
            {
                return false;
            }

            while (temp.Next != null)
            {
                if (temp.Next.Value == element)
                {
                    temp.Next = temp.Next.Next;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
    }
}