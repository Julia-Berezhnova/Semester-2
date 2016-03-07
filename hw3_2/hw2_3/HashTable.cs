using NamespaceList;

namespace NamespaceHashTable
{
	/// <summary>
	/// Hash table.
	/// </summary>
	class HashTable
	{
		private int size;

		private List[] array;

		private IHashFunction hashFunction;

		public HashTable(int size, IHashFunction function)
		{
			this.size = size;
			this.array = new List[size];
			for (int i = 0; i < size; ++i) 
			{
				this.array[i] = new List();
			}
			this.hashFunction = function;
		}

		private int HashFunction(string element)
		{
			return this.hashFunction.Hash(this.size, element);
		}

		public void AddValue(string element)
		{
			this.array[this.hashFunction.Hash(this.size, element)].AddElement(element);
		}

		public bool DeleteValue(string element)
		{
			return this.array[this.hashFunction.Hash(this.size, element)].DeleteElement(element);
		}

		public bool Exists(string element)
		{
			return this.array[this.hashFunction.Hash(this.size, element)].IsIn(element);
		}

	}
}

