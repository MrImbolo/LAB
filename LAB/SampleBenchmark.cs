using BenchmarkDotNet.Attributes;
using LAB.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Bench
{
    [MemoryDiagnoser]
    public class SampleBenchmark
    {
        readonly Sample _sample = new();
        readonly ControlSample _controlSample = new();


        [Benchmark]
        public void Sample()
        {
            _sample.Execute();
        }
        
        [Benchmark]
        public void ControlSample()
        {
            _controlSample.Execute();
        }
    }
}
