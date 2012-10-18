using NUnit.Framework;

namespace Oahu.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void WillSucceed()
        {
            Assert.That(true, Is.True);
        }
    }
}
