using LAB.Code;

namespace LAB.TestChamber
{
    public class SampleTest
    {
        [Fact]
        public void Test()
        {
            var sample = new Sample();
            Assert.True(sample is not null);
        }
    }

    public class ControlSampleTest
    {
        [Fact]
        public void Test()
        {
            var controlSample = new ControlSample();
            Assert.True(controlSample is not null);
        }
    }
}