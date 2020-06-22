using System.Linq;

namespace DetectPangram
{
    public class DetectPangramKata
    {
      public static bool IsPangram(string str)
      {
        return str.ToUpper().Where(c => 'A' <= c && c <= 'Z').Distinct().Count() == 26;
      }
    }
}
