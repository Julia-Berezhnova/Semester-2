namespace Calculator
{
	/// <summary>
	/// Interface of a calculator
	/// </summary>
	interface ICalculator
	{
		/// <summary>
		/// Adds two values to the stack, 
		/// places result back on stack.
		/// </summary>
		void Add();

		/// <summary>
		/// Subtracts two values on the top of the stack, 
		/// places result back on stack.
		/// </summary>
		void Subtract();

		/// <summary>
		/// Multiplies two values on the top of the stack, 
		/// places result back on stack.
		/// </summary>
		void Multiply();

		/// <summary>
		/// Divides two values on the top of the stack, 
		/// places result back on stack.
		/// </summary>
		void Divide();

		/// <summary>
		/// Returns true if new value is successfully added to the stack
		/// false - if there is some mistake
		/// </summary>
		/// <param name="value">Value to add to the stack.</param>
		bool Push(int value);

		/// <summary>
		/// Returns the result of expression
		/// </summary>
		int Result();
	}
}

