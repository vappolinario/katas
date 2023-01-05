using NUnit.Framework;
using Rot13;

namespace Tests
{
    public class Rot13Tests
    {
        [Test, Description("Rot 13 Test")]
        public void Rot13()
        {
            Assert.AreEqual("Grfg", Rot13Kata.Rot13("Test"));
        }
    }
}
