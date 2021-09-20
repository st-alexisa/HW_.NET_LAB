using System;
using Xunit;

namespace Homework1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, Calculator.Operation.Plus, 1, 2)]
        public void IsOnePlusOneEqualsTwo(int val1, Calculator.Operation operation, int val2, int expected)
        {
            var actual = Calculator.Calculate(val1, operation, val2);
            Assert.Equal(expected, actual);
        }
    }
}