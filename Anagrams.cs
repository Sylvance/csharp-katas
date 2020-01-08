using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> result = new List<string>() {};
    string new_word = new string (word.OrderBy(c => c).ToArray());

    foreach(string jina in words)
    {
      string new_jina = new string (jina.OrderBy(c => c).ToArray());
      if(new_word == new_jina)
      {
        result.Add(jina);
      }
    }
    return result;
  }
}
