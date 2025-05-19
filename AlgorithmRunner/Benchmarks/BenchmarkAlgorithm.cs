using System;

namespace AlgorithmRunner.Benchmarks;

public class BenchmarkAlgorithm
{
    // dotnet run -c Release

    public static int RunAlgorithmBenchmark(Func<int[], int> algorithm, params int[] inputs)
    {
        return algorithm.Invoke(inputs);
    }

    public static int[] RunAlgorithmBenchmark(Func<int[], int[]> algorithm, params int[] input)
    {
        return algorithm.Invoke(input);
    }
}
