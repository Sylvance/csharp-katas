using System;

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    // sequence => 1,3,5,7,9 ...
    char whitespace = ' ';
    char star = '*';
    int current_star_count = 1;
    int increment_by = 2;
    string[] result = new string[nFloors];

    int count = 1;
    int last_odd_number = 1;

    while( count < nFloors)
    {
      count++;
      last_odd_number = last_odd_number + 2;
    }

    for(int i = 0; i < nFloors; i++)
    {
      int whitespace_length = (int) (last_odd_number - current_star_count)/2;
      string whitespace_string = new string(whitespace, whitespace_length);
      string result_string = whitespace_string + new string(star, current_star_count) + whitespace_string;
      result[i] = result_string;
      current_star_count = current_star_count + increment_by;
    }
    return result;
  }
}
