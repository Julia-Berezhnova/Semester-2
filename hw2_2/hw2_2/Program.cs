using System;

namespace List
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List myList = new List ();
			myList.AddElement (12);
			Console.WriteLine (myList.DeleteElement (12));
			Console.WriteLine (myList.DeleteElement (13));
		}
	}
}
