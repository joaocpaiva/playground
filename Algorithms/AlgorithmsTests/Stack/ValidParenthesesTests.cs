using Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Stack
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void TestValidParentheses()
        {
            var validParentheses = new ValidParentheses();
            Assert.IsTrue(validParentheses.IsValid(""));
            Assert.IsTrue(validParentheses.IsValid("()"));
            Assert.IsTrue(validParentheses.IsValid("()[]{}"));
            Assert.IsFalse(validParentheses.IsValid("(]"));
            Assert.IsFalse(validParentheses.IsValid("([)]"));
            Assert.IsTrue(validParentheses.IsValid("{[]}"));
        }
    }
}
