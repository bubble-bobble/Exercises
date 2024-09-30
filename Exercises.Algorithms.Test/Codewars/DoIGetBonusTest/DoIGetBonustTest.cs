using Exercises.Algorithms.Codewars.DoIGetBonus;

namespace Exercises.Algorithms.Test.Codewars.DoIGetBonusTest;

[TestFixture]
public class DoIGetBonustTest
{
    private readonly DoIGetBonus doIGetBonus;

    public DoIGetBonustTest()
    {
        doIGetBonus = new DoIGetBonus();
    }

    [Test]
    public void GivenSalaryWhenBonusIsFalseThenReturnSalary()
    {
        StringAssert.AreEqualIgnoringCase("$10000", doIGetBonus.BonusTime(10000, false));
        StringAssert.AreEqualIgnoringCase("$60000", doIGetBonus.BonusTime(60000, false));
        StringAssert.AreEqualIgnoringCase("$78", doIGetBonus.BonusTime(78, false));
    }

    [Test]
    public void GivenSalaryWhenBonusIsTrueReturnCaculatedSalary()
    {
        StringAssert.AreEqualIgnoringCase("$100000", doIGetBonus.BonusTime(10000, true));
        StringAssert.AreEqualIgnoringCase("$250000", doIGetBonus.BonusTime(25000, true));
        StringAssert.AreEqualIgnoringCase("$20", doIGetBonus.BonusTime(2, true));
        StringAssert.AreEqualIgnoringCase("$678900", doIGetBonus.BonusTime(67890, true));
    }
}
