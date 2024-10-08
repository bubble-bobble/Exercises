using Exercises.Algorithms.Codewars.CountingSheep;

namespace Exercises.Algorithms.Test.Codewars.CountingSheepTest;

[TestFixture]
public class CountingSheepTest
{
    private readonly CountingSheep countingSheep;

    public CountingSheepTest()
    {
        countingSheep = new CountingSheep();
    }

    [Test]
    public void GivenArrayWhenValuesAreBooleansThenReturnQuantityOfTrue()
    {
        bool[] sheeps = [true, false, true];
        Assert.That(countingSheep.Count(sheeps), Is.EqualTo(2));
    }
}
