using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin) => new Regex("^((\\d{4})|(\\d{6}))$").IsMatch(pin);
}
