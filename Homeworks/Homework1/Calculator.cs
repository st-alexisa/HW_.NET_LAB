using System;

namespace Homework1
{
    public static class Calculator
    {
        public enum Operation
        {
            Plus = '+',
            Minus = '-',
            Multiplication = '*',
            Division = '/'
        }

        public static int Calculate(int val1, Operation operation, int val2)
        {
            var result = operation switch
            {
                Operation.Plus => val1 + val2,
                Operation.Minus => val1 - val2,
                Operation.Multiplication => val1 * val2,
                Operation.Division => val1 / val2,
                _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null)
            };
            return result;
        }
    }
}