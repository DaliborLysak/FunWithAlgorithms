using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;


namespace AlgorithmRunner.Benchmarks;

public class BenchmarkAckerman : BenchmarkAlgorithm
{
    // dotnet run -c Release

    public BenchmarkAckerman()
    {
        var value40 = this.RunBenchmarkAckerman40();
        var value32 = this.RunBenchmarkAckerman32();
        var value34 = this.RunBenchmarkAckerman34();
    }

    [Benchmark]
    public int RunBenchmarkAckerman40()
    {
        return RunAlgorithmBenchmark(Ackerman.AckermanFunction.Execute, 4, 0);
    }

    [Benchmark]
    public int RunBenchmarkAckerman32()
    {
        return RunAlgorithmBenchmark(Ackerman.AckermanFunction.Execute, 3, 2);
    }

    [Benchmark]
    public int RunBenchmarkAckerman34()
    {
        return RunAlgorithmBenchmark(Ackerman.AckermanFunction.Execute, 3, 4);
    }
}
