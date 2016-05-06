using System;
using NamespaceTree;

namespace hw4_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ParseTree myTree = new ParseTree("(- (/ 100 20) (* 5 3))");
                Console.WriteLine(myTree.PrintTree());
                Console.WriteLine(myTree.CountTree());
            }
            catch(UnexpectedSymbolException e)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Exception: " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
