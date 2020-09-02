using System;
using Xunit;
using Fibonacci;

namespace Fibonacci.Test
{
    public class FibonacciTest
    {
        [Fact]
        public void F0()
        {
            Assert.Equal(0, Fibonacci.FibonacciNumber.Execute(0));
        }

        [Fact]
        public void F1()
        {
            Assert.Equal(1, Fibonacci.FibonacciNumber.Execute(1));
        }

        [Fact]
        public void F2()
        {
            Assert.Equal(1, Fibonacci.FibonacciNumber.Execute(2));
        }

        [Fact]
        public void F3()
        {
            Assert.Equal(2, Fibonacci.FibonacciNumber.Execute(3));
        }

        [Fact]
        public void F4()
        {
            Assert.Equal(3, Fibonacci.FibonacciNumber.Execute(4));
        }

        [Fact]
        public void F5()
        {
            Assert.Equal(5, Fibonacci.FibonacciNumber.Execute(5));
        }

        [Fact]
        public void F6()
        {
            Assert.Equal(8, Fibonacci.FibonacciNumber.Execute(6));
        }

        [Fact]
        public void F7()
        {
            Assert.Equal(13, Fibonacci.FibonacciNumber.Execute(7));
        }

        [Fact]
        public void F10()
        {
            Assert.Equal(55, Fibonacci.FibonacciNumber.Execute(10));
        }

        [Fact]
        public void F15()
        {
            Assert.Equal(610, Fibonacci.FibonacciNumber.Execute(15));
        }

        [Fact]
        public void F20()
        {
            Assert.Equal(6765, Fibonacci.FibonacciNumber.Execute(20));
        }

        [Fact]
        public void FFail()
        {
            Assert.Throws(new ArgumentException().GetType(), () => { var value = Fibonacci.FibonacciNumber.ExecuteRecursion(new int[3] { 1, 2, 3 }); });
        }

        [Fact]
        public void FFailTail()
        {
            Assert.Throws(new ArgumentException().GetType(), () => { var value = Fibonacci.FibonacciNumber.ExecuteTailRecursion(new int[3] { 1, 2, 3 }); });
        }

        [Fact]
        public void AFailL()
        {
            Assert.Throws(new ArgumentException().GetType(), () => { var value = Fibonacci.FibonacciNumber.ExecuteRecursion(new int[0]); });
        }

        [Fact]
        public void AFailLTail()
        {
            Assert.Throws(new ArgumentException().GetType(), () => { var value = Fibonacci.FibonacciNumber.ExecuteTailRecursion(new int[0]); });
        }
    }
}
