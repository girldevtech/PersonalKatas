using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Range
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void RangeHasValidStartAndEndDelimitersTest()
        {
            Range r = new Range();
            string input = "[2,6)";

            bool validDelimiters = r.ValidInput(input);

            Assert.That(validDelimiters, Is.True);
        }

        [Test]
        public void InvalidStartAndEndDelimitersFailsTest()
        {
            Range r = new Range();
            string input = "{2,6*";

            bool validDelimiters = r.ValidInput(input);

            Assert.That(validDelimiters, Is.False);
        }

        [Test]
        public void ValidRangeContainsMinimumOfTwoIntegersTest()
        {
            Range r = new Range();
            string input = "(a,6)";

            bool validInput = r.ValidInput(input);

            Assert.That(validInput, Is.True);
        }

        [Test]
        public void CanCheckIfIntegerRangeContainsListTest()
        {
            Range r = new Range();
            r.InputRange = "[2,6)";
            List<int> integerList = new List<int>() { 2, 4 };

            bool listInRange = r.ContainsList(integerList);

            Assert.That(listInRange, Is.True);
        }
    }
}
