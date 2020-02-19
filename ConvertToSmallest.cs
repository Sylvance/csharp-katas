using System;
					
public class Program
{
	public static int ConvertToSmallest(Object num)
    {
        int number = Convert.ToInt32(num);
        string numString = number.ToString();
        int len = numString.Length;
        string firstVal = numString.Substring(0, 1);
        string otherVal = numString.Substring(1);
        string zeroVal = new string('0', len-1);

        if(len == 1) return 0;
        if(firstVal == "1" && otherVal == zeroVal) return number;
        long newNum = Int64.Parse(string.Concat(1, new string('0', len-1)));
        return (int) newNum;
    }
	public static void Main()
	{
		Object num = 2.2E+5;
		Console.WriteLine(ConvertToSmallest(num));
	}
}
