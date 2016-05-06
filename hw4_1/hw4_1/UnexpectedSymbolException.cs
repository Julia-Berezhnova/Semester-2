using System;

namespace NamespaceTree
{
    [Serializable()]
    public class UnexpectedSymbolException : Exception
    {
        public UnexpectedSymbolException() 
            : base() { }
        
        public UnexpectedSymbolException(string message) 
            : base(message) { }
        
        public UnexpectedSymbolException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected UnexpectedSymbolException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    } 
}

