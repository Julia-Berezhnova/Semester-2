﻿using System;

namespace List
{
	class MainClass
	{
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			List myList = new List();
			myList.AddElement(12);
			Console.WriteLine(myList.DeleteElement(12));
			Console.WriteLine(myList.DeleteElement(13));
		}
	}
}
