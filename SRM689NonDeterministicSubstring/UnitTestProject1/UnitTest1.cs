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
      string[] aS = { "00010001", "00000000", "001010101100010111010", "00101", "1101010101111010101011111111110001010101" };
      string[] bS = { "??", "??0??0", "???", "??????", "???????????????????????????????????" };
      int[] ways = { 3, 1, 8, 0, 6 };

      int length = aS.Length;

      for (int i = 0; i < length; i++)
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
