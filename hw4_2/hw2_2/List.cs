namespace List
{
	/// <summary>
	/// List.
	/// </summary>
	class List: IList
	{
        protected int listSize = 0;
        protected ListElement head = null;

        protected class ListElement
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
			
        public virtual void AddElement(int element)
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
			++this.listSize;
		}
			
		public bool IsEmpty() =>  this.head == null;
			
        public void DeleteElement(int element)
		{
			if (this.IsEmpty()) 
			{
                throw new EmptyListException();
			}

			ListElement temp = this.head;
			if (temp.Value == element) 
			{
				this.head = this.head.Next;
                return;
			}
			if (temp.Next != null) 
			{
				if (temp.Next.Value == element)
				{
					this.head.Next =  this.head.Next.Next;
                    return;
				}
			}
			else
			{
                throw new NonexistentElementException();
			}

			while (temp.Next != null) 
			{
				if (temp.Next.Value == element)
				{
					temp.Next = temp.Next.Next;
                    return;
				}
				temp = temp.Next;
			}
            throw new NonexistentElementException();
		}
	}
}