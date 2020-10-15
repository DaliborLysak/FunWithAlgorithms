using System;
using Xunit;
using SortAlgorithms;

namespace QuickSort.Test
{
    public class QuickSortTest
    {
        [Fact]
        public void QS0()
        {
            Assert.Equal(new int[0], SortAlgorithmService.Sort<SortAlgorithms.QuickSort>(new int[0]));
        }

        [Fact]
        public void QS0Fail()
        {
            Assert.NotEqual(new int[1], SortAlgorithmService.Sort<SortAlgorithms.QuickSort>(new int[0]));
        }

        [Fact]
        public void QS1()
        {
            Assert.Equal(new int[] { 5 }, SortAlgorithmService.Sort<SortAlgorithms.QuickSort>(new int[1] { 5 }));
        }

        [Fact]
        public void QS10()
        {
            Assert.Equal(
                new int[10] { -8, -5, -2, 0, 1, 3, 3, 8, 10, 15 },
                SortAlgorithmService.Sort<SortAlgorithms.QuickSort>(new int[10] { -5, 10, 3, -8, 8, 0, -2, 15, 3, 1 }));
        }
    }
}
