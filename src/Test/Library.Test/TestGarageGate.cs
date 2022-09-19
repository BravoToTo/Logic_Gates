using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestGarageGate
    {
        [Test]
        public void testOpen1()
        {
            bool expected = true;

            bool a = true;
            bool b = true;
            bool c = true;

            Assert.AreEqual(expected, GarageGate.Open(a, b, c));
        }

        [Test]
        public void testOpen2()
        {
            bool expected = true;

            bool a = false;
            bool b = false;
            bool c = true;

            Assert.AreEqual(expected, GarageGate.Open(a, b, c));
        }
    }
}