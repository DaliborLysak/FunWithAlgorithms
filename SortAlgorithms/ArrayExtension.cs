using System;
using System.Linq;

namespace SortAlgorithms
{
    public static class ArrayExtension
    {
        public static void Swap(this int[] array, int index1, int index2)
        {
            Swap<int>(array, index1, index2);
        }

        public static void Swap<T>(this T[] array, int index1, int index2)
        {
            var value = array[index1];
            array[index1] = array[index2];
            array[index2] = value;
        }

        public static int[] SubArray(this int[] array, int offset, int length)
        {
            return SubArray<int>(array, offset, length);
        }

        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            return array.Skip(offset).Take(length).ToArray();
        }
    }
}
