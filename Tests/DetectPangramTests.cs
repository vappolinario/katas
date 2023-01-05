using NUnit.Framework;
using DetectPangram;

namespace Tests
{
    public class DetectPangramTest
    {
        [Test, Description("PangramTest")]
        public void PangramTest()
        {
            Assert.True(DetectPangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.True(DetectPangramKata.IsPangram("Bancos fúteis pagavam-lhe queijo, whisky e xadrez"));
        }

        [Test, Description("Pangram Portugues")]
        public void PangramPortugueseTest()
        {
            Assert.True(DetectPangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.True(DetectPangramKata.IsPangram("Bancos fúteis pagavam-lhe queijo, whisky e xadrez"));
        }

    }
}
