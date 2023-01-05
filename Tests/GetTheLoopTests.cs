using NUnit.Framework;
using GetTheLoop;

namespace Tests
{
    public class GetTheLoopTests
    {
        [Test, Description("Sample Tests")]
        public void LoopTest()
        {
            var n1 = new Node();
            var n2 = new Node();
            var n3 = new Node();
            var n4 = new Node();
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n2;
            Assert.AreEqual(3, GetTheLoopKata.GetLoopSize(n1));
        }

        [Test, Description("Sample Tests")]
        public void LoopTest2()
        {
            var n1 = new Node();
            var n2 = new Node();
            var n3 = new Node();
            var n4 = new Node();
            var n5 = new Node();
            var n6 = new Node();
            var n7 = new Node();
            var n8 = new Node();
            var n9 = new Node();
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;
            n8.Next = n9;
            n9.Next = n4;
            Assert.AreEqual(6, GetTheLoopKata.GetLoopSize(n1));
        }
    }
}
