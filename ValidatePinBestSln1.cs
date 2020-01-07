using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
       return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
  }
}
