namespace NamespaceHashTable
{
	/// <summary>
	/// Interface of a hash function
	/// </summary>
	public interface IHashFunction
	{
		/// <summary>
		/// Returns a hash of a string 
		/// </summary>
		/// <returns><c>true</c> if this instance hash size element; otherwise, <c>false</c>.</returns>
		/// <param name="size">Size of hash table.</param>
		/// <param name="element">Element to hash.</param>
		int Hash (int size, string element);
	}
}

