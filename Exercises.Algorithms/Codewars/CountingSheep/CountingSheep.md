# Problem
Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).

For example,
```
[true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true]
```

The correct answer would be 17.

Hint: Don't forget to check for bad values like null/undefined

## Solution

```cs
namespace Exercises.Algorithms.Codewars.CountingSheep;

public class CountingSheep
{
    public int Count(bool[] sheeps)
    {
        int quantity = 0;
        for (int i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i])
            {
                quantity++;
            }
        }
        return quantity;
    }
}

```