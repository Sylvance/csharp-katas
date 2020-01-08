using System;
using System.Linq;
public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int sum = 0;
    int index = 0;
    int computed_sum = arr.Sum();
    foreach(int num in arr)
    {
      if(sum == (computed_sum - num - sum)) return index;
      sum += num;
      index++;
    }
    return -1;
  }
}
