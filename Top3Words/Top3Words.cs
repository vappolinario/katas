using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace Top3Words
{
    public static class TopWords
    {
        public static List<string> Top3(string s)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            var rx = new Regex(@"\w+[']*\w*",
                    RegexOptions.Compiled | RegexOptions.IgnoreCase);

            var words = rx.Matches(s)
                .Cast<Match>()
                .Select(m => m.Value.ToLower())
                .GroupBy(w => w)
                .Select(g => new
                {
                    Word = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(g => g.Count)
                .Take(3);

            return words.Select(g => g.Word).ToList();
        }
    }
}
