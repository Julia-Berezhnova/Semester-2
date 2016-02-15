using System;

namespace hw1_3
{
	class MainClass
	{
		private static void InsertationSort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int key = array[i];
				int j = i;
				while (j > 0 && key < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = key;
			}
		}
		public static void Main (string[] args)
		{
			string[] someString = Console.ReadLine().Split(' ');
			int[] numbers = new int[someString.Length];
			for (int i = 0; i < someString.Length; ++i) 
			{
				int number;
				if (Int32.TryParse(someString[i],out number))
				{
					numbers [i] = number;
				}
				else
				{
					Console.WriteLine("Incorrect input");
					return;
				}
			}
			InsertationSort (numbers);
			for (int i = 0; i < numbers.Length; ++i)
			{
				Console.Write(numbers[i]);
				Console.Write (" ");
			}
		}
	}
}
