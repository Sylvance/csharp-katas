using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
       string num_string = num.ToString();
       string res_string = "";
       int num_string_length = num_string.Length;

       foreach(char no in num_string)
       {
         if (no == '0')
         {
           num_string_length--;
           continue;
         }
         if(res_string.Length > 0)
         {
           res_string = string.Concat(res_string, new string(" + "), no, new string('0', num_string_length-1));
         }
         else
         {
           res_string = string.Concat(no, new string('0', num_string_length-1));
         }
         num_string_length--;
       }
       return res_string;
    }
}
