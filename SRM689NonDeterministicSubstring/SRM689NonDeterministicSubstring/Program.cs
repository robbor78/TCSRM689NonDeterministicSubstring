using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SRM689NonDeterministicSubstring
{
  public class Program
  {
    static void Main(string[] args)
    {
      String a = "00010001";
      String b = "(0|1)(0|1)";

      Regex rexp = new Regex(b, RegexOptions.None, Regex.InfiniteMatchTimeout);

      var matches = rexp.Matches(a);
      Console.Out.WriteLine("Matches...");
      foreach (var m in matches)
      {
        Console.Out.WriteLine(m);
      }

      var splits = rexp.Split(a);
      Console.Out.WriteLine("Splits...");
      foreach (var s in splits)
      {
        Console.Out.WriteLine(s);
      }

    }

    public long ways(String A, String B)
    {
      return -1;
    }
  }
}
