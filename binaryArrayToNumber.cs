using System;

namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          // start from right
          // state length of array
          // raise 2 to the position index from right
          // store power in ans variable as sum of powers
          // return ans variable
  
          int ans = 0;
          int pos_index = 0;
          
          for(int pos = BinaryArray.Length - 1; pos >= 0; pos--)
          {
            if(BinaryArray[pos] == 1)
            {
              int power = (int) Math.Pow(2, pos_index);
              ans = ans + power;
            }
            pos_index++;
          }
          return ans;
        }
    }
}
