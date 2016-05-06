using System;

namespace NamespaceTree
{
    class AdditionOperator: Operator
    {
        public override void Print(ref string result)
        {
            result += "(+ ";
            if (LeftNode != null)
            {
                LeftNode.Print(ref result);
            }
            result += " ";
            if (RightNode != null)
            {
                RightNode.Print(ref result);
            }
            result += ") ";
        }

        public override int Count() => LeftNode.Count() + RightNode.Count();
    }
}

