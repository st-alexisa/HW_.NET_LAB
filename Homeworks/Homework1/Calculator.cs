using System;

namespace Homework1
{
    public static class Calculator
    {
        public enum ValidOperations
        {
            Plus = '+',
            Minus = '-',
            Multiplication = '*',
            Division = '/'
        }

        public static int Calculate(int val1, ValidOperations operation, int val2)
        {
            var result = operation switch
            {
                ValidOperations.Plus => val1 + val2,
                ValidOperations.Minus => val1 - val2,
                ValidOperations.Multiplication => val1 * val2,
                ValidOperations.Division => val1 / val2,
                _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null)
            };
            return result;
        }
    }
}