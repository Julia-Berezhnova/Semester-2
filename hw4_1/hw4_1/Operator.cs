namespace NamespaceTree
{
    /// <summary>
    /// Class that implements INode interface 
    /// and has a left and a right node.
    /// This is a base class for AdditionOperator, DivisionOperator,
    /// MultiplicationOperator and SubtractionOperator classes
    /// </summary>
    class Operator: INode
    {
        public INode LeftNode { get; set; }

        public INode RightNode { get; set; }

        public virtual void Print(ref string result) { }

        public virtual int Count() => 0;
    }
}

