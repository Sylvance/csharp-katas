using System;
					
public class Program
{
    public static ulong binaryArrayToNumber(char[] BinaryArray)
    {
        ulong ans = 0;
        int pos_index = 0;
        
        for(int pos = BinaryArray.Length - 1; pos >= 0; pos--)
        {
            if(BinaryArray[pos] == '1')
            {
                ulong power = (ulong) Math.Pow(2, pos_index);
                ans = ans + power;
            }
            pos_index++;
            Console.WriteLine(ans);
        }
        return ans;
    }
	public static int CountDownToZero(string binaryNum)
    {
        ulong num = binaryArrayToNumber(binaryNum.ToCharArray());
        Console.WriteLine(num);
        int count = 0;

        while(num != 0)
        {
            if(num%2 == 0) num = num/2;
            else num = num - 1;
            count++;
        }
        return count;
    }
	public static void Main()
	{
		string binaryNum = "0010101010010101010010001010101010010101010010001010101001010101010100100101010100101010100100010101010100101010100100010101010010101010101001"; // add 0 to cause a System Overflow exception
		Console.WriteLine(CountDownToZero(binaryNum));
	}
}
