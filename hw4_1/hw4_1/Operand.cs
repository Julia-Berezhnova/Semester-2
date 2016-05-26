using System;

namespace NamespaceTree
{
    /// <summary>
    /// Class that implements INode interface,
    /// keeps some integer number.
    /// </summary>
    class Operand: INode
    {
        public int Data { get; set; }

        public Operand() {}

        public Operand(int value)
        {
            Data = value;
        }

        public void Print(ref string result)
        {
            result += Data.ToString();
        }

        public int Count() => Data;
    }
}

