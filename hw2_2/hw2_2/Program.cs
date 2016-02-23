using System;

namespace List
{
	class List
	{
		private int listSize = 0;
		private listElement head = null;

		private class listElement
		{
			public int value = 0;
			public listElement next = null;
		}
			
		// adds new element to the list
		public void addElement(int element)
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


		// returns true if the list is empty
		public bool isEmpty()
		{
			if (this.head == null)
			{
				return true;
			}
			return false;
		}

		// returns true if element is deleted, otherwise it's not in the list
		public bool deleteElement(int element)
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

		

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			List myList = new List ();
			myList.addElement (12);
			Console.WriteLine (myList.deleteElement (12));
			Console.WriteLine (myList.deleteElement (13));
		}
	}
}
