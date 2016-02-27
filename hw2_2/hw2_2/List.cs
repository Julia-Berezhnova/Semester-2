namespace List
{
	class List: IList
	{
		private int listSize = 0;
		private ListElement head = null;

		private class ListElement
		{
			private int value = 0;

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
			
		public void addElement(int element)
		{
			if (this.head == null) 
			{
				this.head = new ListElement ();
				this.head.SetValue(element);
				this.head.SetNext(null);
			}
			else if (this.head.GetNext() == null)
			{
				this.head.SetNext(new ListElement ());
				(this.head.GetNext()).SetValue(element);
				(this.head.GetNext()).SetNext(null);
			}	
			else
			{
				ListElement temp = this.head;
				while (temp.GetNext() != null) 
				{
					temp = temp.GetNext();
				}
				temp.SetNext (new ListElement ());
				(temp.GetNext()).SetValue(element);
				(temp.GetNext()).SetNext(null);
			}
			++this.listSize;
		}
			
		public bool isEmpty()
		{
			if (this.head == null)
			{
				return true;
			}
			return false;
		}
			
		public bool deleteElement(int element)
		{
			if (this.isEmpty ()) 
			{
				return false;
			}
			ListElement temp = this.head;
			if (temp.GetValue() == element) 
			{
				this.head = this.head.GetNext ();
				return true;
			}
			if (temp.GetNext() != null) 
			{
				if ((temp.GetNext()).GetValue() == element)
				{
					this.head.SetNext ((this.head.GetNext ()).GetNext ());
					return true;
				}
			}
			else
			{
				return false;
			}
			while (temp.GetNext() != null) 
			{
				if ((temp.GetNext()).GetValue() == element)
				{
					temp.SetNext ((temp.GetNext ()).GetNext ());
					return true;
				}
				temp = temp.GetNext ();
			}
			return false;
		}



	}
}

