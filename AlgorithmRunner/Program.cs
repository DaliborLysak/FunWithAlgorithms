using System;
using System.Collections.Generic;
using System.Linq;
using Ackerman;
using Fibonacci;
using SortAlgorithms;

namespace AlgorithmRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAckerman();
            //RunFibonacci();
            RunSorts();

            Console.ReadLine();
        }

        private static void RunSorts()
        {
            RunSort(SortAlgorithmService.Sort<BubbleSort>, "Bubble Sort");
            RunSort(SortAlgorithmService.Sort<SelectionSort>, "Selection Sort");
            RunSort(SortAlgorithmService.Sort<InsertionSort>, "Insertion Sort");
        }

        private static void RunSort(Func<int[], int[]> algorithm, string name)
        {
            Console.WriteLine($"Run {name}");
            AlgorithmRunner.RunAlgorithm(algorithm, new int[10] { -5, 10, 3, -8, 8, 0, -2, 15, 3, 1 });
            Console.WriteLine();
        }

        private static void RunFibonacci()
        {
            Console.WriteLine("Fibonacci - recursion");
            AlgorithmRunner.RunAlgorithm(Fibonacci.FibonacciNumber.ExecuteRecursion, 45);
            Console.WriteLine("Fibonacci - tail recursion");
            AlgorithmRunner.RunAlgorithm(Fibonacci.FibonacciNumber.ExecuteTailRecursion, 45);
            Console.WriteLine();
        }

        private static void RunAckerman()
        {
            Console.WriteLine("Ackerman");
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 4, 0);
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 3, 2);
            AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 3, 4);
            //AlgorithmRunner.RunAlgorithm(Ackerman.AckermanFunction.Execute, 4, 1); //Stack overflow. - haha not expected
            Console.WriteLine();
        }
    }
}
