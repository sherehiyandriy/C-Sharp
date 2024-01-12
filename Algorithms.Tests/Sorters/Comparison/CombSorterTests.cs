using System;
using Algorithms.Sorters.Comparison;
using Algorithms.Tests.Helpers;
using NUnit.Framework;

namespace Algorithms.Tests.Sorters.Comparison;

public static class CombSorterTests
{
    [Test]
    public static void ArraySorted(
        [Random(0, 1000, 100, Distinct = true)]
        int n)
    {
        // Arrange
        var sorter = new CombSorter<int>();
        var intComparer = new IntComparer();
        var (correctArray, testArray) = RandomHelper.GetArrays(n);

        // Act
        sorter.Sort(testArray, intComparer);
        Array.Sort(correctArray, intComparer);

        // Assert
        Assert.AreEqual(testArray, correctArray);
    }

    [Test]
    public static void ArraySorted_WithCustomShrinkFactor(
        [Random(0, 1000, 100, Distinct = true)]
        int n)
    {
        // Arrange
        var sorter = new CombSorter<int>(1.5);
        var intComparer = new IntComparer();
        var (correctArray, testArray) = RandomHelper.GetArrays(n);

        // Act
        sorter.Sort(testArray, intComparer);
        Array.Sort(correctArray, intComparer);

        // Assert
        Assert.AreEqual(testArray, correctArray);
    }
}
