using System;
using System.Collections.Generic;
					
public class Program
{
	public static int[] ShiftUnEvenArray(int[] arr)
    {
        int zeroCount = 0;
        int prev = 0;
        bool skip = true;

        List<int> newArr = new List<int>{};

        foreach (var item in arr)
        {
            if (!skip)
            {
                if (item == 0) zeroCount++;
                else if (prev == item)
                {
                    newArr.Add(item+item);
                    zeroCount++;
                }
                else if (prev != item) newArr.Add(item);
                prev = item;
                skip = true;
            }
            else 
            {
                prev = item;
                skip = false;
            }
        }

        if (zeroCount > 0)
        {
            for (int i = 1; i <= zeroCount; i++)
            {
                newArr.Add(0);
            }
        }
        return newArr.ToArray();
    }
	public static void Main()
	{
		int[] numArray = { 2, 2, 0, 4, 0, 8 };
        int[] newArr = ShiftUnEvenArray(numArray);
        for(int i = 0; i <= newArr.Length; i++)
                Console.Write(newArr[i] + " ");
	}
}
