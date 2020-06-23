using System.Linq;

namespace NonRepeatingChar
{
    public class NonRepeatingCharKata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
                      .SkipWhile(g => g.Count() > 1)
                      .Select(i => i.First().ToString())
                      .DefaultIfEmpty(string.Empty)
                      .First();
        }
    }
}
