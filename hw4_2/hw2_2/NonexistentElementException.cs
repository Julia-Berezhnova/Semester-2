using System;

namespace List
{
    /// <summary>
    /// Exception which is thrown if user wants to delete a nonexistent element
    /// </summary>
    [Serializable()]
    public class NonexistentElementException: Exception
    {
        public NonexistentElementException()
            : base()
        {
        }

        public NonexistentElementException(string message)
            : base(message)
        {
        }

        public NonexistentElementException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected NonexistentElementException(System.Runtime.Serialization.SerializationInfo info,
                                              System.Runtime.Serialization.StreamingContext context)
            : base()
        {
        }
    }
}