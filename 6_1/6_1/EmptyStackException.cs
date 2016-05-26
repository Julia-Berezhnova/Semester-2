using System;

namespace task1
{
    /// <summary>
    /// Exception which is thrown in case
    /// Stack.Delete() is called while stack is empty
    /// </summary>
    [Serializable()]
    public class EmptyStackException : ApplicationException
    {
        public EmptyStackException() 
            : base() { }

        public EmptyStackException(string message) 
            : base(message) { }

        public EmptyStackException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected EmptyStackException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) 
            : base() { }
    }
}

