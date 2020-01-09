using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    Dictionary<int, int> duplicates = new Dictionary<int, int>();
    foreach(var number in numbers)
    {
      if(duplicates.ContainsKey(number)) duplicates[number] = duplicates[number] + 1;
      else duplicates.Add(number, 1);
    }
    foreach(KeyValuePair<int, int> res in duplicates)
    {
      if(res.Value == 1) return res.Key;
    }
    return -1;
  }
}
