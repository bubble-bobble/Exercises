using Exercises.Algorithms.Codewars.TotalAmountOfPoints;

namespace Exercises.Algorithms.Test.Codewars.TotalAmountOfPointsTest;

[TestFixture]
public class TotalAmountOfPointsTest
{
    private readonly TotalAmountOfPoints totalAmountOfPoints;

    public TotalAmountOfPointsTest()
    {
        totalAmountOfPoints = new TotalAmountOfPoints();
    }

    [Test]
    public void GivenMatchsScoresArrayReturnTotalPoints()
    {
        Assert.That(totalAmountOfPoints.TotalPoints(["1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4"]), Is.EqualTo(15));
    }
}
