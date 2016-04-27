﻿using System;
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

    public long ways(String a, String b)
    {
      Node trie = BuildTrue(a);
      return -1;
    }

    private Node BuildTrue(string a)
    {
      Node trie = null;

      for (int i = 0; i < a.Length; i++)
      {
        trie = put(trie, a.Substring(i), 0);
      }

      return trie;
    }

    private Node put(Node x, String key, int d)
    {
      char c = key[d];
      if (x == null)
      {
        x = new Node(); x.c = c;
      }
      if (c != x.c)
      {
        x.notequal = put(x.notequal, key, d);
      }
      else if (d < key.Count() - 1)
      {
        x.equal = put(x.equal, key, d + 1);
      }
      return x;
    }
  }

  class Node
  {
    public char c;
    public Node equal;
    public Node notequal;
  }
}
