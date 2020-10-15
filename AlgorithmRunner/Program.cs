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
            //RunSort(SortAlgorithmService.Sort<BubbleSort>, "Bubble Sort"); // realy slow, limit 10^3 elements
            //RunSort(SortAlgorithmService.Sort<SelectionSort>, "Selection Sort"); // realy slow , limit 10^4 elements
            //RunSort(SortAlgorithmService.Sort<InsertionSort>, "Insertion Sort"); // faster for 10^4 then MergeSort, after 10^5 realy slow
            RunSort(SortAlgorithmService.Sort<MergeSort>, "Merge Sort"); // starts shine around 10000 elements, around 19s for 10^7
            RunSort(SortAlgorithmService.Sort<QuickSort>, "Quick Sort"); // shines always
        }

        private static int[] GetSortArray()
        {
            var shortTest = false;
            int[] sortArray;
            if (shortTest)
            {
                sortArray = new int[20] { -5, 10, 3, -8, 8, 0, -2, 15, 3, 1, 3, 4, 2, 1, 7, 5, 8, 9, 0, 6 };
            }
            else
            {
                sortArray = new int[1000000]; // 10^4 is good example
                var random = new Random();
                for (var i = 0; i < sortArray.Count(); i++)
                {
                    sortArray[i] = random.Next();
                }
            }

            return sortArray;
        }

        private static void RunSort(Func<int[], int[]> algorithm, string name)
        {
            Console.WriteLine($"Run {name}");
            AlgorithmRunner.RunAlgorithm(algorithm, GetSortArray());
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
