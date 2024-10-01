using System;
using Exercises.Algorithms.Codewars.AbbreviateATwoWordName;

namespace Exercises.Algorithms.Test.Codewars.AbbreviateATwoWordNameTest;

[TestFixture]
public class AbbreviateATwoWordNameTest
{
    private readonly AbbreviateATwoWordName abbreviateATwoWordName;

    public AbbreviateATwoWordNameTest()
    {
        abbreviateATwoWordName = new AbbreviateATwoWordName();
    }

    [Test]
    public void GivenNameInCapitalCaseWhenHaveTwoWordThenReturnInitials()
    {
        Assert.Multiple(() =>
        {
            Assert.That(abbreviateATwoWordName.Abbreviate("Sam Harris"), Is.EqualTo("S.H"));
            Assert.That(abbreviateATwoWordName.Abbreviate("Patrick Feenan"), Is.EqualTo("P.F"));
            Assert.That(abbreviateATwoWordName.Abbreviate("Evan Cole"), Is.EqualTo("E.C"));
            Assert.That(abbreviateATwoWordName.Abbreviate("P Favuzzi"), Is.EqualTo("P.F"));
            Assert.That(abbreviateATwoWordName.Abbreviate("David Mendieta"), Is.EqualTo("D.M"));
        });
    }

    [Test]
    public void GivenNameInLowerCaseWhenHaveToWordThenReturnInitials()
    {
        Assert.Multiple(() =>
        {
            Assert.That(abbreviateATwoWordName.Abbreviate("sam harris"), Is.EqualTo("S.H"));
            Assert.That(abbreviateATwoWordName.Abbreviate("patrick feenan"), Is.EqualTo("P.F"));
            Assert.That(abbreviateATwoWordName.Abbreviate("evan cole"), Is.EqualTo("E.C"));
            Assert.That(abbreviateATwoWordName.Abbreviate("p favuzzi"), Is.EqualTo("P.F"));
            Assert.That(abbreviateATwoWordName.Abbreviate("david mendieta"), Is.EqualTo("D.M"));
        });
    }
}
