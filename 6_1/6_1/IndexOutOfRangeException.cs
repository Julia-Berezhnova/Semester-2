using System;

namespace _1
{
    [Serializable()]
    public class IndexOutOfRangeException : Exception
    {
        public IndexOutOfRangeException() 
            : base() { }

        public IndexOutOfRangeException(string message) 
            : base(message) { }

        public IndexOutOfRangeException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected IndexOutOfRangeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}

