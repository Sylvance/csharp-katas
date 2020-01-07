public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    // take 10 minutes return to starting point
    // [n + s] & [e + w] pairs => back to starting point

    // check if array count is not 10 return false
    if (walk.Length != 10)
    {
      return false;
    }
    // get count for [n + s] & [e + w] pairs
    int n_count = 0;
    int s_count = 0;
    int e_count = 0;
    int w_count = 0;

    foreach (string direction in walk)
    {
      switch(direction)
      {
        case "n":
          n_count++;
          break;
        case "s":
          s_count++;
          break;
        case "e":
          e_count++;
          break;
        case "w":
          w_count++;
          break;
      }
    }
    // compare whether count per pair is not similar return false
    if(n_count != s_count)
    {
      return false;
    }
    if(e_count != w_count)
    {
      return false;
    }
    // otherwise return true
    return true;
  }
}
