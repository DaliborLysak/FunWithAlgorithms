using System;
using System.Linq;

namespace SortAlgorithms
{
    public class SelectionSort : SortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            for (var i = 0; i < data.Count(); i++)
            {
                var minimumIndex = i;

                for (var j = i + 1; j < data.Count(); j++)
                {
                    if (data[j] < data[minimumIndex])
                    {
                        minimumIndex = j;
                    }

                }

                data.Swap(i, minimumIndex);
            }


            return data;
        }
    }
}
