using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Homework1.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 10, 11)]
        [InlineData(0, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 6, 1)]
        [InlineData(-5, -5, -10)]
        public void DoesSumReturnsExpected(int val1, int val2, int expected)
        {
            var actual = Calculator.Calculate(val1, Calculator.Operation.Plus, val2);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(11, 10, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 6, -5)]
        [InlineData(-5, -5, 0)]
        [InlineData(-5, 5, -10)]
        public void DoesMinusReturnsExpected(int val1, int val2, int expected)
        {
            var actual = Calculator.Calculate(val1, Calculator.Operation.Minus, val2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        public void DoesDivisionReturnsExpected(int val1, int val2, int expected)
        {
            var actual = Calculator.Calculate(val1, Calculator.Operation.Division, val2);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 2, 4)]
        public void DoesMultiplicationReturnsExpected(int val1, int val2, int expected)
        {
            var actual = Calculator.Calculate(val1, Calculator.Operation.Multiplication, val2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( "1", "+", "2", true)]
        [InlineData( "2", "-", "1", true)]
        [InlineData( "2", "/", "1", true)]
        [InlineData( "2", "*", "1", true)]
        [InlineData( "2", ".", "1", false)]
        [InlineData( "l", "*", "1", false)]
        [InlineData( "2", "*", "g", false)]
        public void DoesParseTwoArgumentsAndOperationCorrectly(string val1, 
            string op, string val2, bool expected)
        {
            var args = new[] {val1, op, val2};
            Assert.Equal(Parser.TryParseTwoArguments(args, out _, out _, out _), expected);
        }
    }
}