using System.Linq;
using System.Collections.Generic;

namespace YourOrderPlease
{
    public static class Kata
    {
        public static string Order(string words)
        {
             return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
}

