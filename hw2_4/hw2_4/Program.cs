using System;
using NamespaceCalculator;
using NamespaceStack;

namespace hw2_4
{
	class Program
	{
		public static void Main (string[] args)
		{
			ArrayStack myStack = new ArrayStack ();
			Calculator myCalculator = new Calculator(myStack);
			myCalculator.Push (3);
			myCalculator.Push (2);
			myCalculator.Push (1);
			myCalculator.Add ();
			myCalculator.Multiply ();
			Console.WriteLine (myCalculator.Result ());

			ListStack myStack2 = new ListStack ();
			Calculator myCalculator2 = new Calculator(myStack2);
			myCalculator2.Push (1);
			myCalculator2.Push (2);
			myCalculator2.Push (3);
			myCalculator2.Add ();
			myCalculator2.Multiply ();
			Console.WriteLine (myCalculator2.Result ());
		}
	}
}
