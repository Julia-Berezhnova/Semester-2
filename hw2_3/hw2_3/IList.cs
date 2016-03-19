namespace NamespaceList
{
    /// <summary>
    /// Interface of list.
    /// </summary>
    interface IList
    {
        /// <summary>
        /// Adds new element to the list
        /// </summary>
        /// <param name="element">Element user wants to add to the list.</param>
        void AddElement(string element);

        /// <summary>
        /// Returns true if the list is empty
        /// </summary>
        /// <returns><c>true</c>, if empty was ised, <c>false</c> otherwise.</returns>
        bool IsEmpty();

        /// <summary>
        /// Returns true if element is deleted, otherwise it's not in the list
        /// </summary>
        /// <returns><c>true</c>, if element was deleted, <c>false</c> otherwise.</returns>
        /// <param name="element">Element user wants to delete from the list.</param>
        bool DeleteElement(string element);

        /// <summary>
        /// Returns true if there is the given element in the list, and false if there is no
        /// </summary>
        /// <returns><c>true</c>, if in was ised, <c>false</c> otherwise.</returns>
        /// <param name="element">Element to ckeck.</param>
        bool IsIn(string element);
    }
}

