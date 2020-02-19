using System;
using System.Collections.Generic;
					
public class Program
{
	public static int CountIdenticalPairs(int[] arr)
    {
        int count = 0;
        Dictionary<int, int> pairsDict = new Dictionary<int, int>() {};
        foreach(int value in arr)
        {
            if(pairsDict.ContainsKey(value))
            {
                count = count + pairsDict[value];
                pairsDict[value] += 1;
            }
            else
			{
				pairsDict.Add(value, 1);
			}
        }
        return count;
    }
	public static void Main()
	{
		int[] numArray = { 0, 0, 3, 5, 6, 3, 3, 5, 0, 0 };
		Console.WriteLine(CountIdenticalPairs(numArray));
	}
}
