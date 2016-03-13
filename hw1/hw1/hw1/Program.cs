using System;

namespace hm1_1
{
	class MainClass
	{
		private static uint Factorial(uint number) // method that allows to count factorial (number)
		{
			if (number == 0 || number == 1) 
			{
				return 1;
			}
			return number * Factorial (number - 1);
		}

		public static void Main (string[] args) 
		{
			Console.WriteLine ("Enter a positive integer number:");
			uint number = 0;
			string someString = Console.ReadLine();
			if (UInt32.TryParse (someString, out number)) 
			{
				Console.WriteLine (Factorial (number));
			} 
			else 
			{
				Console.WriteLine ("Incorrect input");
			}
		}

	}
}

