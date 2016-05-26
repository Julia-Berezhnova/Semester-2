using System;

namespace NamespaceTree
{
    /// <summary>
    /// Exception which is thrown when
    /// something in an expression is wrong
    /// (see ParseTree.ParseTree(string expression))
    /// </summary>
    [Serializable()]
    public class UnexpectedSymbolException : ApplicationException
    {
        public UnexpectedSymbolException() 
            : base() { }
        
        public UnexpectedSymbolException(string message) 
            : base(message) { }
        
        public UnexpectedSymbolException(string message, System.Exception inner) 
            : base(message, inner) { }

        protected UnexpectedSymbolException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) 
            : base() { }
    } 
}

