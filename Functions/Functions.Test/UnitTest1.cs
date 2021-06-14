using System;
using Xunit;
using Functions.FindArrayInArray;
using FluentAssertions;

namespace Functions.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(
            new int[] { 2, 1, 4, 1, 4, 1, 2, 8 },
            new int[] { 1, 4, 1 },
            new int[] { 1, 3, 0, 0, 0, 0, 0, 0 })]
        [InlineData(
            new int[] { 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1 },
            new int[] { 0, 1, 2, 3, 4, 0, 0 })]
        [InlineData(
            new int[] { 1, 4, 1, 1, 1, 1  },
            new int[] { 1, 4, 1 },
            new int[] { 0, 0, 0, 0, 0, 0 })]
        public void Test1(int[] array, int[] key, int[] result)
        {
            int[] resultFunction = FindArray.FindOnWhichIterationsTheKeyOccurs(array, key);
            resultFunction.Should().BeEquivalentTo(result);
        }
    }
}
