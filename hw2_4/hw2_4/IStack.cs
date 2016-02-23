namespace NamespaceIStack
{
	interface IStack
	{
		// returns true if stack is empty, otherwise it's false
		bool isEmpty ();

		// returns true if element is added, and false if stack is going to get overloaded
		bool Push (int element);

		// returns the last added element, deletes it from the stack
		// warning: one should check if the stack is not empty before this operation
		int Pop ();

		// returns value from the top of the stack
		// warning: one should check if the stack is not empty before this operation
		int Top();
	}
}

