using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
       foreach (object x in listOfItems)
           if (x is int) yield return (int) x;
   }
}
