using System;

namespace task1
{
    /// <summary>
    /// Exception which is thrown in case
    /// List.Delete(T element) is called while list is empty
    /// </summary>
    [Serializable()]
    public class EmptyListException : ApplicationException
    {
        public EmptyListException() 
            : base() { }

        public EmptyListException(string message) 
            : base(message) { }

        public EmptyListException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected EmptyListException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}

