using NUnit.Framework;

namespace Oahu.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void WillFail()
        {
            Assert.That(false, Is.True);
        }
    }
}
