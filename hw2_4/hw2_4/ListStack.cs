namespace Stacks
{
	/// <summary>
	/// Class stack as a list
	/// </summary>
	class ListStack: Stack
	{
		private ListElement head = null;

		private class ListElement
		{
			private int value;

			private ListElement next = null;

			public void SetValue (int value)
			{
				this.value = value;
			}

			public void SetNext (ListElement element)
			{
				this.next = element;
			}

			public int GetValue ()
			{
				return this.value;
			}

			public ListElement GetNext()
			{
				return this.next;
			}

		}

		public override bool Push(int element)
		{
			if (this.currentSize < maxElementsNumber) 
			{
				ListElement newElement = new ListElement ();
				newElement.SetValue(element);
				newElement.SetNext(this.head);
				this.head = newElement;
				++this.currentSize;
				return true;
			}
			else
			{
				return false;
			}
		}

		public override bool isEmpty()
		{
			if (this.head == null)
			{
				return true;
			}
			return false;
		}

		public override int Pop()
		{
			int result = this.head.GetValue();
			this.head = this.head.GetNext();
			return result;
		}

		public override int Top()
		{
			return this.head.GetValue();
		}
	}
}

