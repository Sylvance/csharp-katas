using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    // Regex for 4 or 6

    // check if exactly 4 or 6 digits, assign to boolean flag
    // ^\d{4}, ^\d{6}
    bool b46 = false;
    Regex rgx4 = new Regex(@"^\d{4}");
    bool b4 = rgx4.IsMatch(pin);
    Regex rgx6 = new Regex(@"^\d{6}");
    bool b6 = rgx6.IsMatch(pin);
    if( b4 || b6)
    {
      b46 = true;
    }
    if(pin.Length == 6 && !b6 && b4)
    {
      b46 = false;
    }
    // short-circuit both flags and return boolean
    return b46 && pin.Length != 5 && pin.Length <= 6;
  }
}
