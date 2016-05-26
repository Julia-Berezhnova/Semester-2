using System;

namespace NamespaceTree
{
    /// <summary>
    /// Class DivisionOperator inherited by class Operator
    /// </summary>
    class SubtractionOperator: Operator
    {
        public override void Print(ref string result)
        {
            result += "(- ";
           
            LeftNode.Print(ref result);
            
            result += " ";

            RightNode.Print(ref result);

            result += ") ";
        }

        public override int Count() => LeftNode.Count() - RightNode.Count();
    }
}

