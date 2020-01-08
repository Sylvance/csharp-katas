using System;

public static class Kata
{
  public static int MultiplesOf3or5Solution(int value)
  {
    int i = 2;
    int sum = 0;
    while(i < value)
    {
      if(i%15 == 0) sum = sum + i;
      else if(i%5 == 0) sum = sum + i;
      else if(i%3 == 0) sum = sum + i;
      i++;
    }
    return sum;
  }
}
