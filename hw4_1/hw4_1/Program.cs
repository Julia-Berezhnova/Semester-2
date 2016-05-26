using System;
using NamespaceTree;

namespace hw4_1
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
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
