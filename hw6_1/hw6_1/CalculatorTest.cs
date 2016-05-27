using NUnit.Framework;
using System;

namespace hw6_1
{
    [TestFixture()]
    public class CalculatorTest
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(-9, Calculator.Calculate("-1-8"));
        }
    }
}

