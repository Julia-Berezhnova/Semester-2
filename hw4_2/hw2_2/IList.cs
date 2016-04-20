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
        void AddElement(int element);

        /// <summary>
        /// Returns true if the list is empty
        /// </summary>
        /// <returns><c>true</c>, if empty is empty, <c>false</c> otherwise.</returns>
        bool IsEmpty();

        /// <summary>
        /// Deletes an element with given value.
        /// </summary>
        /// <param name="element">Value to delete.</param>
        void DeleteElement(int element);

        /// <summary>
        /// Checks if list contains the element.
        /// </summary>
        /// <returns><c>true</c>, if element was found, <c>false</c> otherwise.</returns>
        /// <param name="element">Element to check.</param>
        bool Contains(int element);
    }
}

