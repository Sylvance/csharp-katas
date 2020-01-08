using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
      string numString = num.ToString();
      string blah = "";      
      for (int i = 0; i < numString.Length; i++)
      {
        if (numString[i] != '0')
        {
          blah += numString[i];
          blah += new String('0', numString.Length - i - 1);
          blah += " + ";
        }
      }
      return blah.Substring(0, blah.Length - 3);
    }
}
