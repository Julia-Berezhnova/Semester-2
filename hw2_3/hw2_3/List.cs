namespace NamespaceList
{
	/// <summary>
	/// Class list. Operations: add, delete, ckeck belonging
	/// </summary>
	class List: IList
	{
		private int listSize = 0;

		private ListElement head = null;

		private class ListElement
		{
			private string value = "";

			private ListElement next = null;

			public void SetValue (string value)
			{
				this.value = value;
			}

			public void SetNext (ListElement element)
			{
				this.next = element;
			}

			public string GetValue ()
			{
				return this.value;
			}

			public ListElement GetNext()
			{
				return this.next;
			}
		}

		public void addElement(string element)
		{
			if (this.head == null) 
			{
				this.head = new ListElement ();
				this.head.SetValue(element);
				this.head.SetNext(null);
			}
			else if (this.head.GetNext() == null)
			{
				ListElement newElement = new ListElement ();
				this.head.SetNext(newElement);
				(this.head.GetNext ()).SetValue (element);
				(this.head.GetNext ()).SetNext (null);
			}	
			else
			{
				ListElement temp = this.head;
				while (temp.GetNext() != null) 
				{
					temp = temp.GetNext();
				}
				temp.SetNext(new ListElement ());
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

		public bool deleteElement(string element)
		{
			if (this.isEmpty ()) 
			{
				return false;
			}
			ListElement temp = this.head;
			if (temp.GetValue() == element) 
			{
				this.head = this.head.GetNext();
				return true;
			}
			if (temp.GetNext() != null) 
			{
				if ((temp.GetNext()).GetValue() == element)
				{
					this.head.SetNext((this.head.GetNext()).GetNext());
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
					temp.SetNext((temp.GetNext()).GetNext());
					return true;
				}
				temp = temp.GetNext();
			}
			return false;
		}

		public bool isIn(string element)
		{
			ListElement temp = this.head;
			while (temp != null) 
			{
				if (temp.GetValue() == element) 
				{
					return true;
				}
				temp = temp.GetNext();
			}
			return false;
		}

	}
}
