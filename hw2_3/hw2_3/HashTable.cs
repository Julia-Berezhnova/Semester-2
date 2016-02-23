using NamespaceIHashTable;
using NamespaceList;

namespace NamespaceHashTable
{
	class HashTable: IHashTable
	{
		private const int arraySize = 100;
		private List[] array = new List[arraySize];

		public HashTable()
		{
			for (int i = 0; i < arraySize; ++i) 
			{
				this.array[i] = new List();
			}
		}

		private int hashFunction(string element)
		{
			int result = 0;
			for (int i = 0; i < element.Length; ++i) 
			{
				result = result + element [i] - 'a' + 1;
			}
			return result / arraySize;
		}

		public void addValue(string element)
		{
			this.array [hashFunction (element)].addElement(element);
		}

		public bool deleteValue(string element)
		{
			return this.array [hashFunction (element)].deleteElement (element);
		}

		public bool exists(string element)
		{
			return this.array [hashFunction (element)].isIn (element);
		}

	}
}

