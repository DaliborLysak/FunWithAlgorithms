using System;
using Xunit;
using Fibonacci;
using System.Collections.Generic;

namespace Fibonacci.Test
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(10, 55)]
        [InlineData(15, 610)]
        [InlineData(20, 6765)]
        public void Execute(int number, int expectedValue)
        {
            Assert.Equal(expectedValue, Fibonacci.FibonacciNumber.Execute(number));
        }

        public static IEnumerable<object[]> Arguments =>
            new List<object[]>
                {
                    new object[] { new int[0], typeof(ArgumentException) },
                    new object[] { new int[3] { 1, 2, 3 }, typeof(ArgumentException) }
                };

        [Theory, MemberData(nameof(Arguments))]
        public void ExecuteRecursionWithArgumentException(int[] arguments, Type type)
        {
            // arrange

            // act

            // assert
            Assert.Throws(type, () => { Fibonacci.FibonacciNumber.ExecuteRecursion(arguments); });
        }

        [Theory, MemberData(nameof(Arguments))]
        public void ExecuteTailRecursionWithArgumentException(int[] arguments, Type type)
        {
            // arrange

            // act

            // assert
            Assert.Throws(type, () => { Fibonacci.FibonacciNumber.ExecuteTailRecursion(arguments); });
        }
    }
}
