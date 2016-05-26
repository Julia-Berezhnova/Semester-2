namespace NamespaceTree
{
    /// <summary>
    /// Abstract node interface in the parse tree
    /// Can be printed and counted
    /// </summary>
    interface INode
    {
        void Print(ref string result);

        int Count();
    }
}

