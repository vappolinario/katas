using System.Linq;

namespace ZeroToEnd
{
    public class ZeroToEndKata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
