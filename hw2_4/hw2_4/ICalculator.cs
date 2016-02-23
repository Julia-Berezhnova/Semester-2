namespace NamespaceICalculator
{
	interface ICalculator
	{
		// Adds two values to the stack, 
		// places result back on stack.
		void Add();

		// Subtracts two values on the top of the stack, 
		// places result back on stack.
		void Subtract();

		// Multiplies two values on the top of the stack, 
		// places result back on stack.
		void Multiply();

		// Divides two values on the top of the stack, 
		// places result back on stack.
		void Divide();

		// Returns true if new value is successfully added to the stack
		// false - if there is some mistake
		bool Push(int value);

		// Returns the result of expression
		int Result();
	}
}

