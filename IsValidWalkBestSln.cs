public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    if (walk.Length != 10) return false;
    var x = 0; var y = 0;
    foreach (var dir in walk)
    {
        if (dir == "n") x++;
        else if (dir == "s") x--;
        else if (dir == "e") y++;
        else if (dir == "w") y--;
    }
    return x == 0 && y == 0;
  }
}
