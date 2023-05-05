using BenchmarkDotNet.Running;
using BenchmarkTest.Cons.Benchmarks;
using BenchmarkTest.Cons.Configs;

namespace BenchmarkTest.Cons;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<ManipulateStudentRecordBenchmark>();
    }
}