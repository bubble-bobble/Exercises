using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Algorithms.Codewars.ListFiltering;

namespace Exercises.Algorithms.Test.Codewars.ListFilteringTest;

[TestFixture]
public class ListFilteringTest
{

    private readonly ListFiltering listFiltering;

    public ListFilteringTest()
    {
        listFiltering = new ListFiltering();
    }

    [Test]
    public void GivenListWhenElementTypesAreDifferentThenReturnListWithOnlyIntegers()
    {
        List<object> list = [1, 2, "aasf", "1", "123", 123];
        List<int> expected = [1, 2, 123];
        IEnumerable<int> actual = listFiltering.GetIntegersFromList(list);
        Assert.That(expected.SequenceEqual(actual), Is.True);
    }
}
