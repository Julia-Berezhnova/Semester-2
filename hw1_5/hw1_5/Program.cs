using System;

namespace hw1_5
{
	class MainClass
	{
		private static void GenerateArray(int[,] array)
		{
			Random rnd = new Random ();
			for (int i = 0; i < array.GetLength (0); ++i) 
			{
				for (int j = 0; j < array.GetLength (1); ++j) 
				{
					array [i, j] = rnd.Next (0, 10);
				}
			}
		}
		private static void PrintArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength (0); ++i) 
			{
				for (int j = 0; j < array.GetLength (1); ++j) 
				{
					Console.Write (array [i, j]);			
					Console.Write (" ");
				}
				Console.WriteLine ();
			}
		}
		private static void InsertationSort(int[,] array)
		{
			for (int i = 1; i < array.GetLength(1); ++i)
			{
				int[] keyColumn = new int[array.GetLength(0)];
				for (int l = 0; l < array.GetLength(0); ++l)
				{
					keyColumn [l] = array [l, i];
				}
				int j = i;
				while (j > 0 && keyColumn[0] < array[0,j - 1])
				{
					for (int l = 0; l < array.GetLength(0); ++l)
					{
						array[l,j] = array[l,j - 1];
					}
					j--;
				}
				for (int l = 0; l < array.GetLength (0); ++l) 
				{
					array [l, j] = keyColumn [l];
				}
			}
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter dimensions:");
			uint dimension1;
			uint dimension2;
			if (!UInt32.TryParse (Console.ReadLine (), out dimension1) || !UInt32.TryParse (Console.ReadLine (), out dimension2))
			{
				Console.WriteLine ("Incorrect input");
				return;
			}
			int[,] array = new int[dimension1, dimension2];
			GenerateArray (array);
			Console.WriteLine ("Array:");
			PrintArray (array);
			InsertationSort (array);
			Console.WriteLine ("Sorted-columns array:");
			PrintArray (array);
		}
	}
}
