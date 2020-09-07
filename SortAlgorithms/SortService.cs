using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public static class SortAlgorithmService
    {
        public static int[] Sort<T>(int[] data) where T : ISortAlgorithm, new()
        {
            if (data.Count() > 1)
            {
                data = new T().Sort(data);
            }

            return data;
        }
    }
}