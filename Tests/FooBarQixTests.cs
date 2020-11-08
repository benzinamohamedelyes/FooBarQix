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
            StringBuilder testString = new StringBuilder("3");
            Assert.AreEqual("FooFoo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3");

            testString = new StringBuilder("6");
            Assert.AreEqual("Foo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3");
        }
        [TestMethod()]
        public void ComputeCanReplaceThreeByFoo()
        {
            StringBuilder testString = new StringBuilder("3");
            Assert.AreEqual("FooFoo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3 And Contains 3");

            testString = new StringBuilder("13");
            Assert.AreEqual("Foo", Program.Compute(testString.ToString()), $"{testString.ToString()} Contains 3");

            testString = new StringBuilder("33");
            Assert.AreEqual("FooFooFoo", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 3 And Contains 3 two Times");
        }
        [TestMethod()]
        public void ComputeCanReplaceFiveByBar()
        {
            StringBuilder testString = new StringBuilder("5");
            Assert.AreEqual("BarBar", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 5");

            testString = new StringBuilder("55");
            Assert.AreEqual("BarBarBar", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 5 And Contains 5 two Times");
        }
        [TestMethod]
        public void ComputeCanDevideByFive()
        {
            StringBuilder testString = new StringBuilder("5");
            Assert.AreEqual("BarBar", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 5");

            testString = new StringBuilder("10");
            Assert.AreEqual("Bar", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 5");
        }
        [TestMethod]
        public void ComputeCanDevideBySeven()
        {
            StringBuilder testString = new StringBuilder("7");
            Assert.AreEqual("QixQix", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 7");

            testString = new StringBuilder("14");
            Assert.AreEqual("Qix", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 7");
        }
        [TestMethod()]
        public void ComputeCanReplaceSevenByQix()
        {
            StringBuilder testString = new StringBuilder("7");
            Assert.AreEqual("QixQix", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 7");

            testString = new StringBuilder("17");
            Assert.AreEqual("Qix", Program.Compute(testString.ToString()), $"{testString.ToString()} Contains 7");

            testString = new StringBuilder("77");
            Assert.AreEqual("QixQixQix", Program.Compute(testString.ToString()), $"{testString.ToString()} Is Divisible By 7 And Contains 7 two Times");
        }
        [TestMethod()]
        public void ComputeCanDivideAndReplaceMultipleInteger()
        {
            StringBuilder testString = new StringBuilder("1");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"Should Return {testString.ToString()}");

            testString = new StringBuilder("2");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"Should Return {testString.ToString()}");

            testString = new StringBuilder("4");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"Should Return {testString.ToString()}");

            testString = new StringBuilder("8");
            Assert.AreEqual(testString.ToString(), Program.Compute(testString.ToString()), $"Should Return {testString.ToString()}");

            testString = new StringBuilder("15");
            Assert.AreEqual("FooBarBar", Program.Compute(testString.ToString()), "Should Return FooBarBar: Divisible By 3, Divisible By 5, Contains 5");

            testString = new StringBuilder("21");
            Assert.AreEqual("FooQix", Program.Compute(testString.ToString()), "Should Return FooQix: Divisible By 7, Divisible By 3");

            testString = new StringBuilder("105");
            Assert.AreEqual("FooBarQixBar", Program.Compute(testString.ToString()), "Should Return FooBarQixBar: Divisible By 3, Divisible By 5, Divisible By 7, Contains 5");

            testString = new StringBuilder("7553");
            Assert.AreEqual("QixQixBarBarFoo", Program.Compute(testString.ToString()), "Should Return QixQixBarBarFoo: Divisible By 7, Contains 7, Contains 5 two times, Contains 3");
        }

    }
}
