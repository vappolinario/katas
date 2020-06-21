using NUnit.Framework;
using ZeroToEnd;

namespace Tests
{
    public class ZeroToEndTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, ZeroToEndKata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}
