using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> integerList = new List<int>() {};
      foreach(var character in listOfItems)
      {
        if(!(character is string)) integerList.Add((int) character);
      }
      return integerList;
   }
}
