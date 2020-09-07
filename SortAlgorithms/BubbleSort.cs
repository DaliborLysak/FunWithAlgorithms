using System;
using System.Linq;

namespace SortAlgorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            var swapped = false;
            do
            {
                swapped = false;

                for (var i = 0; i < data.Count() - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        data.Swap(i, i + 1);
                        swapped = true;
                    }
                }

            } while (swapped);

            return data;
        }
    }
}
