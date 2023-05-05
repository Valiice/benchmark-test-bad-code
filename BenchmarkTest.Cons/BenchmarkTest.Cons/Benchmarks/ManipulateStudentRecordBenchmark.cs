using BenchmarkDotNet.Attributes;
using BenchmarkTest.Cons.Models;

namespace BenchmarkTest.Cons.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ManipulateStudentRecordBenchmark
{
    //[Params(1, 10, 100, 1000)]
    //public int NumberOfRuns { get; set; }

    readonly ManipulateStudentRecord manipulateStudentRecord = new();

    private StudentRecord studentRecord = new()
    {
        Name = "John",
        LastName = "Bliss",
        City = "Florida"
    };

    [Benchmark(Baseline = true)]
    public void ManipulateStudentRecordPropertyInfo()
    {
        manipulateStudentRecord.ManipulateStudentRecordPropertyInfo(studentRecord, "edit", "Name", "Joos");
    }

    [Benchmark]
    public void ManipulateStudentRecordSwitch()
    {
        manipulateStudentRecord.ManipulateStudentRecordSwitch(studentRecord, "edit", "Name", "Joos");
    }

    [Benchmark]
    public void ManipulateStudentRecordSwitchWithoutNewObj()
    {
        manipulateStudentRecord.ManipulateStudentRecordSwitchWithoutNewObj(studentRecord, "edit", "Name", "Joos");
    }

    [Benchmark]
    public void ManipulateStudentRecordReviewer()
    {
        manipulateStudentRecord.ManipulateStudentRecordReviewer(studentRecord, "edit", "Name", "Joos");
    }
}