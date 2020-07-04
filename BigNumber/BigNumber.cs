using System;
using System.Numerics;

namespace BigNumber
{
    public class BigNumberKata
    {
      public static string Add(string a, string b)
      {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
      }
    }
}
