using System;

namespace List
{
    /// <summary>
    /// Exception which is thrown if user wants to delete an element from empty list
    /// </summary>
    [Serializable()]
    public class EmptyListException: Exception
    {
        public EmptyListException()
            : base() { }

        public EmptyListException(string message) 
            : base(message) { }

        public EmptyListException(string message, Exception inner) 
            : base(message, inner) { }

        protected EmptyListException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}