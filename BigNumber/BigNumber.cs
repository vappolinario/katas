namespace BigNumber
{
    using System.Numerics;
    public class BigNumberKata
    {
      public static string Add(string a, string b)
      {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
      }
    }
}
