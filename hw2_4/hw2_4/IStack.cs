namespace Stacks
{
    /// <summary>
    /// Interface of a stack
    /// </summary>
    interface IStack
    {
        /// <summary>
        /// Returns true if stack is empty, otherwise it's false
        /// </summary>
        /// <returns><c>true</c>, if empty was ised, <c>false</c> otherwise.</returns>
        bool IsEmpty();

        /// <summary>
        /// Returns true if element is added, and false if stack is going to get overloaded
        /// </summary>
        /// <param name="element">Element needed to be added to the stack.</param>
        void Push(int element);

        /// <summary>
        /// returns the last added element, deletes it from the stack
        /// WARNING: one should check if the stack is not empty before this operation
        /// </summary>
        int Pop();

        /// <summary>
        /// Returns value from the top of the stack
        /// WARNING: one should check if the stack is not empty before this operation
        /// </summary>
        int Top();
    }
}

