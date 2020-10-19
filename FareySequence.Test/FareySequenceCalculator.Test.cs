using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FareySequence;

namespace FareySequence.Test
{
    public class FareySequenceTest
    {
        [Fact]
        public void F0()
        {
            var expected = new FareyPair[0];
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(0).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F1()
        {
            var expected = new FareyPair[2]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(1).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F2()
        {
            var expected = new FareyPair[3]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 2),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(2).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F3()
        {
            var expected = new FareyPair[5]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 3),
                new FareyPair(1, 2),
                new FareyPair(2, 3),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(3).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F4()
        {
            var expected = new FareyPair[7]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 4),
                new FareyPair(1, 3),
                new FareyPair(1, 2),
                new FareyPair(2, 3),
                new FareyPair(3, 4),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(4).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F5()
        {
            var expected = new FareyPair[11]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 5),
                new FareyPair(1, 4),
                new FareyPair(1, 3),
                new FareyPair(2, 5),
                new FareyPair(1, 2),
                new FareyPair(3, 5),
                new FareyPair(2, 3),
                new FareyPair(3, 4),
                new FareyPair(4, 5),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(5).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F6()
        {
            var expected = new FareyPair[13]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 6),
                new FareyPair(1, 5),
                new FareyPair(1, 4),
                new FareyPair(1, 3),
                new FareyPair(2, 5),
                new FareyPair(1, 2),
                new FareyPair(3, 5),
                new FareyPair(2, 3),
                new FareyPair(3, 4),
                new FareyPair(4, 5),
                new FareyPair(5, 6),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(6).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F7()
        {
            var expected = new FareyPair[19]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 7),
                new FareyPair(1, 6),
                new FareyPair(1, 5),
                new FareyPair(1, 4),
                new FareyPair(2, 7),
                new FareyPair(1, 3),
                new FareyPair(2, 5),
                new FareyPair(3, 7),
                new FareyPair(1, 2),
                new FareyPair(4, 7),
                new FareyPair(3, 5),
                new FareyPair(2, 3),
                new FareyPair(5, 7),
                new FareyPair(3, 4),
                new FareyPair(4, 5),
                new FareyPair(5, 6),
                new FareyPair(6, 7),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(7).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }

        [Fact]
        public void F8()
        {
            var expected = new FareyPair[23]
            {
                new FareyPair(0, 1),
                new FareyPair(1, 8),
                new FareyPair(1, 7),
                new FareyPair(1, 6),
                new FareyPair(1, 5),
                new FareyPair(1, 4),
                new FareyPair(2, 7),
                new FareyPair(1, 3),
                new FareyPair(3, 8),
                new FareyPair(2, 5),
                new FareyPair(3, 7),
                new FareyPair(1, 2),
                new FareyPair(4, 7),
                new FareyPair(3, 5),
                new FareyPair(5, 8),
                new FareyPair(2, 3),
                new FareyPair(5, 7),
                new FareyPair(3, 4),
                new FareyPair(4, 5),
                new FareyPair(5, 6),
                new FareyPair(6, 7),
                new FareyPair(7, 8),
                new FareyPair(1, 1),
            };
            var calculator = new FareySequenceCalculator();
            var actual = calculator.CalculatePairs(8).ToArray();
            Assert.True(calculator.Compare(expected, actual));
        }
    }
}
