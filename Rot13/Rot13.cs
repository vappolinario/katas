using System.Linq;

namespace Rot13
{
    public class Rot13Kata
    {
      public static string Rot13(string message)
      {
        var cipher =  message.Select(c => (c >= 'a' && c <= 'z') ? (char)((c - 'a' + 13) % 26 + 'a') : c);
        cipher = cipher.Select(c => ((c >= 'A' && c <= 'Z') ? (char)((c - 'A' + 13) % 26 + 'A') : c));
        return string.Join("", cipher);
      }
    }
}
