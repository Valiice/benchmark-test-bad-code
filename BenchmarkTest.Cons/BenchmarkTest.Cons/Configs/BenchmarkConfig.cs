using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace BenchmarkTest.Cons.Configs;

public class BenchmarkConfig : ManualConfig
{
    public BenchmarkConfig()
    {
        AddJob(Job.Default.WithWarmupCount(1).WithIterationCount(1).WithIterationCount(10).WithIterationCount(100).WithIterationCount(1000));
    }
}