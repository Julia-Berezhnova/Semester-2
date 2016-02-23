using NamespaceIList;

namespace NamespaceList
{
	class List: IList
	{
		private int listSize = 0;
		private listElement head = null;

		private class listElement
		{
			public string value = "";
			public listElement next = null;
		}

		public void addElement(string element)
		{
			if (this.head == null) 
			{
				this.head = new listElement ();
				this.head.value = element;
				this.head.next = null;
			}
			else if (this.head.next == null)
			{
				this.head.next = new listElement ();
				this.head.next.value = element;
				this.head.next.next = null;
			}	
			else
			{
				listElement temp = this.head;
				while (temp.next != null) 
				{
					temp = temp.next;
				}
				temp.next = new listElement ();
				temp.next.value = element;
				temp.next.next = null;
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
			listElement temp = this.head;
			if (temp.value == element) 
			{
				this.head = this.head.next;
				return true;
			}
			if (temp.next != null) 
			{
				if (temp.next.value == element)
				{
					this.head.next = this.head.next.next;
					return true;
				}
			}
			else
			{
				return false;
			}
			while (temp.next != null) 
			{
				if (temp.next.value == element) 
				{
					temp.next = temp.next.next;
					return true;
				}
				temp = temp.next;
			}
			return false;
		}

		public bool isIn(string element)
		{
			listElement temp = this.head;
			while (temp != null) 
			{
				if (temp.value == element) 
				{
					return true;
				}
				temp = temp.next;
			}
			return false;
		}

	}
}
