using System;

namespace List
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List myList = new List ();
			myList.addElement (12);
			Console.WriteLine (myList.deleteElement (12));
			Console.WriteLine (myList.deleteElement (13));
		}
	}
}
