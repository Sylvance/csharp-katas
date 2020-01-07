public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    int count = 0;
    foreach(string str in smileys)
    {
      int last = 0;
      int last2 = 0;
      foreach(char character in str)
      {
        switch(character)
        {
          case ':':
            last = 1;
            last2 = 1;
            break;
          case ';':
            last = 2;
            last2 = 2;
            break;
          case '-':
            last2 = last;
            last = 3;
            break;
          case '~':
            last2 = last;
            last = 4;
            break;
          case ')':
            if (last == 1 || last == 2) count++;
            if ((last2 == 1 || last2 == 2) && (last == 3 || last == 4)) count++;
            last2 = last;
            last = 5;
            break;
          case 'D':
            if (last == 1 || last == 2) count++;
            if ((last2 == 1 || last2 == 2) && (last == 3 || last == 4)) count++;
            last2 = last;
            last = 6;
            break;
          default:
            last2 = last;
            last = 0;
            break;
        }
      }
    }
    return count;
  }
}
