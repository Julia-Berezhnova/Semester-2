using System;

namespace NamespaceTree
{
    /// <summary>
    /// Class AdditionOperator inherited by class Operator
    /// </summary>
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

