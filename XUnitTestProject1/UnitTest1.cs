using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() {
            Assert.True(1 == 1);
        }

        [Fact]
        public void SecondTest() {
            int x = 3;
            Assert.Equal(x, 3);
        }
    }
}
