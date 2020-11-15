using FluentAssertions;
using FooBarQix;
using System;
using System.Text;
using Xunit;

namespace FooBarQixTests
{
    public class Tests
    {
        [Fact]
        public void ComputeShouldOnlyAcceptInts()
        {
            StringBuilder testString = new StringBuilder("A12");
            var result = Program.Compute(testString.ToString());
            result.Should().Be($"{testString} is not a valid Integer");

            testString = new StringBuilder("1");
            result = Program.Compute(testString.ToString());
            result.Should().Be(testString.ToString());
            
            testString = new StringBuilder("1.5");
            result = Program.Compute(testString.ToString());
            result.Should().Be($"{testString} is not a valid Integer");
        }
        [Fact]
        public void ComputeCanDevideByThree()
        {
            StringBuilder testString = new StringBuilder("3");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("FooFoo");

            testString = new StringBuilder("6");
            result = Program.Compute(testString.ToString());
            result.Should().Be("Foo");
        }
        [Fact]
        public void ComputeCanReplaceThreeByFoo()
        {
            StringBuilder testString = new StringBuilder("3");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("FooFoo");

            testString = new StringBuilder("13");
            result = Program.Compute(testString.ToString());
            result.Should().Be("Foo");

            testString = new StringBuilder("33");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooFooFoo");
        }
        [Fact]
        public void ComputeCanReplaceFiveByBar()
        {
            StringBuilder testString = new StringBuilder("5");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("BarBar");

            testString = new StringBuilder("55");
            result = Program.Compute(testString.ToString());
            result.Should().Be("BarBarBar");
        }
        [Fact]
        public void ComputeCanDevideByFive()
        {
            StringBuilder testString = new StringBuilder("5");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("BarBar");

            testString = new StringBuilder("10");
            result = Program.Compute(testString.ToString());
            result.Should().Be("Bar*");
        }
        [Fact]
        public void ComputeCanDevideBySeven()
        {
            StringBuilder testString = new StringBuilder("7");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("QixQix");

            testString = new StringBuilder("14");
            result = Program.Compute(testString.ToString());
            result.Should().Be("Qix");
        }
        [Fact]
        public void ComputeCanReplaceSevenByQix()
        {
            StringBuilder testString = new StringBuilder("7");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("QixQix");

            testString = new StringBuilder("17");
            result = Program.Compute(testString.ToString());
            result.Should().Be("Qix");

            testString = new StringBuilder("77");
            result = Program.Compute(testString.ToString());
            result.Should().Be("QixQixQix");
        }
        [Fact]
        public void ComputeCanReplaceZero()
        {
            StringBuilder testString = new StringBuilder("0");
            var result = Program.Compute(testString.ToString());
            result.Should().Be("FooBarQix*");
            
            testString = new StringBuilder("101");
            result = Program.Compute(testString.ToString());
            result.Should().Be("1*1");
        }
        [Fact]
        public void ComputeCanDivideAndReplaceMultipleInteger()
        {
            StringBuilder testString = new StringBuilder("1");
            var result = Program.Compute(testString.ToString());
            result.Should().Be(testString.ToString());

            testString = new StringBuilder("2");
            result = Program.Compute(testString.ToString());
            result.Should().Be(testString.ToString());

            testString = new StringBuilder("4");
            result = Program.Compute(testString.ToString());
            result.Should().Be(testString.ToString());

            testString = new StringBuilder("8");
            result = Program.Compute(testString.ToString());
            result.Should().Be(testString.ToString());

            testString = new StringBuilder("15");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooBarBar");

            testString = new StringBuilder("21");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooQix");

            testString = new StringBuilder("105");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooBarQix*Bar");

            testString = new StringBuilder("7553");
            result = Program.Compute(testString.ToString());
            result.Should().Be("QixQixBarBarFoo");

            testString = new StringBuilder("303");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooFoo*Foo");

            testString = new StringBuilder("10101");
            result = Program.Compute(testString.ToString());
            result.Should().Be("FooQix**");
        }
    }
}
