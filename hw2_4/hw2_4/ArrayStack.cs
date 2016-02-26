namespace Stacks
{
	/// <summary>
	/// Class stack based on array
	/// </summary>
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
}

