using System.Linq;

namespace ZeroToEnd
{
    public class ZeroToEndKata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var numbers = arr.Where(n => n != 0);
            return numbers.Concat(new int[arr.Length - numbers.Count()]).ToArray();
        }
    }
}
