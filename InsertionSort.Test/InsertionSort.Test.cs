using System;
using Xunit;
using InsertionSort;

namespace InsertionSort.Test
{
    public class InsertionSortTest
    {
        [Fact]
        public void IS0()
        {
            Assert.Equal(new int[0], InsertionSort.Insertion.Sort(new int[0]));
        }

        [Fact]
        public void IS0Fail()
        {
            Assert.NotEqual(new int[1], InsertionSort.Insertion.Sort(new int[0]));
        }

        [Fact]
        public void IS1()
        {
            Assert.Equal(new int[1] { 5 }, InsertionSort.Insertion.Sort(new int[1] { 5 }));
        }

        [Fact]
        public void IS10()
        {
            Assert.Equal(
                new int[10] { -8, -5, -2, 0, 1, 3, 3, 8, 10, 15 },
                InsertionSort.Insertion.Sort(new int[10] { -5, 10, 3, -8, 8, 0, -2, 15, 3, 1 }));
        }
    }
}
