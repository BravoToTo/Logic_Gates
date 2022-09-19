using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestCompuertaOR
    {
        [Test]
        public void testOutput()
        {
            bool expected = true;
            var or = new CompuertaOR();
            or.AddEntry(true);
            or.AddEntry(false);

            Assert.AreEqual(expected, or.Output);
        }
    }
}