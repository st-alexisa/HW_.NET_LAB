using System;

namespace Homework1
{
    public static class Parser
    {
        public static bool TryParseTwoArguments(string[] args, out int val1, 
            out Calculator.Operation operation, out int val2)
        {
            var isVal1Int = int.TryParse(args[0], out val1);
            var isVal2Int = int.TryParse(args[2], out val2);
            switch (args[1])
            {
                case "+": operation = Calculator.Operation.Plus; break;
                case "-": operation = Calculator.Operation.Minus; break;
                case "*": operation = Calculator.Operation.Multiplication; break;
                case "/": operation = Calculator.Operation.Division; break;
                default:
                    Console.WriteLine($"Wrong operation: {args[1]}");
                    operation = (Calculator.Operation) 0;
                    return false;
            }
            if (!isVal1Int)
            {
                Console.WriteLine($"Wrong first argument: {args[0]}");
                return false;
            }
            if (!isVal2Int)
            {
                Console.WriteLine($"Wrong second argument: {args[2]}");
                return false;
            }
            return true;
        }
    }
}