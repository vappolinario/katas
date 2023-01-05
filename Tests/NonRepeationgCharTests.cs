using NUnit.Framework;
using NonRepeatingChar;

namespace Tests
{
    public class NonRepeatingCharTests
    {
        [Test, Description("Non Repeating Char Test")]
        public void NonRepeatingCharTest()
        {
            Assert.AreEqual("a", NonRepeatingCharKata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", NonRepeatingCharKata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", NonRepeatingCharKata.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("", NonRepeatingCharKata.FirstNonRepeatingLetter("moonmn"));
            Assert.AreEqual("T", NonRepeatingCharKata.FirstNonRepeatingLetter("sTreSS"));
        }
    }
}
