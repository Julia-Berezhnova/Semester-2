namespace ArrayStack
{
	/// <summary>
	/// Array stack.
	/// </summary>
	class ArrayStack
	{
		/// <summary>
		/// Max number of elements in the stack array
		/// </summary>
		private const int maxElementsNumber = 100; 

		/// <summary>
		/// Number of elements in the stack array
		/// </summary>
		private int currentSize = 0; 

		/// <summary>
		/// Stack array
		/// </summary>
		private int[] array = new int[maxElementsNumber]; 

		/// <summary>
		/// Initializes a new instance of the <see cref="ArrayStack.ArrayStack"/> class.
		/// </summary>
		public ArrayStack() 
		{
			for (int i = 0; i < maxElementsNumber; ++i)
			{
				this.array[i] = 0; // just in case
			}
			currentSize = 0; // just in case
		}

		/// <summary>
		/// Returns true if stack is empty, otherwise it's false
		/// </summary>
		/// <returns><c>true</c>, if empty was ised, <c>false</c> otherwise.</returns>
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

		/// <summary>
		/// Returns true if element is added, and false if stack is going to get overloaded
		/// </summary>
		/// <param name="element">Element user wants to add to the stack.</param>
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

		/// <summary>
		/// Returns the last added element, deletes it from the stack
		/// WARNING: one should check if the stack is not empty before this operation
		/// </summary>
		public int Pop()
		{
			--currentSize;
			return this.array[currentSize]; 
		}

	}
}

