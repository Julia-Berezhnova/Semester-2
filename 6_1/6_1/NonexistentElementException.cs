using System;

namespace task1
{
    /// <summary>
    /// Exception which is thrown in case
    /// List.Delete(T element) is called while list doesn't contain the element
    /// </summary>
    [Serializable()]
    public class NonexistentElementException : ApplicationException
    {
        public NonexistentElementException() 
            : base() { }

        public NonexistentElementException(string message) 
            : base(message) { }

        public NonexistentElementException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected NonexistentElementException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}

