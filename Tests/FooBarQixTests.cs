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
            Assert.AreEqual($"{testString} is not a valid Integer", Program.Compute(testString.ToString()), "Should Only Accept Valid Integer");
            testString = new StringBuilder("1");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), "Should Return The Same Valid Integer String");
            testString = new StringBuilder("1.5");
            Assert.AreEqual($"{testString} is not a valid Integer", Program.Compute(testString.ToString()), "Should Return The Same Valid Integer String");

        }
        [TestMethod()]
        public void ComputeCanDevideByThree()
        {
            StringBuilder testString = new StringBuilder("0");
            Assert.AreEqual("Foo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3");

            testString = new StringBuilder("1");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"{testString.ToString()} Can Not Be Devided By 3");

            testString = new StringBuilder("2");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"{testString.ToString()} Can Not Be Devided By 3");

            testString = new StringBuilder("3");
            Assert.AreEqual("Foo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3");

            testString = new StringBuilder("6");
            Assert.AreEqual("Foo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3");

        }
    }
}
