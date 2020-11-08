using FooBarQix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;
using System.Text;

namespace FooBarQix.Tests
{
    [TestClass()]
    public class FooBarQixTests
    {
        [TestMethod()]
        public void ComputeShouldOnlyAcceptInts()
        {
            StringBuilder testString = new StringBuilder("A12");
            Assert.AreEqual($"{testString} is not a valid number", Program.Compute(testString.ToString()), "Should Only Accept Valid Integer");
            testString = new StringBuilder("12");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), "Should Return The Same Valid Integer String");

        }
    }
}
