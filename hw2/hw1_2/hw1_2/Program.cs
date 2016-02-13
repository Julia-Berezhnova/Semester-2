using System;

namespace hm1_2
{
	class MainClass
	{
		private static uint Fibonacchi(uint number)
		{
			if (number == 0 || number == 1) 
			{
				return 1;
			}
			return Fibonacchi(number - 1) + Fibonacchi(number - 2);
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a positive integer number:");
			uint number;
			string someString = Console.ReadLine();
			if (UInt32.TryParse (someString, out number)) 
			{
				Console.WriteLine (Fibonacchi (number));
			} 
			else 
			{
				Console.WriteLine ("Incorrect input");
			}
		}
	}
}

