using System;
using Stacks;
using Calculator;

namespace hw2_4
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (3);
			myCalculator.Push (2);
			myCalculator.Push (1);
			myCalculator.Add ();
			myCalculator.Multiply ();
			Console.WriteLine (myCalculator.Result ());

			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator(myStack2);
			myCalculator2.Push (1);
			myCalculator2.Push (2);
			myCalculator2.Push (3);
			myCalculator2.Add ();
			myCalculator2.Multiply ();
			Console.WriteLine (myCalculator2.Result ());
		}
	}
}
