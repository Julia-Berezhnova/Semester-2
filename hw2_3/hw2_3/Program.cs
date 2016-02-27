using System;
using NamespaceHashTable;

namespace hw2_3
{
	class Program
	{
		public static void Main (string[] args)
		{
			HashTable myHashTable = new HashTable ();
			bool goOn = true;

			while (goOn) 
			{
				Console.WriteLine ("Choose an action:");
				Console.WriteLine ("1 - check if there is a specific element");
				Console.WriteLine ("2 - add a new element");
				Console.WriteLine ("3 - delete a specific element");
				Console.WriteLine ("4 - exit the program");
				int choice = 0;
				if (Int32.TryParse (Console.ReadLine (), out choice)) 
				{
					Console.WriteLine ("Enter a string");
					switch (choice) 
					{
					case 1:
						Console.WriteLine(myHashTable.exists (Console.ReadLine ()));
						break;
					case 2:
						myHashTable.addValue (Console.ReadLine ());
						break;
					case 3:
						if (myHashTable.deleteValue (Console.ReadLine ())) 
						{
							Console.WriteLine ("Element is deleted");
						}
						else
						{
							Console.WriteLine ("There is no such element");
						}
						break;
					case 4:
						goOn = false;
						break;
					default:
						Console.WriteLine ("Incorrect input. Please try again");
						break;
					}
				}
			}
		}
	}
}
