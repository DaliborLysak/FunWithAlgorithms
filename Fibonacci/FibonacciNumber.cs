using System;

namespace Fibonacci
{
    public static class FibonacciNumber
    {
        public static int Execute(int number, bool normalRecursion = false)
        {
            return normalRecursion ? ExecuteRecursion(number) : ExecuteTailRecursion(number);
        }

        public static int ExecuteRecursion(int[] arguments)
        {
            if (arguments.Length != 1)
            {
                throw new ArgumentException($"Wrong number of arguments in {nameof(FibonacciNumber)} call, arguments: {String.Join(",", arguments)}");
            }

            return ExecuteRecursion(arguments[0]);
        }

        public static int ExecuteRecursion(int number)
        {
            var value = 0;

            if (number == 0)
            {
                value = 0;
            }
            else if (number == 1)
            {
                value = 1;
            }
            else
            {
                value = ExecuteRecursion(number - 1) + ExecuteRecursion(number - 2);
            }

            return value;
        }

        public static int ExecuteTailRecursion(int[] arguments)
        {
            if (arguments.Length != 1)
            {
                throw new ArgumentException($"Wrong number of arguments in {nameof(FibonacciNumber)} call, arguments: {String.Join(",", arguments)}");
            }

            return ExecuteTailRecursion(arguments[0]);
        }

        public static int ExecuteTailRecursion(int number)
        {
            return Calculate(number, 0, 1);
        }

        private static int Calculate(int number, int current, int next)
        {
            var value = 0;

            if (number == 0)
            {
                value = current;
            }
            else if (number == 1)
            {
                value = next;
            }
            else
            {
                value = Calculate(number - 1, next, current + next);
            }

            return value;
        }
    }
}
