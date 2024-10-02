using System;
using System.Collections.Generic;

namespace Exercises.Algorithms.Codewars.ListFiltering;

public class ListFiltering
{
    public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        for (int i = 0; i < listOfItems.Count; i++)
        {
            if (listOfItems[i].GetType() == typeof(int))
            {
                yield return Convert.ToInt32(listOfItems[i]);
            }
        }
    }
}
