using NamespaceIStack;

namespace NamespaceStack
{
	abstract class Stack: IStack
	{
		protected const int maxElementsNumber = 100; //max number of elements in the array

		protected int currentSize = 0; // number of elements in the stack 

		abstract public bool isEmpty ();

		abstract public bool Push (int element);

		abstract public int Pop();

		abstract public int Top();
	}

	class ArrayStack: Stack
	{
		private int[] array = new int[maxElementsNumber]; 

		// class constructor
		public ArrayStack() 
		{
			for (int i = 0; i < maxElementsNumber; ++i)
			{
				this.array[i] = 0; // just in case
			}
			currentSize = 0; // just in case
		}

		public override bool isEmpty() 
		{
			if (this.currentSize == 0) 
			{
				return true;
			} 
			else 
			{
				return false;
			}	
		}

		public override bool Push(int element)
		{
			if (currentSize < maxElementsNumber) 
			{
				this.array[currentSize] = element;
				++currentSize;
				return true;
			} 
			else 
			{
				return false;
			}
		}

		public override int Pop()
		{
			--currentSize;
			return this.array[currentSize]; 
		}

		public override int Top()
		{
			return this.array [currentSize - 1];
		}
	}

	class ListStack: Stack
	{
		private ListElement head = null;

		private class ListElement
		{
			public int value = 0;
			public ListElement next = null;
		}

		public override bool Push(int element)
		{
			if (this.currentSize < maxElementsNumber) 
			{
				ListElement newElement = new ListElement ();
				newElement.next = this.head;
				newElement.value = element;
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
			int result = this.head.value;
			this.head = this.head.next;
			return result;
		}

		public override int Top()
		{
			return this.head.value;
		}
	}
}

