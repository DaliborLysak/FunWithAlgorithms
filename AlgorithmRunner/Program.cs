using System;
using Ackerman;
using Fibonacci;
using InsertionSort;

namespace AlgorithmRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAckerman();
            //RunFibonacci();
            RunInsertionSort();

            Console.ReadLine();
        }

        private static void RunInsertionSort()
        {
            Console.WriteLine("RunInsertion Sort");
            AlgorithmRunner.RunAlgorithm(InsertionSort.Insertion.Sort, new int[10] { -5, 10, 3, -8, 8, 0, -2, 15, 3, 1 });
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
