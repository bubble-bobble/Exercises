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
