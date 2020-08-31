using System;
using Ackerman;
using Fibonacci;

namespace AlgorithmRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAckerman();
            RunFibonacci();

            Console.ReadLine();
        }

        private static void RunFibonacci()
        {
            Console.WriteLine("Fibonacci - recursion");
            AlgorithmRunner.RunAlgorithm(Fibonacci.FibonacciNumber.ExecuteRecursion, 45);
            Console.WriteLine("Fibonacci - tail recursion");
            AlgorithmRunner.RunAlgorithm(Fibonacci.FibonacciNumber.ExecuteTailRecursion, 45);
        }

        private static void RunAckerman()
        {
            Console.WriteLine("Ackerman");
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 4, 0);
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 3, 2);
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 3, 4);
            //AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 4, 1); //Stack overflow. - haha not expected
        }
    }
}
