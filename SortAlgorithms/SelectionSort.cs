using System;
using System.Linq;

namespace SortAlgorithms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] data)
        {
            if (data.Count() > 1)
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

                    var value = data[i];
                    data[i] = data[minimumIndex];
                    data[minimumIndex] = value;
                }

            }

            return data;
        }
    }
}
