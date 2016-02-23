using System;

namespace ArrayStack
{
	class ArrayStack
	{
		private const int maxElementsNumber = 100; // max number of elements in the stack array
		private int currentSize = 0; // number of elements in the stack array
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

		// returns true if stack is empty, otherwise it's false
		public bool isEmpty() 
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

		// returns true if element is added, and false if stack is going to get overloaded
		public bool Push(int element)
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

		// returns the last added element, deletes it from the stack
		// warning: one should check if the stack is not empty before this operation
		public int Pop()
		{
			--currentSize;
			return this.array[currentSize]; 
		}

	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			ArrayStack myStack = new ArrayStack ();
			myStack.Push (1);
			myStack.Push (2);
			myStack.Push (3);
			if (myStack.isEmpty ()) 
			{
				Console.WriteLine ("The stack is empty");
			}
			while (!myStack.isEmpty ()) 
			{
				Console.WriteLine ("Value in the stack: {0}", myStack.Pop ());
			}
		}
	}
}
