using System;
using System.Linq;

namespace SortAlgorithms
{
    public static class ArrayExtension
    {
        public static void Swap(this int[] array, int index1, int index2)
        {
            var value = array[index1];
            array[index1] = array[index2];
            array[index2] = value;
        }
    }
}
