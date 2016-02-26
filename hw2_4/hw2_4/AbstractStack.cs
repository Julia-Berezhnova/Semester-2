namespace Stacks
{
	/// <summary>
	/// Abstract stack class 
	/// </summary>
	abstract class Stack: IStack
	{
		/// <summary>
		/// Max number of elements in the stack
		/// </summary>
		protected const int maxElementsNumber = 100; 

		/// <summary>
		/// Number of elements in the stack
		/// </summary>
		protected int currentSize = 0;  

		abstract public bool isEmpty ();

		abstract public bool Push (int element);

		abstract public int Pop();

		abstract public int Top();
	}
}

