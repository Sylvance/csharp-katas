using System;
using System.Collections.Generic;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    Dictionary<string, int> duplicatesHash = new Dictionary<string, int>();
    string result = new string("");
    
    foreach(char letter in word)
    {
      if(duplicatesHash.ContainsKey(letter.ToString().ToLower()))
      {
        duplicatesHash[letter.ToString().ToLower()] = duplicatesHash[letter.ToString().ToLower()] + 1;
      }
      else
      {
        duplicatesHash.Add(letter.ToString().ToLower(), 1);
      }
    }

    foreach(char letter in word)
    {
      if(duplicatesHash[letter.ToString().ToLower()] > 1) result = result + ")";
      else result = result + "(";
    }
    return result;
  }
}
