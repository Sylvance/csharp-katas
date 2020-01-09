public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    string rs = DecimalToHexadecimal(r);
    string gs = DecimalToHexadecimal(g);
    string bs = DecimalToHexadecimal(b);

    return rs + gs + bs;
  }
  
  private static string DecimalToHexadecimal(int dec)
  {
    if(dec > 255) dec = 255;
    if(dec < 0) dec = 0;
    return dec.ToString("X2");
  }
}
