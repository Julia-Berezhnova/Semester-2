using NUnit.Framework;
using System;
using NamespaceTree;

namespace hw4_1
{
    /// <summary>
    /// ParsTree class tests.
    /// </summary>
    [TestFixture()]
    public class ParseTreeTests
    {
        [Test()]
        public void SimplePrintTreeTest()
        {
            ParseTree myTree = new ParseTree("(* 10 5)");
            Assert.AreEqual("(* 10 5) ", myTree.PrintTree());
        }

        [Test()]
        public void SimpleCountTreeTest()
        {
            ParseTree myTree = new ParseTree("(* 10 5)");
            Assert.AreEqual(50, myTree.CountTree());
        }

        [Test()]
        public void ThreeCalculationsPrintTreeTest()
        {
            ParseTree myTree = new ParseTree("(/ (* 10 5) (+ 2 3))");
            Assert.AreEqual("(/ (* 10 5)  (+ 2 3) ) ", myTree.PrintTree());
        }

        [Test()]
        public void ThreeCalculationsCountTreeTest()
        {
            ParseTree myTree = new ParseTree("(/ (* 10 5) (+ 2 3))");
            Assert.AreEqual(10, myTree.CountTree());
        }

        [Test()]
        public void SevenCalculationsPrintTreeTest()
        {
            ParseTree myTree = new ParseTree("(- (* (- 12 2) (* 5 2)) (/ (* 10 5) (+ 2 3)))");
            Assert.AreEqual("(- (* (- 12 2)  (* 5 2) )  (/ (* 10 5)  (+ 2 3) ) ) ", myTree.PrintTree());
        }

        [Test()]
        public void SevenCalculationsCountTreeTest()
        {
            ParseTree myTree = new ParseTree("(- (* (- 12 2) (* 5 2)) (/ (* 10 5) (+ 2 3)))");
            Assert.AreEqual(90, myTree.CountTree());
        }

        [Test()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceptionTest()
        {
            ParseTree myTree = new ParseTree("(/ 1 0)");
            myTree.CountTree();
        }

        [Test()]
        [ExpectedException(typeof(UnexpectedSymbolException))]
        public void UnexpectedSymbolExceptionTest()
        {
            ParseTree myTree = new ParseTree("(/ y10 5)");
            myTree.CountTree();
        }

        [Test()]
        [ExpectedException(typeof(UnexpectedSymbolException))]
        public void AnotherUnexpectedSymbolExceptionTest()
        {
            ParseTree myTree = new ParseTree("(- 10 5) (");
            myTree.CountTree();
        }
    }
}

