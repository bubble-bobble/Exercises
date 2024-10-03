using Exercises.Algorithms.Codewars.ConvertStringToArray;

namespace Exercises.Algorithms.Test.Codewars.ConvertStringToArrayTest;

[TestFixture]
public class ConvertStringToArrayTest
{
    private readonly ConvertStringToArray convertStringToArray;
    private static readonly string[] expected = ["I", "love", "arrays", "they", "are", "my", "favorite"];

    public ConvertStringToArrayTest()
    {
        convertStringToArray = new ConvertStringToArray();
    }

    [Test]
    public void GivenArrayWhenElementsAreStringThenReturnArrayOfString()
    {
        Assert.That(convertStringToArray.StringToArray("I love arrays they are my favorite"), Is.EqualTo(expected));
    }
}
