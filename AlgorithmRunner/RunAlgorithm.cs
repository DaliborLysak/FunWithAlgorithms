using System;
using System.Diagnostics;

namespace AlgorithmRunner
{
    public static class AlgorithmRunner
    {
        public static void RunAlgorithm(Func<int[], int> algorithm, params int[] inputs)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = algorithm.Invoke(inputs);
            stopwatch.Stop();

            Console.WriteLine($"Executing algorithm with parameters {String.Join(',', inputs)}, with result {result}, elapsed time {stopwatch.ElapsedMilliseconds.ToString()} ms");
        }
    }
}