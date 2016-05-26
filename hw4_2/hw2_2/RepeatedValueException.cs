using System;

namespace List
{
    /// <summary>
    /// Exception which is thrown if user wants to add in UniqueList a value which is already in it.
    /// </summary>
    [Serializable()]
    public class RepeatedValueException: Exception
    {
        public RepeatedValueException()
            : base()
        {
        }

        public RepeatedValueException(string message)
            : base(message)
        {
        }

        public RepeatedValueException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected RepeatedValueException(System.Runtime.Serialization.SerializationInfo info,
                                         System.Runtime.Serialization.StreamingContext context)
            : base()
        {
        }
    }
}