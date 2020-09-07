using System;
using System.Linq;

namespace SortAlgorithms
{
    public class InsertionSort : SortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            var i = 1;
            while (i < data.Count())
            {
                var j = i;
                while ((j > 0) && (data[j - 1] > data[j]))
                {
                    data.Swap(j - 1, j);
                    j--;
                }

                i++;
            }

            return data;
        }
    }
}
