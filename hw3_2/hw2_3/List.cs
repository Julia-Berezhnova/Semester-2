﻿namespace NamespaceList
{
	/// <summary>
	/// Class list. Operations: add, delete, ckeck belonging
	/// </summary>
	class List: IList
	{
		private int listSize;

		private ListElement head;

		private class ListElement
		{
			private string value;

			private ListElement next;

			public ListElement()
			{
				this.value = "";
				this.next = null;
			}

			public ListElement(string value)
			{
				this.value = value;
				this.next = null;
			}

			public ListElement(string value, ListElement next)
			{
				this.value = value;
				this.next = next;
			}

			public string Value
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

		public void AddElement(string element)
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

		public bool DeleteElement(string element)
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

		public bool IsIn(string element)
		{
			ListElement temp = this.head;
			while (temp != null) 
			{
				if (temp.Value == element) 
				{
					return true;
				}
				temp = temp.Next;
			}
			return false;
		}
	}
}
