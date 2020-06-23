using NUnit.Framework;
using NonRepeatingChar;

namespace Tests
{
    public class NonRepeatingCharTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("a", NonRepeatingCharKata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", NonRepeatingCharKata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", NonRepeatingCharKata.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("", NonRepeatingCharKata.FirstNonRepeatingLetter("moonmn"));
            Assert.AreEqual("T", NonRepeatingCharKata.FirstNonRepeatingLetter("sTreSS"));
        }
    }
}
