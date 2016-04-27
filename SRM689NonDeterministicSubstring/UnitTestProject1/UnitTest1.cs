using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRM689NonDeterministicSubstring;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string[] aS = { "00010001" };
      string[] bS = { "??" };
      int[] ways = { 3 };

      int length = aS.Length;

      for (int i =0; i<length; i++)
      {
        string a = aS[i];
        string b = bS[i];

        Program target = new Program();
        long actual = target.ways(a, b);

        long expected = ways[i];
        Assert.AreEqual(actual, expected);
      }
    }
  }
}
