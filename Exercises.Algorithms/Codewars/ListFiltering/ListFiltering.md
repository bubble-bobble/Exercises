# Problem
In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

```cs
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, "a", "b", 0, 15}) => {1, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 123}) => {1, 2, 231}
```

## Solution
```cs
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

```