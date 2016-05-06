namespace NamespaceTree
{
    class Operator: INode
    {
        public INode LeftNode { get; set; }

        public INode RightNode { get; set; }

        public virtual void Print(ref string result) { }

        public virtual int Count() => 0;
    }
}

