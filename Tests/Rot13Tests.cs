using NUnit.Framework;
using Rot13;

namespace Tests
{
    public class Rot13Tests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Grfg", Rot13Kata.Rot13("Test"));
        }
    }
}
