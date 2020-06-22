using NUnit.Framework;
using DetectPangram;

namespace Tests
{
    public class DetectPangramTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.True(DetectPangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.True(DetectPangramKata.IsPangram("Bancos fúteis pagavam-lhe queijo, whisky e xadrez"));
        }

        [Test, Description("Portugues")]
        public void PortugueseTest()
        {
            Assert.True(DetectPangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.True(DetectPangramKata.IsPangram("Bancos fúteis pagavam-lhe queijo, whisky e xadrez"));
        }

    }
}
