using System;

namespace Homework1
{
    internal static class Program
    {
        public static int Main(string[] args)
        {
            var isCorrectFormat = Parser.TryParseTwoArguments(args, 
                out var val1, out var operation, out var val2);
            if (!isCorrectFormat)
            {
                Console.WriteLine("Incorrect input format");
                return 1;
            }
            var result = Calculator.Calculate(val1, operation, val2);
            // ReSharper disable once HeapView.BoxingAllocation
            Console.WriteLine($"{args[0]} {args[1]} {args[2]} = {result}");
            return 0;
        }
    }
}