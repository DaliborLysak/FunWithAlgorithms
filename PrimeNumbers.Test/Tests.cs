namespace PrimeNumbers.Test;

using PrimeNumbers;
using System.Collections.Generic;
using Xunit;

public class Tests
{
    public static IEnumerable<object[]> Data = new List<object[]>()
    {
        new object[] { 1, Array.Empty<int>() },
        new object[] { 10, new int[] { 2, 3, 5, 7 } },
        new object[] { 100, new int [] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 } },
        new object[] { 200, new int [] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 } },
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int number, int[] expected)
    {
        // arrange
        var primeCalculator = new PrimeCalculator();

        // act
        var actual = primeCalculator.GetPrimes(number);

        // assert
        Assert.Equal(expected, actual);
    }
}