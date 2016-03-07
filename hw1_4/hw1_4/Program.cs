using System;

namespace hw1_4
{
	class MainClass
	{
		private static void GenerateAndPrintArray(int[,] array)
		{
			Random rnd = new Random();
			Console.WriteLine("Array: ");
			for (int i = 0; i < array.GetLength(0); ++i) 
			{
				for (int j = 0; j < array.GetLength(1); ++j) 
				{
					array[i, j] = rnd.Next(0, 10);
					Console.Write(array[i, j]);			
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}

		private static void PrintArray(int[,] array)
		{
			if (array.GetLength(0) != array.GetLength(1)) 
			{
				Console.WriteLine("Incorrect input. The matrix must be square");
			}
			int i = array.GetLength(0) / 2;
			int j = array.GetLength(1) / 2;
			int step = 1;
			while (true) 
			{
				for (int l = 0; l < step; ++l) 
				{
					Console.Write(array[i, j]);
					Console.Write(" ");
					--j;
				}
				if (j == -1) 
				{
					return;
				}
				for (int l = 0; l < step; ++l) 
				{
					Console.Write(array[i, j]);
					Console.Write(" ");
					++i;
				}
				++step;
				for (int l = 0; l < step; ++l) 
				{
					Console.Write(array[i, j]);
					Console.Write(" ");
					++j;
				}
				for (int l = 0; l < step; ++l) 
				{
					Console.Write(array[i, j]);
					Console.Write(" ");
					--i;
				}
				++step;
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine("Enter a dimension (odd number):");
			uint dimension;
			if (!UInt32.TryParse(Console.ReadLine(), out dimension))
			{
				Console.WriteLine("Incorrect input");
				return;
			}
			if (dimension % 2 == 0) 
			{
				Console.WriteLine("Incorrect input");
				return;
			}
			int[,] array = new int[dimension, dimension];
			GenerateAndPrintArray(array);
			Console.WriteLine("Answer:");
			PrintArray(array);
		}
	}
}
