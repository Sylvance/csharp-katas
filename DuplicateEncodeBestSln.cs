public class Kata
{
  public static string DuplicateEncode(string word)
  {
      string retval = "";
      word = word.ToLower();
      for(int i = 0; i < word.Length; i++)
        retval += (word.Split(word[i]).Length - 1 > 1 ? ')' : '(');
      return retval;
  }
}
