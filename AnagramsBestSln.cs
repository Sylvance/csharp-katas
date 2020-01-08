using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> ret = new List<string>();
    char[] cword = word.ToCharArray();
    Array.Sort(cword);
    word = new string(cword);
    
    foreach (string w in words)
    {
        char[] wchar = w.ToCharArray();
        Array.Sort(wchar);
        string temp = new string(wchar);
        if (word == temp)
        {
            ret.Add(w);
        }
    }
    return ret;
  }
}
