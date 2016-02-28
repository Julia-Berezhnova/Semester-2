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
			private int value;

			private ListElement next;

			public ListElement()
			{
				this.value = 0;
				this.next = null;
			}

			public ListElement(int value)
			{
				this.value = value;
				this.next = null;
			}

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
			
		public void AddElement(int element)
		{
			if (this.head == null) 
			{
				this.head = new ListElement (element);
			}
			else if (this.head.Next == null)
			{
				this.head.Next = new ListElement (element);
			}	
			else
			{
				ListElement temp = this.head;
				while (temp.Next != null) 
				{
					temp = temp.Next;
				}
				temp.Next = new ListElement (element);
			}
			++this.listSize;
		}
			
		public bool IsEmpty() =>  this.head == null;
			
		public bool DeleteElement(int element)
		{
			if (this.IsEmpty ()) 
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
					this.head.Next =  this.head.Next.Next;
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

