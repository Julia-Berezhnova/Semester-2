using NUnit.Framework;
using Stacks;
using System;

namespace hw2_4
{
	[TestFixture ()]
	public class CalculatorTest
	{
		[SetUp ()]
		public void Generate_ArrayStackCalc ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			Assert.AreEqual (false, myCalculator.Result ());
		}

		[Test ()]
		public void Generate_ListStackCalc ()
		{
			ListStack myStack = new ListStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			Assert.AreEqual (false, myCalculator.Result ());
		}

		[Test ()]
		public void ArrayStack_Caluculator_Add ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (3);
			myCalculator.Push (2);
			myCalculator.Add ();
			Assert.AreEqual(5, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_Caluculator_Divide ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (81);
			myCalculator.Push (3);
			myCalculator.Divide ();
			Assert.AreEqual(27, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_Caluculator_Subtract ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (8);
			myCalculator.Push (3);
			myCalculator.Subtract ();
				Assert.AreEqual(5, myCalculator.Result());
		}

		[Test ()]
		public void ArrayStack_Caluculator_Multiply ()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalculator = new StackCalculator(myStack);
			myCalculator.Push (8);
			myCalculator.Push (3);
			myCalculator.Multiply ();
			Assert.AreEqual(24, myCalculator.Result());
		}

		[Test ()]
		public void ListStack_Caluculator_Add ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (1);
			myCalculator2.Push (2);
			myCalculator2.Add ();
			Assert.AreEqual (3, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_Caluculator_Subtract ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (72);
			myCalculator2.Push (60);
			myCalculator2.Subtract ();
			Assert.AreEqual (12, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_Caluculator_Divide ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (30);
			myCalculator2.Push (2);
			myCalculator2.Divide ();
			Assert.AreEqual (15, myCalculator2.Result ());
		}

		[Test ()]
		public void ListStack_Caluculator_Multiply ()
		{
			ListStack myStack2 = new ListStack ();
			StackCalculator myCalculator2 = new StackCalculator (myStack2);
			myCalculator2.Push (30);
			myCalculator2.Push (2);
			myCalculator2.Multiply ();
			Assert.AreEqual (60, myCalculator2.Result ());
		}

		[Test ()]
		public void LastTest_ListStackCalc()
		{
			ListStack myStack = new ListStack ();
			StackCalculator myCalc = new StackCalculator (myStack);
			myCalc.Push (int.MaxValue);
			myCalc.Push (int.MinValue);
			myCalc.Subtract ();
			myCalc.Push (12);
			myCalc.Multiply ();
			Assert.AreEqual (-12, myCalc.Result ());
		}

		[TearDown ()]
		public void LastTest_ArrayStackCalc()
		{
			ArrayStack myStack = new ArrayStack ();
			StackCalculator myCalc = new StackCalculator (myStack);
			myCalc.Push (int.MaxValue);
			myCalc.Push (int.MinValue);
			myCalc.Subtract ();
			myCalc.Push (12);
			myCalc.Multiply ();
			Assert.AreEqual (-12, myCalc.Result ());
		}
	}
}

