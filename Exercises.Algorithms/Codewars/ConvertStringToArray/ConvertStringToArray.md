# Problem
Write a function to split a string and convert it into an array of words.

```
"Robin Singh" ==> ["Robin", "Singh"]

"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
```

## Solution
```cs
namespace Exercises.Algorithms.Codewars.ConvertStringToArray;

public class ConvertStringToArray
{
    public string[] StringToArray(string str)
    {
        return str.Split(' ');
    }
}
```