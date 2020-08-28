using System;
using Xunit;
using Ackerman;

namespace AckermanFunction.Test
{
    public class AckermanTest
    {
        [Fact]
        public void A00()
        {
            Assert.Equal(1, Ackerman.AckermanFunction.Execute(0, 0));
        }

        [Fact]
        public void A01()
        {
            Assert.Equal(2, Ackerman.AckermanFunction.Execute(0, 1));
        }

        [Fact]
        public void A10()
        {
            Assert.Equal(2, Ackerman.AckermanFunction.Execute(1, 0));
        }

        [Fact]
        public void A11()
        {
            Assert.Equal(3, Ackerman.AckermanFunction.Execute(1, 1));
        }

        [Fact]
        public void A02()
        {
            Assert.Equal(3, Ackerman.AckermanFunction.Execute(0, 2));
        }

        [Fact]
        public void A20()
        {
            Assert.Equal(3, Ackerman.AckermanFunction.Execute(2, 0));
        }

        [Fact]
        public void A21()
        {
            Assert.Equal(5, Ackerman.AckermanFunction.Execute(2, 1));
        }

        [Fact]
        public void A12()
        {
            Assert.Equal(4, Ackerman.AckermanFunction.Execute(1, 2));
        }
    }
}
