using System;
using Xunit;
using Ackerman;
using System.Collections.Generic;

namespace AckermanFunction.Test
{
    public class AckermanTest
    {
        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(0, 1, 2)]
        [InlineData(1, 0, 2)]
        [InlineData(1, 1, 3)]
        [InlineData(0, 2, 3)]
        [InlineData(2, 0, 3)]
        [InlineData(2, 1, 5)]
        [InlineData(1, 2, 4)]
        [InlineData(4, 0, 13)]
        [InlineData(3, 4, 125)]
        public void Execute(int argument1, int argument2, int resultExpected)
        {
            // arrange

            // act
            var resultActual = Ackerman.AckermanFunction.Execute(argument1, argument2);

            // assert
            Assert.Equal(resultExpected, resultActual);
        }

        public static IEnumerable<object[]> Arguments =>
            new List<object[]>
                {
                    new object[] { new int[0], typeof(ArgumentException) },
                    new object[] { new int[3] { 1, 2, 3 }, typeof(ArgumentException) }
                };

        [Theory, MemberData(nameof(Arguments))]
        public void ExecuteWithArgumentException(int[] arguments, Type type)
        {
            // arrange

            // act

            // assert
            Assert.Throws(type, () => { Ackerman.AckermanFunction.Execute(arguments); });
        }
    }
}
