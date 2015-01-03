using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathExpression;

namespace MathExpressionTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            PriorityConverter convert = new PriorityConverter(@"1+2*3");
            Assert.AreEqual("1+(2*3)", convert.Result());
        }
        [TestMethod]
        public void TestMethod2 ()
        {
            PriorityConverter convert = new PriorityConverter(@"(1+2)*3");
            Assert.AreEqual("(1+(2)*3)", convert.Result());
        }
        [TestMethod]
        public void TestMethod3()
        {
            PriorityConverter convert = new PriorityConverter(@"1+(2*3)");
            Assert.AreEqual("1+(2*3)", convert.Result());
        }
        [TestMethod]
        public void TestMethod4()
        {
            PriorityConverter convert = new PriorityConverter(@"((2+3)+4*5)+4/2");
            Assert.AreEqual("((2+3)+(4*5))+(4/2)", convert.Result());
        }

        [TestMethod]
        public void TestMethod5()
        {
            PriorityConverter convert = new PriorityConverter(@"2*2*2");
            Assert.AreEqual("(2*(2)*2)", convert.Result());
        }

        [TestMethod]
        public void TestMethod6()
        {
            PriorityConverter convert = new PriorityConverter(@"((3+8)/(2*3))");
            Assert.AreEqual("(2*(2)*2)", convert.Result());
        }
    }
}
