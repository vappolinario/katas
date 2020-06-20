 using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static string Order(string words)
  {
        var input = words.Split();
        var ordered = new List<string>();
        for (int i = 1; i <= input.Length; i++)
        {
           ordered.Add(input.FirstOrDefault(x => x.Contains($"{i}")));
        }
        return string.Join(" ", ordered); 
  }
}
