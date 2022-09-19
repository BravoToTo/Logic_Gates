using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestCompuertaNOT
    {
        [Test]
        public void testOutput()
        {
            bool expected = true;
            var not = new CompuertaNOT(false);

            Assert.AreEqual(expected, not.Output);
        }
    }
}