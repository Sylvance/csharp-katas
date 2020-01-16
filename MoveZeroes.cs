using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> arrList = new List<int>();
    int count = 0;
    
    foreach(int value in arr)
    {
      if (value == 0) count++;
      else if(value != 0) arrList.Add(value);
    }

    if (count > 0)
    {
      while(count > 0)
      {
        arrList.Add(0);
        count--;
      }
    }
    int[] newArr = arrList.ToArray();
    return newArr;
  }
  public static void Main()
  {
    int[] nums = new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};
    int[] result = MoveZeroes(nums);
    for(int i = 0; i < result.Length; i++)
      Console.Write(result[i] + "");
  }
}
