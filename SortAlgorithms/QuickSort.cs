using System;

namespace SortAlgorithms
{
    public partial class QuickSort : SortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            DoSort(data, 0, data.Length - 1);

            return data;
        }

        private void DoSort(int[] data, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {

                var pivotIndex = GetPivotIndex(leftIndex, rightIndex);
                var pivot = data[pivotIndex];

                var leftBoundariesIndex = (pivotIndex == leftIndex);
                var rightBoundariesIndex = (pivotIndex == rightIndex);

                var index = DoSort(data, pivot, leftIndex, rightIndex);

                if (leftIndex < index - 1)
                {
                    if (index - leftIndex == 1)
                    {
                        // break
                        if (data[index] < data[leftIndex])
                        {
                            data.Swap(leftIndex, index - 1);
                        }

                    }
                    else
                    {
                        DoSort(data, leftIndex, index - 1);
                    }
                }

                if (index < rightIndex)
                {
                    if (rightIndex - index == 1)
                    {
                        // break
                        if (data[rightIndex] < data[index])
                        {
                            data.Swap(index, rightIndex);
                        }

                    }
                    else
                    {
                        DoSort(data, index, rightIndex);
                    }
                }

            }
        }

        private int DoSort(int[] data, int pivot, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                leftIndex = GetLeftIndex(data, pivot, leftIndex, rightIndex);
                rightIndex = GetRightIndex(data, pivot, leftIndex, rightIndex);

                if (leftIndex < rightIndex)
                {
                    data.Swap(leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }

        private int GetPivotIndex(int min, int max)
        {
            var pivotIndex = (min + max) / 2;
            return pivotIndex;
        }

        private int GetLeftIndex(int[] data, int pivot, int leftIndex, int rightIndex)
        {
            while ((data[leftIndex] < pivot) && (leftIndex < rightIndex))
            {
                leftIndex++;
            }

            return leftIndex;
        }

        private int GetRightIndex(int[] data, int pivot, int leftIndex, int rightIndex)
        {
            while ((data[rightIndex] > pivot) && (rightIndex > leftIndex))
            {
                rightIndex--;
            }

            return rightIndex;
        }
    }
}
