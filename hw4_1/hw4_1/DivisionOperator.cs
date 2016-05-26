using System;

namespace NamespaceTree
{
    /// <summary>
    /// Class DivisionOperator inherited by class Operator
    /// </summary>
    class DivisionOperator: Operator
    {
        public override void Print(ref string result)
        {
            result += "(/ ";
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

        public override int Count()
        {
            if (RightNode.Count() != 0)
            {
                return LeftNode.Count() / RightNode.Count();
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
    }
}

