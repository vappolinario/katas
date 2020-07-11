using System.Linq;
using NUnit.Framework;
using SnailSort;

namespace Tests
{
    public class SnailSortTests
    {
        [Test, Description("3x3")]
        public void SampleTest()
        {
            int[][] array =
         {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };

            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Assert.AreEqual(r, SnailSortKata.Snail(array));
        }

        [Test, Description("5x5")]
        public void SampleTest2()
        {
            int[][] array =
         {
           new []{1, 2, 3, 4, 5},
           new []{16, 17, 18, 19, 6},
           new []{15, 24, 25, 20, 7},
           new []{14, 23, 22, 21, 8},
           new []{13, 12, 11, 10, 9},
       };

            var r =  Enumerable.Range(1,25).ToArray();
            Assert.AreEqual(r, SnailSortKata.Snail(array));
        }

        [Test, Description("Vazio")]
        public void SampleTest3()
        {
            int[][] array = { new int[]{} };

            var r =  new int[]{};
            Assert.AreEqual(r, SnailSortKata.Snail(array));
        }
    }
}
