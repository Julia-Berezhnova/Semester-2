using System;

namespace exam
{
    [Serializable()]
    /// <summary>
    /// Empty queue exception which is thrown when Dequeue() is called for an empty queue.
    /// </summary>
    public class EmptyQueueException : System.Exception
    {
        public EmptyQueueException() 
            : base() { }

        public EmptyQueueException(string message) 
            : base(message) { }

        public EmptyQueueException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected EmptyQueueException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}

