using NUnit.Framework;
using BigNumber;

namespace Tests
{
    public class BigNumberTests
    {
        [Test, Description("Sample Tests")]
        public void BigNumberTest()
        {
            Assert.AreEqual("1111111110", BigNumberKata.Add("123456789", "987654321"));
        }
    }
}
