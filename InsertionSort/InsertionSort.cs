using System;
using System.Linq;

namespace InsertionSort
{
    public static class Insertion
    {
        public static int[] Sort(int[] data)
        {
            if (data.Count() > 1)
            {
                var i = 1;
                while (i < data.Count())
                {
                    var j = i;
                    while ((j > 0) && (data[j - 1] > data[j]))
                    {
                        var value = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = value;
                        j--;
                    }

                    i++;
                }
            }

            return data;
        }
    }
}
