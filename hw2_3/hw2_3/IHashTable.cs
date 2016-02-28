namespace NamespaceHashTable
{
	/// <summary>
	/// Interface of hash table.
	/// </summary>
	interface IHashTable
	{
		// adds a new element to the hash table
		void AddValue(string element);

		// returns true if element is deleted, otherwise there is no such element
		bool DeleteValue(string element);

		// returns true if element is in the hash table, and false if it is not
		bool Exists(string element);
	}
}

