# Problem
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F

## Solution
```cs
namespace Exercises.Algorithms.Codewars.AbbreviateATwoWordName;

public class AbbreviateATwoWordName
{
    public string Abbreviate(string name)
    {
        string[] nameSplited = name.Split(' ');
        string firstName = nameSplited[0][0].ToString().ToUpper();
        string secondName = nameSplited[1][0].ToString().ToUpper();
        return $"{firstName}.{secondName}";
    }
}
```
