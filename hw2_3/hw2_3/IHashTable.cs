namespace NamespaceIHashTable
{
	interface IHashTable
	{
		// adds a new element to the hash table
		void addValue(string element);

		// returns true if element is deleted, otherwise there is no such element
		bool deleteValue(string element);

		// returns true if element is in the hash table, and false if it is not
		bool exists(string element);
	}
}

