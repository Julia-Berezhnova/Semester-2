using System;

namespace List
{
    /// <summary>
    /// Exception which is thrown if list element with given value is not found in the list
    /// </summary>
    [Serializable()]
    public class ValueNotFoundException: Exception
    {
        public ValueNotFoundException()
            : base() { }

        public ValueNotFoundException(string message) 
            : base(message) { }

        public ValueNotFoundException(string message, Exception inner) 
            : base(message, inner) { }

        protected ValueNotFoundException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}