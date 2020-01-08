using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> integerList = new List<int>() {};
      bool isNumber = false;
      foreach(var character in listOfItems)
      {
        isNumber = Regex.IsMatch(character.ToString(),@"-?\d+(\.\d+)?");
        if(isNumber && !(character is string))
        {
          integerList.Add((int) character);
        }
      }
      return integerList;
   }
}
