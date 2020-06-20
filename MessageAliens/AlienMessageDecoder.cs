using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageAliens
{
    public class AlienMessageDecoder
    {
        public static string Decode(string m)
        {
            var code = new Dictionary<string, string>
            {
              { "/\\" , "a" }, { "]3" , "b" }, { "(" , "c" }, { "|)" , "d" },
              { "[-" , "e" }, { "/=" , "f" }, { "(_," , "g" }, { "|-|" , "h" },
              { "|" , "i" }, { "_T", "j" }, { "/<" , "k" }, { "|_" , "l" },
              { "|\\|" , "n" }, { "|\\/|" , "m" }, { "()" , "o" }, { "|^" , "p" },
              { "()_" , "q" }, { "/?" , "r" }, { "_\\~" , "s" }, { "~|~" , "t" },
              { "|_|" , "u" }, { "\\/" , "v" }, { "><" , "x" }, { "\\/\\/" , "w" },
              { "`/" , "y" }, { "~/_" , "z" }, { "__" , " " }
            };

            var translation = m.Split(m[0]).Where(s => code.ContainsKey(s)).Select(s => code[s]);
            return string.Join("", translation.Reverse());
        }
    }
}
