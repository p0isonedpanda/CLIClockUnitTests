using NUnit.Framework;
using ClockProject;

namespace ClockProject.UnitTests
{
    [TestFixture]
    public class Tests
    {
        private readonly Clock _clock;

        public Tests()
        {
            _clock = new Clock();
        }

        [TestCase(1, "0:0:1")]
        [TestCase(59, "0:0:59")]
        [TestCase(60, "0:1:0")]
        [TestCase(120, "0:2:0")]
        [TestCase(119, "0:1:59")]
        [TestCase(3600, "1:0:0")]
        [TestCase(3599, "0:59:59")]
        [TestCase(7200, "2:0:0")]
        public void TestTick(int toTick, string expected)
        {
            for (int i = 0; i < toTick; i++)
            {
                _clock.Tick();
            }

            Assert.AreEqual(_clock.CurrentTime, expected);
            _clock.Reset();
        }
    }
}