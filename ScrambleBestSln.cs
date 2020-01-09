using System;
using System.Linq;
public class Kata 
{
    public static bool Scramble(string str1, string str2) 
    {
       foreach (char c in str2)
       {
           int index = str1.IndexOf(c);
           if (index < 0)
               return false;
           str1 = str1.Remove(index, 1);
       }
       return true;
    }

}
