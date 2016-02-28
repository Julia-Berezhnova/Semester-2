namespace List
{
	/// <summary>
	/// Interface of list
	/// </summary>
	interface IList
	{
		/// <summary>
		/// Adds new element to the list
		/// </summary>
		/// <param name="element">Element to add.</param>
		void AddElement (int element);

		/// <summary>
		/// Returns true if the list is empty
		/// </summary>
		/// <returns><c>true</c>, if empty is empty, <c>false</c> otherwise.</returns>
		bool IsEmpty ();

		/// <summary>
		/// Returns true if element is deleted, otherwise it's not in the list
		/// </summary>
		/// <returns><c>true</c>, if element is deleted, <c>false</c> if it's not in the list.</returns>
		/// <param name="element">Element user wants to delete.</param>
		bool DeleteElement (int element);
	}
}

