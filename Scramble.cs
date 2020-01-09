using System;
using System.Text;

public class Kata 
{
    public static bool Scramble(string str1, string str2) 
    {
        StringBuilder result = new StringBuilder(str1);

        foreach(char letter in str2)
        {
          bool flag = result.ToString().Contains(letter.ToString());
          if(flag == false) return false;
          else
          {
            int indexLetter = result.ToString().IndexOf(letter.ToString());
            result = result.Remove(indexLetter, 1);
          }
        }
        return true;
    }
}
