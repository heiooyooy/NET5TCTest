using NUnit.Framework;

namespace NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() {
            int x = 3;
            Assert.AreEqual(x, 3);
        }
    }
}