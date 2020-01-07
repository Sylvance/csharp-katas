using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
  }
}
