using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestCompuertaAND
    {
        [Test]
        public void testOutput()
        {
            bool expected = false;
            var and = new CompuertaAND();
            and.AddEntry(true);
            and.AddEntry(false);

            Assert.AreEqual(expected, and.Output);
        }
    }
}