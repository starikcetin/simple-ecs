using System;
using Xunit;

namespace UnitTests
{
    public class ControlTests
    {
        [Fact]
        public void Should_BeAlwaysTrue()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
