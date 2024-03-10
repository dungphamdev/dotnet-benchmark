using BenchmarkDotNet.Attributes;

public class StringBenchMark()
{
    private const int Iterations = 1000000;

    [Benchmark]
    public void StringEmptyBenchMark()
    {
        for (int i = 0; i < Iterations; i++)
        {
            string emptyStr = string.Empty;
        }
    }

    [Benchmark]
    public void EmptyQuoteBenchMark()
    {
        for (int i = 0; i < Iterations; i++)
        {
            string emptyStr = "";
        }
    }
}