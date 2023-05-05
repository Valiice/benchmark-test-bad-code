using BenchmarkTest.Cons.Benchmarks;
using BenchmarkTest.Cons.Models;

namespace Benchmark.Tests;

public class UnitTest1
{
    readonly ManipulateStudentRecord manipulateStudentRecord;
    private StudentRecord studentRecord;
    public UnitTest1()
    {
        manipulateStudentRecord = new();
        studentRecord = new()
        {
            Name = "John",
            LastName = "Bliss",
            City = "Florida"
        };
    }
    [Fact]
    public void TestMethod()
    {
        var test = manipulateStudentRecord.ManipulateStudentRecordPropertyInfo(studentRecord, "edit", "Name", "Joos");
    }
}