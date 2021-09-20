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
            if (operation == Operation.Plus)
                return val1 + val2;
            else if (operation == Operation.Minus)
                return val1 - val2;
            else if (operation == Operation.Division)
                return val1 / val2;
            else 
                return val1 * val2;
        }
    }
}