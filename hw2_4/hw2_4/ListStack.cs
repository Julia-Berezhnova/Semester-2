namespace Stacks
{
	/// <summary>
	/// Class stack as a list
	/// </summary>
	class ListStack: IStack
	{
		private int currentSize;

		private ListElement head;

		public ListStack()
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

		public bool Push(int element)
		{
			ListElement newElement = new ListElement (element, this.head);
			this.head = newElement;
			++this.currentSize;
			return true;
		}

		public bool IsEmpty() => this.head == null;

		public int Pop()
		{
			if (!this.IsEmpty ()) 
			{
				int result = this.head.Value;
				this.head = this.head.Next;
				return result;
			} 
			else 
			{
				return int.MinValue;
			}
		}

		public int Top() => this.head.Value;
	}
}